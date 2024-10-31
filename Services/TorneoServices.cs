using ApiNet8.Data;
using ApiNet8.Migrations;
using ApiNet8.Models;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Partidos;
using ApiNet8.Models.Reservas;
using ApiNet8.Models.Torneos;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace ApiNet8.Services
{
    public class TorneoServices : ITorneoServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDisciplinasYLeccionesServices _disciplinasYLeccionesServices;
        private readonly ICategoriaServices _categoriaServices;
        private readonly IInstalacionServices _instalacionServices;
        private readonly IReservasServices _reservasServices;
        private readonly IEventoServices _eventoServices;
        private readonly ITipoEventoServices _tipoEventoServices;
        private readonly IUsuarioServices _usuarioServices;
        private readonly IEquipoServices _equipoServices;
        private readonly ITorneoEstadoServices _torneoEstadoServices;
        private readonly IEventoEstadoService _eventoEstadoService;
        private readonly ILogger<EventoServices> _logger;

        public TorneoServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, IDisciplinasYLeccionesServices disciplinasYLeccionesServices, ICategoriaServices categoriaServices, IInstalacionServices instalacionServices, IReservasServices reservasServices, IEventoServices eventoServices, ITipoEventoServices tipoEventoServices, IUsuarioServices usuarioServices, IEquipoServices equipoServices, ILogger<EventoServices> logger, ITorneoEstadoServices torneoEstadoServices, IEventoEstadoService eventoEstadoService)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _disciplinasYLeccionesServices = disciplinasYLeccionesServices;
            _categoriaServices = categoriaServices;
            _instalacionServices = instalacionServices;
            _reservasServices = reservasServices;
            _eventoServices = eventoServices;
            _tipoEventoServices = tipoEventoServices;
            _usuarioServices = usuarioServices;
            _equipoServices = equipoServices;
            _logger = logger;
            _torneoEstadoServices = torneoEstadoServices;
            _eventoEstadoService = eventoEstadoService;
        }

        public bool ExisteTorneo(string nombre)
        {
            Torneo? evento = _db.Torneo
                .Include(he => he.TorneoHistoriales).ThenInclude(ee => ee.TorneoEstado)
                .Where(e => e.Nombre.Equals(nombre) && e.TorneoHistoriales.Any(f => f.FechaFin == null
                && (f.TorneoEstado.NombreEstado == Enums.EstadoTorneo.Abierto.ToString() || f.TorneoEstado.NombreEstado == Enums.EstadoTorneo.EnCurso.ToString()))).FirstOrDefault();

            return evento != null ? true : false;

        }

        public Torneo? GetTorneoById(int idTorneo)
        {
            Torneo? torneo = _db.Torneo.Include(d=>d.Disciplina).Include(c=>c.Categoria).Include(h=>h.TorneoHistoriales).ThenInclude(e=>e.TorneoEstado).Where(i=>i.Id==idTorneo).FirstOrDefault();
            return torneo != null ? torneo : null;
        }

        public void CrearTorneo(TorneoDTO torneoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");
                Torneo torneo = _mapper.Map<Torneo>(torneoDTO);

                if (ExisteTorneo(torneo.Nombre))
                {
                    throw new Exception("Ya existe un torneo con ese nombre.");
                }

                // Asignar disciplinas
                Disciplina? d = _disciplinasYLeccionesServices.GetDisciplinaById(torneoDTO.IdDisciplina);
                if (d == null)
                {
                    throw new Exception("No existe la disciplina seleccionada.");
                }
                torneo.Disciplina = d;

                // Asignar categoría
                Categoria categoria = _categoriaServices.GetCategoriaById(torneoDTO.IdCategoria);
                if (categoria == null)
                {
                    throw new Exception("No existe la categoria seleccionada.");
                }
                torneo.Categoria = _categoriaServices.GetCategoriaById(torneoDTO.IdCategoria);

                // buscar instalacion
                Instalacion instalacion = _instalacionServices.GetInstalacionById(torneoDTO.IdInstalacion);

                // Crear historial y asignarlo al torneo
                TorneoHistorial historialTorneo = new TorneoHistorial
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se crea torneo",
                    UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                    TorneoEstado = _torneoEstadoServices.GetTorneoEstadoById(1) // Asigno estado abierto
                };
                _db.TorneoHistorial.Add(historialTorneo);

                torneo.TorneoHistoriales = new List<TorneoHistorial> { historialTorneo };

                // Crear partidos y fases
                int cantidadEquipos = torneoDTO.CantEquipos;
                int cantidadPartidos = cantidadEquipos - 1;
                List<Partido> partidos = new List<Partido>();
                List<PartidoFase> fases = new List<PartidoFase>();

                int faseActual = 1;
                int partidosPorFase = cantidadEquipos / 2;
                List<PartidoFase> faseAnterior = new List<PartidoFase>();

                while (partidosPorFase >= 1)
                {
                    // creo el partido fase de la fase
                    PartidoFase partidoFase = new PartidoFase
                    {
                        FasePartido = faseActual,
                        FechaCreacion = DateTime.Now,
                        UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                        Torneo = torneo,
                        Partidos = new List<Partido>(),
                        Llave = new List<PartidoFase>()
                    };

                    // en cada fase la fecha se incrementa 7 dias
                    DateTime fechaInicio = torneoDTO.FechaInicio.AddDays((faseActual - 1) * 7);

                    // creo los partidos y los agrego al partidofase actual
                    for (int i = 0; i < partidosPorFase; i++)
                    {
                        Partido partido = new Partido
                        {
                            FechaInicio = fechaInicio,
                            FechaFinEvento = fechaInicio.AddHours(2),
                            Disciplina = torneo.Disciplina,
                            Categoria = torneo.Categoria,
                            Instalacion = instalacion,
                            TipoEvento = _tipoEventoServices.GetTipoEventoById(1),
                            Titulo = $"Partido de torneo {torneo.Nombre} Nro: {i + 1} Fase: {faseActual}",
                            Banner = torneo.Banner,

                        };

                        partidoFase.Partidos.Add(partido);
                        partidos.Add(partido);

                        // Incrementar la fechaInicio para el siguiente partido
                        fechaInicio = fechaInicio.AddHours(2);
                    }

                    fases.Add(partidoFase);

                    // Preparar la siguiente fase                    
                    partidosPorFase /= 2;
                    faseActual++;
                }

                // Asignar las llaves después de haber creado todas las fases
                for (int i = 1; i < fases.Count; i++)
                {
                    fases[i].Llave = new List<PartidoFase> { fases[i - 1] };
                }

                // Asignar equipos a los partidos de la primera fase
                if (torneoDTO.IdEquipos.Count > 0)
                {
                    var equipos = torneoDTO.IdEquipos.Select(id => _equipoServices.GetEquipoEventoById(id)).ToList();
                    int equipoIndex = 0;

                    foreach (var partido in fases.First().Partidos)
                    {
                        if (equipoIndex < equipos.Count)
                        {
                            Partido part = partidos.Find(p => p.Titulo == partido.Titulo);

                            if (part != null)
                            {
                                EquipoPartido local = new EquipoPartido
                                {
                                    FechaCreacion = DateTime.Now,
                                    Equipo = equipos[equipoIndex++],
                                    JugadoresEnBanca = new List<string>(),
                                    JugadoresEnCancha = new List<string>()
                                };
                                part.Local = local;
                                _db.EquipoPartido.Add(local);
                            }
                        }
                        if (equipoIndex < equipos.Count)
                        {
                            Partido part = partidos.Find(p => p.Titulo == partido.Titulo);

                            if (part != null)
                            {
                                EquipoPartido visitante = new EquipoPartido
                                {
                                    FechaCreacion = DateTime.Now,
                                    Equipo = equipos[equipoIndex++],
                                    JugadoresEnBanca = new List<string>(),
                                    JugadoresEnCancha = new List<string>()
                                };
                                part.Visitante = visitante;
                                _db.EquipoPartido.Add(visitante);
                            }
                        }
                        if (equipoIndex >= equipos.Count)
                        {
                            break; // Detener el bucle una vez que se han asignado todos los equipos disponibles
                        }
                    }
                }
               

                // por cada partido crear evento
                foreach (var item in partidos)
                {
                    // verificar que no este reservada la instalacion
                    bool instalacionDisponible = _reservasServices.VerificarInstalacionDisponible((DateTime)item.FechaInicio, (DateTime)item.FechaFinEvento, instalacion, (Evento)item);

                    if (!instalacionDisponible)
                    {
                        throw new Exception("La instalacion no esta disponible en ese dia y horario para el partido " + item.Titulo);
                    }

                    // se crea reserva
                    int idUsuario = currentUser != null ? currentUser.Id : 1;
                    Usuario usuario = _db.Usuario.Where(u => u.Id == idUsuario).FirstOrDefault();

                    Reserva reserva = new Reserva
                    {
                        FechaReserva = DateTime.Now,
                        HoraInicio = (DateTime)item.FechaInicio,
                        HoraFin = (DateTime)item.FechaFinEvento,
                        FechaCreacion = DateTime.Now,
                        UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                        Usuario = usuario,
                        Instalacion = instalacion
                    };
                    _db.Reserva.Add(reserva);

                    // crear historial y asignarlo al evento
                    HistorialEvento historialEvento = new HistorialEvento
                    {
                        FechaInicio = DateTime.Now,
                        DetalleCambioEstado = "Se crea evento tipo " + item.TipoEvento.NombreTipoEvento,
                        UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                        EstadoEvento = _eventoEstadoService.GetEventoEstadoById(1) // asigno estado creado
                    };
                    item.HistorialEventoList = new List<HistorialEvento>();
                    item.HistorialEventoList.Add(historialEvento);
                    _db.HistorialEvento.Add(historialEvento);

                    // Obtener los jugadores de ambos equipos y agregarlos al partido
                    item.Usuarios = new List<Usuario>();

                    // Agregar jugadores del equipo local
                    if (item.Local != null)
                    {
                        List<Usuario> jugadoresLocal = item.Local.Equipo.EquipoUsuarios.Select(eu => eu.Usuario).ToList();
                        foreach (var usu in jugadoresLocal)
                        {
                            item.Usuarios.Add(usu);
                        }
                    }

                    // Agregar jugadores del equipo visitante
                    if (item.Visitante != null)
                    {
                        List<Usuario> jugadoresVisitante = item.Visitante.Equipo.EquipoUsuarios.Select(eu => eu.Usuario).ToList();
                        foreach (var usu in jugadoresVisitante)
                        {
                            item.Usuarios.Add(usu);
                        }
                    }

                    _db.Partido.Add(item);

                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Torneo.Add(torneo);
                    _db.PartidoFase.AddRange(fases);
                    _db.SaveChanges();                   
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                var eventoJson = JsonSerializer.Serialize(torneoDTO, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                _logger.LogError(e, "Error al crear el torneo" + eventoJson);
                throw new Exception(e.Message, e);
            }  
        }

        public void EditarTorneo(TorneoDTO torneoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                // obtener el torneo a editar
                Torneo? torneo = GetTorneoById(torneoDTO.Id);

                if (torneo == null) 
                {
                    throw new Exception("No existe el torneo");
                }

                // verificar si ya existe un torneo con ese nombre
                if (torneoDTO.Nombre != null)
                {
                    bool existe = _db.Torneo.Include(a => a.TorneoHistoriales).Any(le => (le.Nombre == torneoDTO.Nombre && le.Id != torneoDTO.Id) && le.TorneoHistoriales.Any(h => h.FechaFin == null &&
                   (h.TorneoEstado.NombreEstado == ApiNet8.Utils.Enums.EstadoTorneo.Abierto.ToString() || h.TorneoEstado.NombreEstado == ApiNet8.Utils.Enums.EstadoTorneo.EnCurso.ToString())));

                    if (existe)
                    {
                        throw new Exception("Ya existe un torneo con ese nombre.");
                    }
                }

                // Asignar disciplinas
                if (torneoDTO.IdDisciplina > 0)
                {
                    Disciplina? d = _disciplinasYLeccionesServices.GetDisciplinaById(torneoDTO.IdDisciplina);
                    if (d == null)
                    {
                        throw new Exception("No existe la disciplina seleccionada.");
                    }
                    torneo.Disciplina = d;
                }


                // Asignar categoría
                if (torneoDTO.IdCategoria > 0)
                {
                    Categoria categoria = _categoriaServices.GetCategoriaById(torneoDTO.IdCategoria);
                    if (categoria == null)
                    {
                        throw new Exception("No existe la categoria seleccionada.");
                    }
                    torneo.Categoria = _categoriaServices.GetCategoriaById(torneoDTO.IdCategoria);
                }

                // cambia fecha o instalacion

                // obtengo un partido del torneo para ver cual es la instalacion
                PartidoFase? partidos = _db.PartidoFase.Include(p => p.Partidos).Where(t => t.Torneo.Id == torneo.Id).FirstOrDefault();
                int idInstalacion = partidos != null ? partidos.Partidos.FirstOrDefault()!.Instalacion.Id : 0;

                List<Partido> partidosTorneo = new List<Partido>();
                List<PartidoFase> partidosFases = new List<PartidoFase>();

                if ((torneoDTO.IdInstalacion > 0 && idInstalacion != torneoDTO.IdInstalacion) || (torneoDTO.FechaInicio != DateTime.MinValue && torneoDTO.FechaInicio != torneo.FechaInicio))
                {
                    // buscar instalacion
                    Instalacion instalacion = torneoDTO.IdInstalacion > 0 ? _instalacionServices.GetInstalacionById(torneoDTO.IdInstalacion) : _instalacionServices.GetInstalacionById(idInstalacion);

                    // buscar todos los partidos y cancelarles la reserva y hacer una nueva

                    // obtengo todos los partidos del torneo
                     partidosFases = _db.PartidoFase
                        .Include(p => p.Partidos).ThenInclude(e => e.Local).ThenInclude(e => e.Equipo)
                        .Include(p => p.Partidos).ThenInclude(e => e.Visitante).ThenInclude(e => e.Equipo)
                        .Where(t=>t.Torneo.Id == torneo.Id).ToList();

                    // recorro cada fase y cada partido
                    int faseActual = 1;
                    foreach (var item in partidosFases)
                    {
                        partidosTorneo.AddRange(item.Partidos.ToList());
                        DateTime fechaInicio = torneoDTO.FechaInicio != DateTime.MinValue ? torneoDTO.FechaInicio.AddDays((faseActual - 1) * 7) : torneo.FechaInicio.AddDays((faseActual -1)*7);

                        foreach (var part in item.Partidos)
                        {
                            // verificar que no este reservada
                            DateTime fechaInicioReserva = fechaInicio;
                            DateTime fechaFinReserva = fechaInicioReserva.AddHours(2);

                            bool instalacionDisponible = _reservasServices.VerificarInstalacionDisponible(fechaInicioReserva, fechaFinReserva, instalacion, (Evento)part);

                            if (!instalacionDisponible)
                            {
                                throw new Exception("La instalacion no esta disponible en ese dia y horario para el partido: " + part.Titulo);
                            }

                            // Incrementar la fechaInicio para el siguiente partido
                            fechaInicio = fechaInicio.AddHours(2);

                            // se da de baja la reserva anterior
                            Reserva? reservaAnterior = _reservasServices.GetReservasByInstalacion(instalacion).Where(f => f.HoraInicio == part.FechaInicio && f.HoraFin == part.FechaFinEvento).OrderByDescending(f => f.FechaCreacion).FirstOrDefault();

                            if (reservaAnterior != null)
                            {
                                reservaAnterior.FechaBaja = DateTime.Now;
                                reservaAnterior.FechaModificacion = DateTime.Now;
                                reservaAnterior.UsuarioEditor = currentUser != null ? currentUser.Id : 0;
                                _db.Reserva.Update(reservaAnterior);
                            }

                            // asignar instalacion
                            part.Instalacion = instalacion;
                            part.FechaInicio = fechaInicioReserva;
                            part.FechaFinEvento = fechaFinReserva;

                            // se crea nueva reserva
                            int idUsuario = currentUser != null ? currentUser.Id : 1;
                            Usuario usuario = _db.Usuario.Where(u => u.Id == idUsuario).FirstOrDefault()!;

                            Reserva reserva = new Reserva
                            {
                                FechaReserva = DateTime.Now,
                                HoraInicio = fechaInicioReserva,
                                HoraFin = fechaFinReserva,
                                FechaCreacion = DateTime.Now,
                                UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                                Usuario = usuario,
                                Instalacion = instalacion
                            };

                            _db.Reserva.Add(reserva);
                        }
                        faseActual++;

                    }                   
                }

                // se da de baja el historial anterior
                TorneoHistorial? ultimoHistorial = torneo.TorneoHistoriales.Where(f => f.FechaFin == null).FirstOrDefault();
                if (ultimoHistorial != null)
                {
                    ultimoHistorial.FechaFin = DateTime.Now;
                    _db.TorneoHistorial.Update(ultimoHistorial);
                }

                // crear nuevo historial y asignarlo al torneo
                TorneoHistorial historialTorneo = new TorneoHistorial
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se modifica torneo",
                    UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                    TorneoEstado = ultimoHistorial != null ? ultimoHistorial.TorneoEstado : _torneoEstadoServices.GetTorneoEstadoById(1) // asigno que ya tenia
                };
                torneo.TorneoHistoriales = torneo.TorneoHistoriales == null ? new List<TorneoHistorial>() : torneo.TorneoHistoriales;
                torneo.TorneoHistoriales.Add(historialTorneo);                
                _db.TorneoHistorial.Add(historialTorneo);
                
                // Asignar equipos a los partidos de la primera fase
                if (torneoDTO.IdEquipos != null && torneoDTO.IdEquipos.Count > 0)
                {
                    // equipos que envio
                    List<Equipo> equiposNuevos = torneoDTO.IdEquipos.Select(id => _equipoServices.GetEquipoEventoById(id)).ToList();
                              
                    // equipos actuales
                    List<Partido> partidosFase1 = partidosFases.Where(f=>f.FasePartido == 1).FirstOrDefault()!.Partidos.ToList();
                    List<Equipo> equiposActuales = new List<Equipo>();

                    // busco los equipos actuales en los partidos de la fase1
                    foreach (var item in partidosFase1)
                    {
                        if (item.Local != null)
                        {
                            Equipo equipo = _equipoServices.GetEquipoEventoById(item.Local.Equipo.Id);
                            equiposActuales.Add(equipo);
                        }

                        if (item.Visitante != null)
                        {
                            Equipo equipo = _equipoServices.GetEquipoEventoById(item.Visitante.Equipo.Id);
                            equiposActuales.Add(equipo);
                        }
                    }

                    // Crear la lista de equipos que ya no están
                    List<Equipo> equiposYaNoEstan = equiposActuales.Where(e => !equiposNuevos.Any(n => n.Id == e.Id)).ToList();

                    // sacar de partidos los equipos que ya no estan
                    foreach (var item in equiposYaNoEstan)
                    {
                        foreach (var partido in partidosFase1)
                        {
                            if (partido.Local != null && partido.Local.Equipo.Id == item.Id)
                            {
                                // obtener el equipo partido y darlo de baja
                                EquipoPartido equip = partido.Local;
                                equip.FechaBaja = DateTime.Now;
                                _db.EquipoPartido.Update(equip);
                                partido.Local = null;
                            }

                            if (partido.Visitante != null && partido.Visitante.Equipo.Id == item.Id)
                            {
                                // obtener el equipo partido y darlo de baja
                                EquipoPartido equip = partido.Visitante;
                                equip.FechaBaja = DateTime.Now;
                                _db.EquipoPartido.Update(equip);
                                partido.Visitante = null;
                            }
                        }
                    }
                                        
                    // Verificar de la lista equiposNuevos cuáles equipos ya tienen un equipoPartido asignado a un partido de la fase 1 y sacarlos de la lista equiposNuevos
                    equiposNuevos = equiposNuevos.Where(n => !partidosFase1.Any(p =>
                        (p.Local != null && p.Local.Equipo.Id == n.Id) ||
                        (p.Visitante != null && p.Visitante.Equipo.Id == n.Id))
                    ).ToList();

                    // asignar cada equipo nuevo a un partido
                    int equipoIndex = 0;
                    foreach (var partido in partidosFase1)
                    {
                        if (partido.Local == null && equipoIndex < equiposNuevos.Count)
                        {
                            EquipoPartido local = new EquipoPartido
                            {
                                FechaCreacion = DateTime.Now,
                                Equipo = equiposNuevos[equipoIndex++],
                                JugadoresEnBanca = new List<string>(),
                                JugadoresEnCancha = new List<string>()
                            };
                            partido.Local = local;
                            _db.EquipoPartido.Add(local);
                        }

                        if (partido.Visitante == null && equipoIndex < equiposNuevos.Count)
                        {
                            EquipoPartido visitante = new EquipoPartido
                            {
                                FechaCreacion = DateTime.Now,
                                Equipo = equiposNuevos[equipoIndex++],
                                JugadoresEnBanca = new List<string>(),
                                JugadoresEnCancha = new List<string>()
                            };
                            partido.Visitante = visitante;
                            _db.EquipoPartido.Add(visitante);
                        }

                        if (equipoIndex >= equiposNuevos.Count)
                        {
                            break; // Detener el bucle una vez que se han asignado todos los equipos disponibles
                        }
                    }
                }

                // Por cada partido editar evento, se hace aqui para recorrer y actualizar cada partido con _db
                foreach (var item in partidosTorneo)
                {
                    // Obtener los jugadores de ambos equipos y agregarlos al partido
                    item.Usuarios = new List<Usuario>();

                    // Agregar jugadores del equipo local
                    if (item.Local != null)
                    {
                        List<Usuario> jugadoresLocal = item.Local.Equipo.EquipoUsuarios.Select(eu => eu.Usuario).ToList();
                        foreach (var usu in jugadoresLocal)
                        {
                            if (!item.Usuarios.Any(u => u.Id == usu.Id))
                            {
                                item.Usuarios.Add(usu);
                            }
                        }
                    }

                    // Agregar jugadores del equipo visitante
                    if (item.Visitante != null)
                    {
                        List<Usuario> jugadoresVisitante = item.Visitante.Equipo.EquipoUsuarios.Select(eu => eu.Usuario).ToList();
                        foreach (var usu in jugadoresVisitante)
                        {
                            if (!item.Usuarios.Any(u => u.Id == usu.Id))
                            {
                                item.Usuarios.Add(usu);
                            }
                        }
                    }

                    _db.Partido.Update(item);
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Torneo.Update(torneo);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                var eventoJson = JsonSerializer.Serialize(torneoDTO, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                _logger.LogError(e, "Error al crear el torneo" + eventoJson);
                throw new Exception(e.Message, e);
            }
        }







    }
}

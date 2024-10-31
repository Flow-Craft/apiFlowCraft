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
using XSystem.Security.Cryptography;

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







    }
}

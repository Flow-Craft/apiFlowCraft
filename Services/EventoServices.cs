using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using ApiNet8.Models.Eventos;
using Microsoft.EntityFrameworkCore;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Reservas;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Services
{
    public class EventoServices : IEventoServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDisciplinasYLeccionesServices _disciplinasYLeccionesServices;
        private readonly ICategoriaServices _categoriaServices;
        private readonly IInstalacionServices _instalacionServices;
        private readonly IReservasServices _reservasServices;
        private readonly IEventoEstadoService _eventoEstadoService;
        private readonly ITipoEventoServices _tipoEventoServices;
      
        public EventoServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, IDisciplinasYLeccionesServices disciplinasYLeccionesServices, ICategoriaServices categoriaServices, IInstalacionServices instalacionServices, IReservasServices reservasServices, IEventoEstadoService eventoEstadoService, ITipoEventoServices tipoEventoServices)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _disciplinasYLeccionesServices = disciplinasYLeccionesServices;
            _categoriaServices = categoriaServices;
            _instalacionServices = instalacionServices;
            _reservasServices = reservasServices;
            _eventoEstadoService = eventoEstadoService;
            _tipoEventoServices = tipoEventoServices;
        }

        public List<Evento> GetEventos()
        {
            List<Evento> eventos = _db.Evento.Include(d=>d.Disciplinas).Include(c=>c.Categoria).Include(te=>te.TipoEvento).Include(i=>i.Instalacion).Include(he=>he.HistorialEventoList).ThenInclude(ee=>ee.EstadoEvento).ToList();
            return eventos;
        }

        public List<Evento> GetEventosActivos()
        {
            List<Evento> eventos = GetEventos();

            List<Evento> eventosActivos = new List<Evento>();

            foreach (var evento in eventos)
            {
                // obtener ultimo historial
                HistorialEvento? ultimoHistorial = evento?.HistorialEventoList?.Where(f=>f.FechaFin == null).OrderByDescending(f=>f.FechaInicio).FirstOrDefault();
                if (ultimoHistorial != null && (ultimoHistorial.EstadoEvento.NombreEstado != Enums.EstadoEvento.Cancelado.ToString() && ultimoHistorial.EstadoEvento.NombreEstado != Enums.EstadoEvento.Finalizado.ToString()))
                {
                    eventosActivos.Add(evento);
                }
            }

            return eventosActivos;
        }

        public Evento GetEventoById(int id)
        {
            try
            {
                return _db.Evento.Include(d => d.Disciplinas).Include(c => c.Categoria).Include(te => te.TipoEvento).Include(i => i.Instalacion).Include(he => he.HistorialEventoList).ThenInclude(ee => ee.EstadoEvento).Where(u => u.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteEvento(string nombre)
        {
            Evento? evento = _db.Evento                
                .Include(he => he.HistorialEventoList).ThenInclude(ee => ee.EstadoEvento)
                .Where(e => e.Titulo.Equals(nombre) && e.HistorialEventoList.Any(f => f.FechaFin == null
                && (f.EstadoEvento.NombreEstado != Enums.EstadoEvento.Cancelado.ToString() || f.EstadoEvento.NombreEstado != Enums.EstadoEvento.Finalizado.ToString()))).FirstOrDefault();

            return evento != null ? true : false;

        }

        public void CrearEvento(EventoDTO eventoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Evento evento = _mapper.Map<Evento>(eventoDTO);

                if (ExisteEvento(evento.Titulo))
                {
                    throw new Exception("Ya existe un evento con ese nombre.");
                }

                // asignar disciplinas
                evento.Disciplinas = new List<Disciplina>();

                foreach (var idDisc in eventoDTO?.IdsDisciplinas)
                {
                    Disciplina? d = _disciplinasYLeccionesServices.GetDisciplinaById(idDisc);
                    if (d != null) 
                    {
                        evento.Disciplinas.Add(d);
                    }
                }

                // asignar categoria
                evento.Categoria = _categoriaServices.GetCategoriaById(eventoDTO.IdCategoria);

                // asignar tipo de evento
                evento.TipoEvento = _tipoEventoServices.GetTipoEventoById(eventoDTO.IdTipoEvento);

                // buscar instalacion
                Instalacion instalacion = _instalacionServices.GetInstalacionById(eventoDTO.IdInstalacion);                

                // verificar que no este reservada
                bool instalacionDisponible = _reservasServices.VerificarInstalacionDisponible((DateTime)eventoDTO.FechaInicio, (DateTime)eventoDTO.FechaFinEvento, instalacion);

                if (!instalacionDisponible)
                {
                    throw new Exception("La instalacion no esta disponible en ese dia y horario.");
                }

                // asignar instalacion
                evento.Instalacion = instalacion;

                // se crea reserva
                int idUsuario = currentUser != null ? currentUser.Id : 1;
                Usuario usuario = _db.Usuario.Where(u => u.Id == idUsuario).FirstOrDefault();

                Reserva reserva = new Reserva
                {
                    FechaReserva = DateTime.Now,
                    HoraInicio = (DateTime)eventoDTO?.FechaInicio,
                    HoraFin = (DateTime)eventoDTO.FechaFinEvento,
                    FechaCreacion = DateTime.Now,
                    UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                    Usuario = usuario,
                    Instalacion = instalacion
                };

                // crear historial y asignarlo al evento
                HistorialEvento historialEvento = new HistorialEvento
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se crea evento",
                    UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                    EstadoEvento = _eventoEstadoService.GetEventoEstadoById(1) // asigno estado creado
                };
                evento.HistorialEventoList = new List<HistorialEvento>();
                evento.HistorialEventoList.Add(historialEvento);


                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Reserva.Add(reserva);
                    _db.HistorialEvento.Add(historialEvento);
                    _db.Evento.Add(evento);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void ActualizarEvento(EventoDTO eventoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Evento evento = GetEventoById(eventoDTO.Id);

                // verificar si ya existe un evento con ese nombre
                if (eventoDTO.Titulo != null)
                {
                    bool existe = _db.Evento.Include(a => a.HistorialEventoList).Any(le => (le.Titulo == eventoDTO.Titulo && le.Id != eventoDTO.Id) && le.HistorialEventoList.Any(h => h.FechaFin == null &&
                    (h.EstadoEvento.NombreEstado != ApiNet8.Utils.Enums.EstadoEvento.Cancelado.ToString() || h.EstadoEvento.NombreEstado == ApiNet8.Utils.Enums.EstadoEvento.Finalizado.ToString())));

                    if (existe)
                    {
                        throw new Exception("Ya existe un evento con ese nombre.");
                    }
                }

                evento.Titulo = eventoDTO.Titulo ?? evento.Titulo;
                evento.Descripcion = eventoDTO.Descripcion ?? evento.Descripcion;
                evento.Banner = eventoDTO.Banner ?? evento.Banner;
                evento.CupoMaximo = eventoDTO.CupoMaximo > 0 ? eventoDTO.CupoMaximo : evento.CupoMaximo;
                evento.LinkStream = eventoDTO.LinkStream ?? evento.LinkStream;

                // asignar disciplinas
                if (eventoDTO.IdsDisciplinas != null)
                {
                    evento.Disciplinas =  new List<Disciplina>();

                    foreach (var idDisc in eventoDTO.IdsDisciplinas)
                    {
                        Disciplina? d = _disciplinasYLeccionesServices.GetDisciplinaById(idDisc);
                        if (d != null)
                        {
                            evento.Disciplinas.Add(d);
                        }
                    }
                }

                // asignar categoria
                if (eventoDTO.IdCategoria > 0)
                {
                    evento.Categoria = _categoriaServices.GetCategoriaById(eventoDTO.IdCategoria);
                }

                // asignar tipo de evento
                if (eventoDTO.IdTipoEvento > 0)
                {
                    evento.TipoEvento = _tipoEventoServices.GetTipoEventoById(eventoDTO.IdTipoEvento);
                }

                // cambia fecha o instalacion
                if (eventoDTO.IdInstalacion > 0 || eventoDTO.FechaInicio != null || eventoDTO.FechaFinEvento != null)
                {
                    // buscar instalacion
                    Instalacion instalacion = eventoDTO.IdInstalacion > 0 ? _instalacionServices.GetInstalacionById(eventoDTO.IdInstalacion) : _instalacionServices.GetInstalacionById(evento.Instalacion.Id);

                    // verificar que no este reservada
                    DateTime fechaInicioReserva = eventoDTO.FechaInicio != null ? (DateTime)eventoDTO.FechaInicio : (DateTime)evento.FechaInicio;
                    DateTime fechaFinReserva = eventoDTO.FechaFinEvento != null ? (DateTime)eventoDTO.FechaFinEvento : (DateTime)evento.FechaInicio;

                    bool instalacionDisponible = _reservasServices.VerificarInstalacionDisponible(fechaInicioReserva, fechaFinReserva, instalacion);

                    if (!instalacionDisponible)
                    {
                        throw new Exception("La instalacion no esta disponible en ese dia y horario.");
                    }

                    // se da de baja la reserva anterior
                    Reserva? reservaAnterior = _reservasServices.GetReservasByInstalacion(evento.Instalacion).Where(f=>f.HoraInicio == evento.FechaInicio && f.HoraFin == evento.FechaFinEvento).OrderByDescending(f=>f.FechaCreacion).FirstOrDefault();

                    if (reservaAnterior != null)
                    {
                        reservaAnterior.FechaBaja = DateTime.Now;
                        reservaAnterior.FechaModificacion = DateTime.Now;
                        reservaAnterior.UsuarioEditor = currentUser != null ? currentUser.Id : 0;
                        _db.Reserva.Update(reservaAnterior);
                    }

                    // asignar instalacion
                    evento.Instalacion = instalacion;
                    evento.FechaInicio = fechaInicioReserva;
                    evento.FechaFinEvento = fechaFinReserva;

                    // se crea nueva reserva
                    int idUsuario = currentUser != null ? currentUser.Id : 1;
                    Usuario usuario = _db.Usuario.Where(u => u.Id == idUsuario).FirstOrDefault();

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

                // se da de baja el historial anterior
                HistorialEvento ultimoHistorial = evento.HistorialEventoList.Where(f=>f.FechaFin==null).FirstOrDefault();
                if (ultimoHistorial != null)
                {
                    ultimoHistorial.FechaFin = DateTime.Now;
                    _db.HistorialEvento.Update(ultimoHistorial);
                }

                // crear nuevo historial y asignarlo al evento
                HistorialEvento historialEvento = new HistorialEvento
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se modifica evento",
                    UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                    EstadoEvento = _eventoEstadoService.GetEventoEstadoById(1) // asigno estado creado
                };
                evento.HistorialEventoList = evento.HistorialEventoList == null ? new List<HistorialEvento>() : evento.HistorialEventoList;
                evento.HistorialEventoList.Add(historialEvento);

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Evento.Update(evento);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void EliminarEvento(EventoDTO eventoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Evento evento = GetEventoById(eventoDTO.Id);

                if (evento == null)
                {
                    throw new Exception("No existe el evento que quieres eliminar.");
                }

                // obtener reserva y darla de baja si el evento no ha comenzado
                Reserva? reservaEvento = _reservasServices.GetReservasByInstalacion(evento.Instalacion).Where(f => f.HoraInicio == evento.FechaInicio && f.HoraFin == evento.FechaFinEvento).OrderByDescending(f => f.FechaCreacion).FirstOrDefault();
                if (reservaEvento != null && evento.FechaInicio > DateTime.Now)
                {
                    reservaEvento.FechaBaja = DateTime.Now;
                    reservaEvento.FechaModificacion = DateTime.Now;
                    reservaEvento.UsuarioEditor = currentUser != null ? currentUser.Id : 0;
                    _db.Reserva.Update(reservaEvento);
                }

                // obtener ultimo historial y darlo de baja
                HistorialEvento? ultimoHistorial = evento.HistorialEventoList?.Where(f => f.FechaFin == null).OrderByDescending(f=>f.FechaInicio).FirstOrDefault();
                if (ultimoHistorial == null)
                {
                    if (ultimoHistorial.EstadoEvento.NombreEstado == Enums.EstadoEvento.Cancelado.ToString())
                    {
                        throw new Exception("Este evento ya ha sido eliminado");
                    }

                    ultimoHistorial.FechaFin = DateTime.Now;
                    _db.HistorialEvento.Update(ultimoHistorial);
                }

                // crear nuevo historial
                HistorialEvento nuevoHistorial = new HistorialEvento
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se elimina evento",
                    UsuarioEditor = currentUser?.Id,
                    EstadoEvento = _eventoEstadoService.GetEventoEstadoById(2) // se asigna estado cancelado
                };
                evento.HistorialEventoList = evento.HistorialEventoList == null ? new List<HistorialEvento>() : evento.HistorialEventoList;
                evento.HistorialEventoList.Add(nuevoHistorial);

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.HistorialEvento.Add(nuevoHistorial);
                    _db.Evento.Update(evento);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Inscripcion> GetInscripcionesEvento(int id)
        {
            List<Inscripcion> inscripciones = _db.Inscripcion.Include(u=>u.Usuario).Include(e=>e.Evento).Where(i=>i.Evento.Id == id).ToList();
            return inscripciones;
        }

        public List<Inscripcion> GetInscripcionesByUsuario(int id)
        {
            List<Inscripcion> inscripciones = _db.Inscripcion.Include(e => e.Evento).Include(u => u.Usuario).Where(u => u.Usuario.Id == id).ToList();
            return inscripciones;
        }

        public void InscribirseAEvento(InscripcionEventoDTO inscripcion)
        {
            try
            {
                // verificar si existe evento
                Evento evento = GetEventoById(inscripcion.IdEvento);
                if (evento == null)
                {
                    throw new Exception("No existe el evento");
                }

                // verificar si hay cupo disponible
                if (evento.EventoLleno)
                {
                    throw new Exception("El evento esta completo.");
                }

                // verificar estado evento
                if (evento?.HistorialEventoList?.Where(f => f.FechaFin == null)?.OrderByDescending(f => f.FechaInicio)?.FirstOrDefault()?.EstadoEvento.NombreEstado != Enums.EstadoEvento.Creado.ToString())
                {
                    throw new Exception("Las inscripciones al evento estan cerradas: el evento esta en curso o ha finalizado.");
                }

                // verificar si ya esta inscripto
                List<Inscripcion> inscripciones = _db.Inscripcion.Include(e => e.Evento).Include(u => u.Usuario).Where(u => u.Usuario.Id == inscripcion.IdUsuario && u.Evento.Id == inscripcion.IdEvento && u.FechaBaja == null).ToList();
                if (inscripciones.Count() > 0)
                {
                    throw new Exception("El usuario ya esta inscripto para este evento.");
                }

                // verificar estado del usuario y perfil
                Usuario? usuario = _db.Usuario
                        .Include(u => u.UsuarioHistoriales).ThenInclude(a => a.UsuarioEstado)
                        .Where(u => u.Id == inscripcion.IdUsuario)
                        .FirstOrDefault();

                if (usuario == null)
                {
                    throw new Exception("No existe el usuario que se quiere inscribir");
                }

                if (usuario?.UsuarioHistoriales?.Where(h => h.FechaFin == null)?.FirstOrDefault()?.UsuarioEstado.NombreEstado != Enums.EstadoUsuario.Activo.ToString())
                {
                    throw new Exception("El usuario no esta activo");
                }

                List<PerfilUsuario> perfilesUsuario = _db.PerfilUsuario.Include(u => u.Usuario).Include(p => p.Perfil).Where(pu => pu.Usuario.Id == inscripcion.IdUsuario).ToList();
                bool tienePerfilSocio = perfilesUsuario.Any(pu => pu.Perfil.NombrePerfil == Enums.Perfiles.Socio.ToString());

                if (!tienePerfilSocio)
                {
                    throw new Exception("No puede inscribirse porque no tiene perfil de socio");
                }

                // crear instancia de inscripcion
                Inscripcion inscripcionEvento = new Inscripcion
                {
                    Evento = evento,
                    Usuario = usuario,
                    FechaInscripcion = DateTime.Now,
                };

                // verificar si el evento esta lleno
                int cantInscripciones = GetInscripcionesEvento(inscripcion.IdEvento).Count();
                if (evento.CupoMaximo == cantInscripciones + 1)
                {
                    evento.EventoLleno = true;
                    _db.Evento.Update(evento);
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Inscripcion.Add(inscripcionEvento);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DesinscribirseAEvento(InscripcionEventoDTO inscripcion)
        {
            try
            {
                // verificar estado evento
                Evento evento = GetEventoById(inscripcion.IdEvento);

                if (evento?.HistorialEventoList?.Where(f => f.FechaFin == null)?.OrderByDescending(f => f.FechaInicio)?.FirstOrDefault()?.EstadoEvento.NombreEstado != Enums.EstadoEvento.Creado.ToString())
                {
                    throw new Exception("Las inscripciones al evento estan cerradas: el evento esta en curso o ha finalizado.");
                }

                // busco la inscripcion y la doy de baja
                Inscripcion? inscripcionEvento = _db.Inscripcion.Include(e => e.Evento).Include(u => u.Usuario).FirstOrDefault();

                if (inscripcionEvento == null)
                {
                    throw new Exception("No esta inscripto a este evento");
                }

                inscripcionEvento.FechaBaja = DateTime.Now;

                // verificar si el evento estaba lleno
                if (evento.EventoLleno)
                {
                    evento.EventoLleno = false;
                    _db.Evento.Update(evento);
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Inscripcion.Add(inscripcionEvento);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           

        }
    }
}

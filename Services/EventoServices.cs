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

        public EventoServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, IDisciplinasYLeccionesServices disciplinasYLeccionesServices, ICategoriaServices categoriaServices, IInstalacionServices instalacionServices, IReservasServices reservasServices, IEventoEstadoService eventoEstadoService)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _disciplinasYLeccionesServices = disciplinasYLeccionesServices;
            _categoriaServices = categoriaServices;
            _instalacionServices = instalacionServices;
            _reservasServices = reservasServices;
            _eventoEstadoService = eventoEstadoService;
        }

        public List<Evento> GetEventos()
        {
            List<Evento> eventos = _db.Evento.Include(d=>d.Disciplinas).Include(c=>c.Categoria).Include(te=>te.TipoEvento).Include(i=>i.Instalacion).Include(he=>he.HistorialEventoList).ThenInclude(ee=>ee.EstadoEvento).ToList();
            return eventos;
        }

        public List<Evento> GetEventosActivos()
        {
            List<Evento> eventos = GetEventos();

            List<Evento> eventosActivos = eventos.Where(e=>e.HistorialEventoList
            .Any(f=>f.FechaFin == null 
            && (f.EstadoEvento.NombreEstado != Enums.EstadoEvento.Cancelado.ToString() || f.EstadoEvento.NombreEstado != Enums.EstadoEvento.Finalizado.ToString()))).ToList();

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
                .Where(e => e.HistorialEventoList.Any(f => f.FechaFin == null
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
                    Usuario = usuario
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

        //public void ActualizarLeccionEstado(LeccionEstadoDTO leccionEstadoDTO)
        //{
        //    try
        //    {
        //        // Obtener el usuario actual desde la sesión
        //        var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

        //        LeccionEstado leccionEstado = GetLeccionEstadoById(leccionEstadoDTO.Id);

        //        leccionEstado.FechaModificacion = DateTime.Now;
        //        leccionEstado.DescripcionEstado = leccionEstadoDTO.DescripcionEstado ?? leccionEstado.DescripcionEstado;
        //        leccionEstado.NombreEstado = leccionEstadoDTO.NombreEstado ?? leccionEstado.NombreEstado;
        //        leccionEstado.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

        //        if (leccionEstadoDTO.NombreEstado != null)
        //        {
        //            bool existe = _db.LeccionEstado.Any(le => le.NombreEstado == leccionEstadoDTO.NombreEstado && le.Id != leccionEstado.Id && le.FechaBaja == null);

        //            if (existe)
        //            {
        //                throw new Exception("Ya existe un estado de leccion con ese nombre.");
        //            }
        //        }

        //        using (var transaction = _db.Database.BeginTransaction())
        //        {
        //            _db.LeccionEstado.Update(leccionEstado);
        //            _db.SaveChanges();
        //            transaction.Commit();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message, e);
        //    }
        //}

        //public void EliminarLeccionEstado(LeccionEstadoDTO leccionEstadoDTO)
        //{
        //    try
        //    {
        //        // Obtener el usuario actual desde la sesión
        //        var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

        //        LeccionEstado leccionEstado = GetLeccionEstadoById(leccionEstadoDTO.Id);

        //        if (leccionEstado == null)
        //        {
        //            throw new Exception("No existe el estado que quieres eliminar.");
        //        }

        //        if (leccionEstado.FechaBaja != null)
        //        {
        //            throw new Exception("El estado de leccion ya esta eliminado.");
        //        }

        //        leccionEstado.FechaBaja = DateTime.Now;
        //        leccionEstado.FechaModificacion = DateTime.Now;
        //        leccionEstado.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

        //        using (var transaction = _db.Database.BeginTransaction())
        //        {
        //            _db.LeccionEstado.Update(leccionEstado);
        //            _db.SaveChanges();
        //            transaction.Commit();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message, e);
        //    }
        //}
    }
}

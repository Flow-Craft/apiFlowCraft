using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Reservas;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ApiNet8.Models.Usuarios;
using ApiNet8.Models.Partidos;

namespace ApiNet8.Services
{
    public class ReservasServices : IReservasServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;        
        private readonly IInstalacionServices _instalacionServices;
        private readonly IUsuarioServices _usuarioServices;

        public ReservasServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, IInstalacionServices instalacionServices, IUsuarioServices usuarioServices)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _instalacionServices = instalacionServices;
            _usuarioServices= usuarioServices;
        }

        public void ActualizarReserva(ReservaDTO reservaDTO)
        {
            try
            {
                Reserva reserva = GetReservaById((int)reservaDTO.Id);

                if (reservaDTO.HoraInicio==null){reservaDTO.HoraInicio = reserva.HoraInicio;}
                if (reservaDTO.HoraFin == null) { reservaDTO.HoraFin = reserva.HoraFin; }
                if (reservaDTO.InstalacionId == null) { reservaDTO.InstalacionId = reserva.Instalacion.Id; }

                if (VerificarInstalacionDisponibleReserva(reservaDTO))
                {
                    var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");
                    int currentUserId = currentUser != null ? currentUser.Id : 0;

                    using (var transaction = _db.Database.BeginTransaction())
                    {
                        reserva.FechaModificacion = DateTime.Now;
                        reserva.HoraInicio = (DateTime)reservaDTO.HoraInicio;
                        reserva.HoraFin = (DateTime)reservaDTO.HoraFin;
                        reserva.UsuarioEditor = reservaDTO.UsuarioId != null ? (int)reservaDTO.UsuarioId : currentUserId;
                        reserva.Instalacion = _instalacionServices.GetInstalacionById((int)reservaDTO.InstalacionId);
                        if (reservaDTO.UsuarioId != null) { reserva.Usuario = _usuarioServices.GetUsuarioById((int)reservaDTO.UsuarioId); }

                        _db.Reserva.Update(reserva);
                        _db.SaveChanges();
                        transaction.Commit();
                    }
                }
                else
                {
                    throw new Exception("No se puede editar la reserva ya que la instalacion se encuentra reservado para ese dia y horario o la instalacion se encuentra cerrada");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void CrearReserva(ReservaDTO reservaDTO)
        {
            try
            {
                if (VerificarInstalacionDisponibleReserva(reservaDTO))
                {
                    var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");
                    
                    Usuario usu = new Usuario();
                    if (reservaDTO.UsuarioId != null)
                    {
                        usu = _usuarioServices.GetUsuarioById((int)reservaDTO.UsuarioId);
                    }
                    else
                    {
                        usu = _usuarioServices.GetUsuarioById(currentUser.Id);
                    }

                    using (var transaction = _db.Database.BeginTransaction())
                    {
                        Reserva reserva = new Reserva()
                        {
                            FechaReserva = DateTime.Now,
                            FechaCreacion = DateTime.Now,
                            HoraInicio = (DateTime)reservaDTO.HoraInicio,
                            HoraFin = (DateTime)reservaDTO.HoraFin,
                            UsuarioEditor = currentUser.Id,
                            Usuario = usu,
                            Instalacion = _instalacionServices.GetInstalacionById((int)reservaDTO.InstalacionId)
                        };

                        _db.Reserva.Add(reserva);
                        _db.SaveChanges();
                        transaction.Commit();
                    }
                }
                else
                {
                    throw new Exception("No se puede crear la reserva ya que la instalacion se encuentra reservado para ese dia y horario o la instalacion se encuentra cerrada");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void EliminarReserva(int id)
        {
            try
            {
                Reserva reserva = GetReservaById(id);

                if (reserva == null)
                {
                    throw new Exception("No se encontró la reserva.");
                }

                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                using (var transaction = _db.Database.BeginTransaction())
                {
                    reserva.FechaBaja=DateTime.Now;
                    reserva.UsuarioEditor = currentUser.Id;
                    _db.Reserva.Update(reserva);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Reserva GetReservaById(int id)
        {
            try
            {
                Reserva reserva = _db.Reserva.Include(a=>a.Instalacion).Include(a => a.Usuario).Where(u => u.Id == id).FirstOrDefault();

                return reserva;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Reserva> GetReservasByUsuario(int id)
        {
            try
            {
                List<Reserva> reservas = _db.Reserva.Include(a => a.Instalacion).Include(a => a.Usuario).Where(u => u.Usuario.Id == id && u.FechaBaja==null).ToList();

                return reservas;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Reserva> GetReservas()
        {
            List<Reserva> reservas = _db.Reserva.Include(i=>i.Instalacion).Include(u=>u.Usuario).ToList();
            return reservas;
        }

        public List<Reserva> GetReservasVigentes()
        {
            List<Reserva> reservas = _db.Reserva.Include(i => i.Instalacion).Include(u => u.Usuario).Where(a=> a.FechaBaja==null).ToList();
            return reservas;
        }



        public List<Reserva> GetReservasByInstalacion(Instalacion instalacion) 
        {
            // se obtienen las reservas activas
            List<Reserva> reservas = GetReservas();
            reservas = reservas.Where(i=>i.Instalacion.Id == instalacion.Id && i.FechaBaja == null && i.HoraInicio > DateTime.Now).ToList();

            return reservas;
        }

        public List<Reserva> GetReservasByEvento(Evento evento)
        {
            // Obtener las reservas asociadas a la instalación del evento
            List<Reserva> reservasInstalacion = GetReservasByInstalacion(evento.Instalacion);

            // Filtrar las reservas que coinciden con el rango de fechas y horas del evento
            List<Reserva> reservasDelEvento = reservasInstalacion.Where(r =>
                // La reserva debe estar dentro del rango del evento
                r.HoraInicio == evento.FechaInicio && r.HoraFin == evento.FechaFinEvento
                // Verificamos que la reserva no esté dada de baja
                && r.FechaBaja == null
            ).ToList();

            return reservasDelEvento;
        }

        public List<Reserva> GetReservasByUsuarioPeriodo(int idUsuario, DateTime periodoInicio, DateTime periodoFin)
        {
            // Obtener las reservas asociadas al usuario
            List<Reserva> reservas = _db.Reserva
                .Include(i=>i.Instalacion)
                .Include(u=>u.Usuario)
                .Where(u=>u.Usuario.Id == idUsuario && u.HoraInicio <= periodoFin && u.HoraInicio >= periodoInicio && u.HoraFin >= periodoInicio && u.HoraFin <= periodoFin && u.FechaBaja == null)
                .ToList();

            return reservas;
        }

        public List<Reserva> GetReservasByInstalacionPeriodo(int idInstalacion, DateTime periodoInicio, DateTime periodoFin)
        {
            // Obtener las reservas asociadas a la instalación
            List<Reserva> reservas = _db.Reserva
                .Include(i => i.Instalacion)
                .Include(u => u.Usuario)
                .Where(u => u.Instalacion.Id == idInstalacion && u.HoraInicio <= periodoFin && u.HoraInicio >= periodoInicio && u.HoraFin >= periodoInicio && u.HoraFin <= periodoFin && u.FechaBaja == null)
                .ToList();

            return reservas;
        }

        public List<Reserva> GetReservasByPeriodo(DateTime periodoInicio, DateTime periodoFin)
        {
            // Obtener las reservas en periodo
            List<Reserva> reservas = _db.Reserva
                .Include(i => i.Instalacion)
                .Include(u => u.Usuario)
                .Where(u => u.HoraInicio <= periodoFin && u.HoraInicio >= periodoInicio && u.HoraFin >= periodoInicio && u.HoraFin <= periodoFin && u.FechaBaja == null)
                .ToList();

            return reservas;
        }

        public bool VerificarInstalacionDisponible(DateTime fechaInicio, DateTime fechaFin, Instalacion instalacion, Evento evento)
        {
            evento.Instalacion = instalacion;
            // Obtener las reservas asociadas al evento actual
            List<Reserva> reservasDelEvento = GetReservasByEvento(evento);

            // Obtener reservas de la instalación
            List<Reserva> reservasInstalacion = GetReservasByInstalacion(instalacion);

            // Verificar si hay alguna reserva que se solape con el rango [fechaInicio, fechaFin]
            bool hayConflicto = reservasInstalacion.Any(r =>
                // Ignorar las reservas asociadas al evento actual
                !reservasDelEvento.Contains(r) &&
                // Verificar solapamiento de horarios
                ((fechaInicio > r.HoraInicio && fechaInicio < r.HoraFin) ||
                (fechaFin > r.HoraInicio && fechaFin < r.HoraFin) ||
                (r.HoraInicio >= fechaInicio && r.HoraFin <= fechaFin))
                // Verificar que no esté dada de baja
                && r.FechaBaja == null
            );

            // Si hay conflicto, la instalación no está disponible
            return !hayConflicto;
        }

        public bool VerificarInstalacionDisponibleReserva(ReservaDTO reservaDTO)
        {
            Instalacion instalacion = _instalacionServices.GetInstalacionById((int)reservaDTO.InstalacionId);

            // Obtener reservas de la instalación
            List<Reserva> reservasInstalacion = GetReservasByInstalacion(instalacion);

            // Verificar si hay alguna reserva que se solape con el rango [fechaInicio, fechaFin]
            bool hayConflicto = reservasInstalacion.Any(r =>
                r.Id != reservaDTO.Id &&
                // Verificar solapamiento de horarios
                ((reservaDTO.HoraInicio > r.HoraInicio && reservaDTO.HoraInicio < r.HoraFin) ||
                (reservaDTO.HoraFin > r.HoraInicio && reservaDTO.HoraFin < r.HoraFin) ||
                (r.HoraInicio >= reservaDTO.HoraInicio && r.HoraFin <= reservaDTO.HoraFin))
                // Verificar que no esté dada de baja
                && r.FechaBaja == null
            );

            if (
                ((TimeOnly.FromDateTime((DateTime)reservaDTO.HoraInicio) < instalacion.HoraInicio && TimeOnly.FromDateTime((DateTime)reservaDTO.HoraInicio) > instalacion.HoraCierre) ||
                (TimeOnly.FromDateTime((DateTime)reservaDTO.HoraFin) < instalacion.HoraInicio && TimeOnly.FromDateTime((DateTime)reservaDTO.HoraFin) > instalacion.HoraCierre) ||
                (instalacion.HoraInicio >= TimeOnly.FromDateTime((DateTime)reservaDTO.HoraInicio) && instalacion.HoraCierre <= TimeOnly.FromDateTime((DateTime)reservaDTO.HoraFin)))
                )
            {
                hayConflicto = true;
            }
            // Si hay conflicto, la instalación no está disponible
            return !hayConflicto;
        }

    }
}

using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Reservas;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using XAct.Events;
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

        //public void ActualizarInstalacion(InstalacionDTO instalacionDTO)
        //{
        //    try
        //    {
        //        Instalacion inst;
        //        var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

        //        using (var transaction = _db.Database.BeginTransaction())
        //        {

        //            inst = GetInstalacionById((int)instalacionDTO.Id);

        //            inst.Nombre = instalacionDTO.Nombre ?? inst.Nombre;
        //            inst.Ubicacion = instalacionDTO.Ubicacion ?? inst.Ubicacion;
        //            inst.Precio = instalacionDTO.Precio ?? inst.Precio;
        //            inst.Condiciones = instalacionDTO.Condiciones ?? inst.Condiciones;
        //            inst.HoraInicio = instalacionDTO.HoraInicio ?? inst.HoraInicio;
        //            inst.HoraCierre = instalacionDTO.HoraCierre ?? inst.HoraCierre;

        //            // obtengo ultimo historial y lo doy de baja
        //            InstalacionHistorial? ultimoHistorial = inst.instalacionHistoriales.Where(ih => ih.FechaFin == null).FirstOrDefault();

        //            if (ultimoHistorial != null)
        //            {
        //                ultimoHistorial.FechaFin = DateTime.Now;
        //                _db.InstalacionHistorial.Update(ultimoHistorial);
        //            }
        //            else
        //            {
        //                inst.instalacionHistoriales = new List<InstalacionHistorial>();
        //            }

        //            // creo nuevo historial y lo asigno
        //            InstalacionHistorial nuevoHistorial = new InstalacionHistorial
        //            {
        //                FechaInicio = DateTime.Now,
        //                DetalleCambioEstado = "Se actualiza instalacion",
        //                UsuarioEditor = currentUser?.Id,
        //                InstalacionEstado = _instalacionEstadoServices.GetInstalacionEstadoById(instalacionDTO.EstadoId) // asigno estado ACTIVO
        //            };

        //            inst.instalacionHistoriales.Add(nuevoHistorial);

        //            _db.InstalacionHistorial.Add(nuevoHistorial);
        //            _db.Instalacion.Update(inst);
        //            _db.SaveChanges();
        //            transaction.Commit();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message, e);
        //    }
        //}

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
                            HoraInicio = reservaDTO.HoraInicio,
                            HoraFin = reservaDTO.HoraFin,
                            UsuarioEditor = currentUser.Id,
                            Usuario = usu,
                            Instalacion = _instalacionServices.GetInstalacionById(reservaDTO.InstalacionId)
                        };

                        _db.Reserva.Add(reserva);
                        _db.SaveChanges();
                        transaction.Commit();
                    }
                }
                else
                {
                    throw new Exception("No se puede crear la reserva ya que la instalacion se encuentra reservado para ese dia y horario");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        //public void EliminarInstalacion(int id)
        //{
        //    try
        //    {
        //        Instalacion instalacionAEliminar = GetInstalacionById(id);

        //        if (instalacionAEliminar == null)
        //        {
        //            throw new Exception("No se encontró la instalación.");
        //        }

        //        var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

        //        using (var transaction = _db.Database.BeginTransaction())
        //        {
        //            // obtengo ultimo historial y lo doy de baja
        //            InstalacionHistorial? ultimoHistorial = instalacionAEliminar.instalacionHistoriales.Where(ih => ih.FechaFin == null).FirstOrDefault();

        //            if (ultimoHistorial != null)
        //            {
        //                ultimoHistorial.FechaFin = DateTime.Now;
        //                _db.InstalacionHistorial.Update(ultimoHistorial);
        //            }
        //            else
        //            {
        //                instalacionAEliminar.instalacionHistoriales = new List<InstalacionHistorial>();
        //            }

        //            InstalacionHistorial nuevoHistorial = new InstalacionHistorial
        //            {
        //                DetalleCambioEstado = "Se elimina instalacion",
        //                FechaInicio = DateTime.Now,
        //                UsuarioEditor = currentUser?.Id,
        //                InstalacionEstado = _instalacionEstadoServices.GetInstalacionEstadoById(2) // asigno estado DESACTIVADO
        //            };

        //            instalacionAEliminar.instalacionHistoriales.Add(nuevoHistorial);

        //            _db.InstalacionHistorial.Add(nuevoHistorial);
        //            _db.Instalacion.Update(instalacionAEliminar);
        //            _db.SaveChanges();
        //            transaction.Commit();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message, e);
        //    }
        //}

        public List<Reserva> GetReservas()
        {
            List<Reserva> reservas = _db.Reserva.Include(i=>i.Instalacion).Include(u=>u.Usuario).ToList();
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

            // Obtener reservas de la instalación
            List<Reserva> reservasInstalacion = GetReservasByInstalacion(_instalacionServices.GetInstalacionById(reservaDTO.InstalacionId));

            // Verificar si hay alguna reserva que se solape con el rango [fechaInicio, fechaFin]
            bool hayConflicto = reservasInstalacion.Any(r =>
                // Verificar solapamiento de horarios
                ((reservaDTO.HoraInicio > r.HoraInicio && reservaDTO.HoraInicio < r.HoraFin) ||
                (reservaDTO.HoraFin > r.HoraInicio && reservaDTO.HoraFin < r.HoraFin) ||
                (r.HoraInicio >= reservaDTO.HoraInicio && r.HoraFin <= reservaDTO.HoraFin))
                // Verificar que no esté dada de baja
                && r.FechaBaja == null
            );

            // Si hay conflicto, la instalación no está disponible
            return !hayConflicto;
        }

    }
}

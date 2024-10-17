using ApiNet8.Data;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Reservas;
using ApiNet8.Services.IServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using XAct.Events;

namespace ApiNet8.Services
{
    public class ReservasServices : IReservasServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;        
        private readonly IInstalacionServices _instalacionServices;

        public ReservasServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, IInstalacionServices instalacionServices)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _instalacionServices = instalacionServices;
        }

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
    }
}

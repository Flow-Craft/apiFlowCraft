using ApiNet8.Data;
using ApiNet8.Models.Reservas;
using ApiNet8.Services.IServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

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
            reservas.Where(i=>i.Instalacion.Id == instalacion.Id && i.FechaBaja == null && i.HoraInicio > DateTime.Now).ToList();

            return reservas;
        }

        public bool VerificarInstalacionDisponible(DateTime fechaInicio, DateTime fechaFin, Instalacion instalacion)
        {
            // buscar reservas de una instalacion
            List<Reserva> reservasInstalacion = GetReservasByInstalacion(instalacion);

            // Verificar si hay alguna reserva que se solape con el rango [fechaInicio, fechaFin]
            bool hayConflicto = reservasInstalacion.Any(r =>
                // La fechaInicio cae en un rango reservado (excepto si es exactamente al final de una reserva)
                ((fechaInicio > r.HoraInicio && fechaInicio < r.HoraFin) ||
                // La fechaFin cae en un rango reservado (excepto si es exactamente al inicio de una reserva)
                (fechaFin > r.HoraInicio && fechaFin < r.HoraFin) ||
                // La reserva existente está completamente dentro del nuevo rango
                (r.HoraInicio >= fechaInicio && r.HoraFin <= fechaFin))
                // Condición: Fecha de baja es null
                && r.FechaBaja == null
            );

            // Si hay conflicto, la instalación no está disponible
            return !hayConflicto;
        }
    }
}

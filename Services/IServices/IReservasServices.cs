using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Reservas;

namespace ApiNet8.Services.IServices
{
    public interface IReservasServices
    {
        public bool VerificarInstalacionDisponible(DateTime fechaInicio, DateTime fechaFin, Instalacion instalacion, Evento evento);
        List<Reserva> GetReservasByInstalacion(Instalacion instalacion);
        List<Reserva> GetReservas();
        void CrearReserva(ReservaDTO reservaDTO);
        public List<Reserva> GetReservasByEvento(Evento evento);
        List<Reserva> GetReservasByUsuarioPeriodo(int idUsuario, DateTime periodoInicio, DateTime periodoFin);
        List<Reserva> GetReservasByInstalacionPeriodo(int idInstalacion, DateTime periodoInicio, DateTime periodoFin);
        List<Reserva> GetReservasByPeriodo(DateTime periodoInicio, DateTime periodoFin);
    }
}

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
        List<Reserva> GetReservasVigentes();
        void CrearReserva(ReservaDTO reservaDTO);
        void ActualizarReserva(ReservaDTO reservaDTO);
        void EliminarReserva(int id);
        Reserva GetReservaById(int id);
        List<Reserva> GetReservasByUsuario(int id);
        public List<Reserva> GetReservasByEvento(Evento evento);
    }
}

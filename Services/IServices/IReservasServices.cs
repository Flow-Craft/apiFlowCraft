using ApiNet8.Models.Reservas;

namespace ApiNet8.Services.IServices
{
    public interface IReservasServices
    {
        bool VerificarInstalacionDisponible (DateTime fechaInicio, DateTime fechaFin, Instalacion instalacion);
        List<Reserva> GetReservasByInstalacion(Instalacion instalacion);
        List<Reserva> GetReservas();
    }
}

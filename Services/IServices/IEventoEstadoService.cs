using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models;

namespace ApiNet8.Services.IServices
{
    public interface IEventoEstadoService
    {
        List<EstadoEvento> GetEventoEstados();
        EstadoEvento GetEventoEstadoById(int Id);
        EstadoEvento CrearEventoEstado(EstadoEventoDTO eventoEstadoDTO, JwtToken currentUserJwt);
        EstadoEvento ActualizarEventoEstado(EstadoEventoDTO eventoEstadoDTO, JwtToken currentUserJwt);
        EstadoEvento EliminarEventoEstado(int id, JwtToken currentUserJwt);
        bool ExisteEventoEstado(string nombre);
    }
}

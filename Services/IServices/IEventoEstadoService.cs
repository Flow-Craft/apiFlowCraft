using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models;

namespace ApiNet8.Services.IServices
{
    public interface IEventoEstadoService
    {
        List<EstadoEvento> GetEventoEstados();
        EstadoEvento GetEventoEstadoById(int Id);
        EstadoEvento CrearEventoEstado(EstadoEventoDTO eventoEstadoDTO);
        EstadoEvento ActualizarEventoEstado(EstadoEventoDTO eventoEstadoDTO);
        EstadoEvento EliminarEventoEstado(int id);
        bool ExisteEventoEstado(string nombre);
    }
}

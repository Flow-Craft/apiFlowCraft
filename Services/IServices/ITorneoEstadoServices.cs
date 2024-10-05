using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Torneos;

namespace ApiNet8.Services.IServices
{
    public interface ITorneoEstadoServices
    {
        List<TorneoEstado> GetTorneoEstados();
        TorneoEstado GetTorneoEstadoById(int Id);
        void CrearTorneoEstado(TorneoEstadoDTO torneoEstadoDTO);
        void ActualizarTorneoEstado(TorneoEstadoDTO torneoEstadoDTO);
        void EliminarTorneoEstado(TorneoEstadoDTO torneoEstadoDTO);
        bool ExisteTorneoEstado(string nombre);
        List<TorneoEstado> GetTorneoEstadosActivos();
    }
}

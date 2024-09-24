using ApiNet8.Models.DTO;
using ApiNet8.Models.Partidos;

namespace ApiNet8.Services.IServices
{
    public interface ITipoAccionPartidoServices
    {
        List<TipoAccionPartido> GetTiposAccionPartido();
        TipoAccionPartido GetTipoAccionPartidoById(int Id);
        void CrearTipoAccionPartido(TipoAccionPartidoDTO tipoAccionPartidoDTO);
        void ActualizarTipoAccionPartido(TipoAccionPartidoDTO tipoAccionPartidoDTO);
        void EliminarTipoAccionPartido(TipoAccionPartidoDTO tipoAccionPartidoDTO);
        bool ExisteTipoAccionPartido(string nombre);
        List<TipoAccionPartido> GetTiposAccionPartidoActivos();
    }
}

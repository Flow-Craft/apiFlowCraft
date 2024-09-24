using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Torneos;

namespace ApiNet8.Services.IServices
{
    public interface ITipoEventoServices
    {
        List<TipoEvento> GetTiposEvento();
        TipoEvento GetTipoEventoById(int Id);
        void CrearTipoEvento(TipoEventoDTO tipoEventoDTO);
        void ActualizarTipoEvento(TipoEventoDTO tipoEventoDTO);
        void EliminarTipoEvento(TipoEventoDTO tipoEventoDTO);
        bool ExisteTipoEvento(string nombre);
        List<TipoEvento> GetTiposEventoActivos();
    }
}

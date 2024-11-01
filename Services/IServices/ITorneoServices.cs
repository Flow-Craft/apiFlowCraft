using ApiNet8.Models.DTO;

namespace ApiNet8.Services.IServices
{
    public interface ITorneoServices
    {
        void CrearTorneo(TorneoDTO torneoDTO);
        void EditarTorneo(TorneoDTO torneoDTO);
        void EliminarTorneo(int idTorneo);
    }
}

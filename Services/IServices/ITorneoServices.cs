using ApiNet8.Models.DTO;
using ApiNet8.Models.Torneos;

namespace ApiNet8.Services.IServices
{
    public interface ITorneoServices
    {
        void CrearTorneo(TorneoDTO torneoDTO);
        void EditarTorneo(TorneoDTO torneoDTO);
        void EliminarTorneo(int idTorneo);
        Torneo? GetTorneoById(int idTorneo);
        List<Torneo> GetTorneos();
        void InscribirseATorneo(int idTorneo, int idEquipo);
        void DesinscribirseATorneo(int idTorneo, int idEquipo);
        List<TorneoResponseDTO> GetTorneosCompleto();
        TorneoResponseDTO? GetTorneoByIdCompleto(int idTorneo);
    }
}

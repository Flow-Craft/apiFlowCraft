using ApiNet8.Models.DTO;
using ApiNet8.Models.Reservas;
using ApiNet8.Models;

namespace ApiNet8.Services.IServices
{
    public interface IInstalacionServices
    {
        List<InstalacionResponseDTO> GetInstalaciones();
        List<Instalacion> GetInstalacionesActivas();
        Instalacion GetInstalacionById(int Id);
        void CrearInstalacion(InstalacionDTO instalacionDTO);
        void ActualizarInstalacion(InstalacionDTO instalacionDTO);
        void EliminarInstalacion(int id);
        bool ExisteInstalacion(string nombre);
    }
}

using ApiNet8.Models.DTO;
using ApiNet8.Models;
using ApiNet8.Models.Reservas;

namespace ApiNet8.Services.IServices
{
    public interface IInstalacionEstadoServices
    {
        List<InstalacionEstado> GetInstalacionEstados();
        InstalacionEstado GetInstalacionEstadoById(int Id);
        InstalacionEstado CrearInstalacionEstado(InstalacionEstadoDTO instalacionEstadoDTO);
        InstalacionEstado ActualizarInstalacionEstado(InstalacionEstadoDTO instalacionEstadoDTO);
        InstalacionEstado EliminarInstalacionEstado(int id);
        bool ExisteInstalacionEstado(string nombre);
    }
}

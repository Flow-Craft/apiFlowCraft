using ApiNet8.Models.DTO;
using ApiNet8.Models.Reservas;
using ApiNet8.Models;

namespace ApiNet8.Services.IServices
{
    public interface IInstalacionServices
    {
        List<Instalacion> GetInstalaciones();
        List<Instalacion> GetInstalacionesActivas();
        Instalacion GetInstalacionById(int Id);
        Instalacion CrearInstalacion(InstalacionDTO instalacionDTO);
        Instalacion ActualizarInstalacion(InstalacionDTO instalacionDTO);
        Instalacion EliminarInstalacion(int id);
        bool ExisteInstalacion(string nombre);
    }
}

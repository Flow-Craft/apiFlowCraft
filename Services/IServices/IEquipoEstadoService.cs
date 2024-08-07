using ApiNet8.Models;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Partidos;

namespace ApiNet8.Services.IServices
{
    public interface IEquipoEstadoService
    {
        List<EquipoEstado> GetEquipoEstados();
        EquipoEstado GetEquipoEstadoById(int Id);
        EquipoEstado CrearEquipoEstado(EquipoEstadoDTO equipoEstadoDTO);
        EquipoEstado ActualizarEquipoEstado(EquipoEstadoDTO equipoEstadoDTO);
        EquipoEstado EliminarEquipoEstado(int id, JwtToken currentUserJwt);
        bool ExisteEquipoEstado(string nombre);
    }
}

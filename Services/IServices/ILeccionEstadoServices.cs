using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Services.IServices
{
    public interface ILeccionEstadoServices
    {
        List<LeccionEstado> GetLeccionEstados();
        LeccionEstado GetLeccionEstadoById(int Id);
        void CrearLeccionEstado(LeccionEstadoDTO leccionEstado);
        void ActualizarLeccionEstado(LeccionEstadoDTO leccionEstado);
        void EliminarLeccionEstado(LeccionEstadoDTO leccionEstadoDTO);
        bool ExisteLeccionEstado(string nombre);
        List<LeccionEstado> GetLeccionEstadosActivos();
    }
}

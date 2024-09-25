using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;

namespace ApiNet8.Services.IServices
{
    public interface ILeccionesServices
    {
        List<Leccion> GetLecciones();
        Leccion GetLeccionById(int Id);
        void CrearLeccion(LeccionDTO leccionDTO);
        void ActualizarLeccion(LeccionDTO leccionDTO);
        void EliminarLeccion(LeccionDTO leccionDTO);
        bool ExisteLeccion(string nombre);
        List<Leccion> GetLeccionesActivas();
    }
}

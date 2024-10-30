using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;

namespace ApiNet8.Services.IServices
{
    public interface ILeccionesServices
    {
        List<Leccion> GetLecciones();
        Leccion GetLeccionById(int Id);
        List<Leccion> GetLeccionesAsignadas();
        void CrearLeccion(LeccionDTO leccionDTO);
        void ActualizarLeccion(LeccionDTO leccionDTO);
        void EliminarLeccion(LeccionDTO leccionDTO);
        bool ExisteLeccion(string nombre);
        List<Leccion> GetLeccionesActivas();
        List<InscripcionUsuario> GetInscripcionesALecciones(int id);
        List<InscripcionUsuario> GetInscripcionesLeccionVigentes(int id);
        List<InscripcionUsuario> GetInscripcionesByUsuario(int id);
        List<InscripcionUsuario> GetInscripcionesByUsuarioActivas(int id);
        void InscribirseALeccion(InscripcionLeccionDTO inscripcion);
        void DesinscribirseALeccion(InscripcionLeccionDTO inscripcion);
        void IniciarLeccion(AsistenciaLeccionDTO asistencias);
        void FinalizarLeccion(int id);
    }
}

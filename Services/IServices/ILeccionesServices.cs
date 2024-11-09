using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Partidos;

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
        List<InscripcionUsuario> GetInscripcionesByUsuario();
        List<InscripcionUsuario> GetInscripcionesByUsuarioActivas();
        void InscribirseALeccion(InscripcionLeccionDTO inscripcion);
        void DesinscribirseALeccion(InscripcionLeccionDTO inscripcion);
        void IniciarLeccion(AsistenciaLeccionDTO asistencias);
        void FinalizarLeccion(int id);
        List<LeccionResponseDTO> GetLeccionesCompletas();
        List<AsistenciaLeccion> GetAsistenciaLeccionById(int idLeccion);
        List<Estadisticas> GetEstadisticasByLeccionUsuario(int idLeccion, int idUsuario);
        List<ReporteLeccionDTO> GetAsistenciasByUsuarioAndPeriodo(int idUsuario, DateTime periodoInicio, DateTime periodoFin);
        List<ReporteLeccionDTO> GetAsistenciasByDisciplinaCategoriaAndPeriodo(int idDisciplina, int idCategoria, DateTime periodoInicio, DateTime periodoFin);
    }
}

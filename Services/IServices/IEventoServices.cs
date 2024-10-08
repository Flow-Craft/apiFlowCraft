using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Lecciones;

namespace ApiNet8.Services.IServices
{
    public interface IEventoServices
    {
        List<EventoResponseDTO> GetEventos();
        Evento GetEventoById(int Id);
        void CrearEvento(EventoDTO eventoDTO);
        void ActualizarEvento(EventoDTO eventoDTO);
        void EliminarEvento(EventoDTO eventoDTO);
        bool ExisteEvento(string nombre);
        List<Evento> GetEventosActivos();
        List<Inscripcion> GetInscripcionesEvento(int id);
        void InscribirseAEvento(InscripcionEventoDTO inscripcion);
        void DesinscribirseAEvento(InscripcionEventoDTO inscripcion);
        List<Inscripcion> GetInscripcionesByUsuario(int id);
        public List<Inscripcion> GetInscripcionesEventoVigentes(int id);
        List<Inscripcion> GetInscripcionesByUsuarioActivas(int id);
        Inscripcion? GetInscripcionByUsuarioEvento(InscripcionEventoDTO inscripcion);
        Asistencia? GetAsistenciaByUsuarioEvento(InscripcionEventoDTO inscripcion);
        void TomarAsistencia(InscripcionEventoDTO inscripcion);
        EventoByUsuarioDTO GetEventoByIdByUsuario(int idEvento);
        Inscripcion? GetInscripcionesByUsuarioByEvento(int idEvento, int IdUsuario);
        void InscribirseAEventoByUsuario(int IdEvento);
        void DesinscribirseAEventoByUsuario(int IdEvento);
    }
}

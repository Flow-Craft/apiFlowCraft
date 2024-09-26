using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Lecciones;

namespace ApiNet8.Services.IServices
{
    public interface IEventoServices
    {
        List<Evento> GetEventos();
        Evento GetEventoById(int Id);
        void CrearEvento(EventoDTO eventoDTO);
        //void ActualizarEvento(EventoDTO eventoDTO);
        //void EliminarEvento(EventoDTO eventoDTO);
        bool ExisteEvento(string nombre);
        List<Evento> GetEventosActivos();
    }
}

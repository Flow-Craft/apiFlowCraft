using ApiNet8.Models.Eventos;

namespace ApiNet8.Models.DTO
{
    public class EventoByUsuarioDTO
    {
        public Evento Evento { get; set; }
        public bool Inscripto { get; set; }
    }
}

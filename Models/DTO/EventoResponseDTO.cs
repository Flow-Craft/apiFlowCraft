using ApiNet8.Models.Eventos;

namespace ApiNet8.Models.DTO
{
    public class EventoResponseDTO
    {
        public Evento Evento { get; set; }
        public bool Activo { get; set; }
    }
}

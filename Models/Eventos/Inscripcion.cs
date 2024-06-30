using ApiNet8.Models.Usuarios;

namespace ApiNet8.Models.Eventos
{
    public class Inscripcion
    {
        public int IdInscripcion { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public DateTime FechaBaja {  get; set; }

        // Relaciones
        public Evento Evento { get; set; }
        public Usuario Usuario { get; set; }
    }
}

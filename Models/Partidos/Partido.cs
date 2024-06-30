using ApiNet8.Models.Eventos;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Models.Partidos
{
    public class Partido : Evento
    {
        public int IdPartido { get; set; }
        public string? Resultado { get; set; }
        public int? Periodo { get; set; }
        public string? Set { get; set; }
        public DateTime? FechaFin { get; set; }

        // Relaciones
        public EquipoPartido? Ganador { get; set; }
        public EquipoPartido? Local { get; set; }
        public EquipoPartido? Visitante { get; set; }
        public List<Usuario>? Usuarios { get; set; }
    }
}

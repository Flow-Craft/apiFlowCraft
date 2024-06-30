namespace ApiNet8.Models.Partidos
{
    public class EquipoPartido
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public List<string> JugadoresEnCancha { get; set; }
        public List<string> JugadoresEnBanca { get; set; }

        // Relaciones
        public Equipo Equipo { get; set; }
    }
}

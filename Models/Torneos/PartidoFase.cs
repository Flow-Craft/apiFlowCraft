using ApiNet8.Models.Partidos;

namespace ApiNet8.Models.Torneos
{
    public class PartidoFase
    {
        public int Id { get; set; }
        public int FasePartido { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }

        // Relaciones
        public IList<PartidoFase>? Llave { get; set; }
        public Torneo Torneo { get; set; }
        public IList<Partido> Partidos { get; set; }
    }
}

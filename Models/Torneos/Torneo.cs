using ApiNet8.Models.Lecciones;

namespace ApiNet8.Models.Torneos
{
    public class Torneo
    {
        public int IdTorneo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CantEquipos { get; set; }
        public byte[] Banner { get; set; }
        public string Condiciones { get; set; }
        public DateTime FechaInicio { get; set; }

        // Relaciones
        public Disciplina Disciplina { get; set; }
        public Categoria Categoria { get; set; }
        public List<TorneoHistorial> TorneoHistoriales { get; set; }
    }
}

using ApiNet8.Models.Lecciones;

namespace ApiNet8.Models.Partidos
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Local {  get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }

        // Relaciones
        public List<EquipoUsuario> EquipoUsuarios { get; set; }
        public List<EquipoHistorial> EquipoHistoriales { get; set; }
        public Disciplina Disciplina { get; set; }
        public Categoria Categoria { get; set; }
    }
}

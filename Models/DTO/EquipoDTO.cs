using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Partidos;

namespace ApiNet8.Models.DTO
{
    public class EquipoDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public bool Local { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int IdDisciplina { get; set; }
        public int IdCategoria { get; set; }
        public List<int> idsUsuarios { get; set; }
        
        //public IList<EquipoUsuario> EquipoUsuarios { get; set; }
        //public IList<EquipoHistorial> EquipoHistoriales { get; set; }
        
    }
}

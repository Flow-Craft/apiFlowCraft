using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Partidos;

namespace ApiNet8.Models.DTO
{
    public class EquipoResponseDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Local { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public Disciplina Disciplina { get; set; }
        public Categoria Categoria { get; set; }
        public List<JugadoresDTO> Jugadores { get; set; }     
        public string? Estado {  get; set; }
    }
}

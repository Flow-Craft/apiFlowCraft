using ApiNet8.Models.Usuarios;

namespace ApiNet8.Models.Partidos
{
    public class EquipoUsuario
    {
        public int Id { get; set; }
        public int NumCamiseta { get; set; }
        public string Puesto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }

        // Relaciones
        public Usuario Usuario { get; set; }
    }
}

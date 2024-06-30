using ApiNet8.Models.Usuarios;

namespace ApiNet8.Models.Lecciones
{
    public class InscripcionUsuario
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? Observacion { get; set; }

        // Relaciones
        public Usuario Usuario { get; set; }
        public Leccion Leccion { get; set; }
    }
}

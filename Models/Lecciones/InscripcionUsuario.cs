using ApiNet8.Models.Usuarios;
using Microsoft.EntityFrameworkCore;

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
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Usuario Usuario { get; set; }

        public Leccion Leccion { get; set; }
    }
}

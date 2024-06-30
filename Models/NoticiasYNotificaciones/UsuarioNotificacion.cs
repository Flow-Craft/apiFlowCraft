using ApiNet8.Models.Usuarios;

namespace ApiNet8.Models.NoticiasYNotificaciones
{
    public class UsuarioNotificacion
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaBaja { get; set; }

        // Relaciones
        public Usuario Usuario { get; set; }
        public Notificacion Notificacion { get; set; }
    }
}

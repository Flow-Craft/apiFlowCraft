namespace ApiNet8.Models.NoticiasYNotificaciones
{
    public class UsuarioNotificacion
    {
        public int IdUsuarioNotificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaBaja { get; set; }        
    }
}

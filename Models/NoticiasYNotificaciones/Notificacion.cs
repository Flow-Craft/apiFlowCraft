namespace ApiNet8.Models.NoticiasYNotificaciones
{
    public class Notificacion
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Adjunto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime FechaEnvio { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public int UsuarioEditor {  get; set; }
    }
}

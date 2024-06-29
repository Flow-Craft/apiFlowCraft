namespace ApiNet8.Models.Usuario
{
    public class UsuarioEstado
    {
        public int IdUsuarioEstado { get; set; }
        public string DescripcionEstado { get; set; }
        public string NombreEstado { get; set; } // Activo, Bloqueado, Desactivado
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor {  get; set; }
    }
}

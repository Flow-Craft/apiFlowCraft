namespace ApiNet8.Models.Lecciones
{
    public class LeccionEstado
    {
        public int Id { get; set; }
        public string DescripcionEstado { get; set; }
        public string NombreEstado { get; set; } // Vigente, ClaseIniciada, Terminada, Eliminada
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

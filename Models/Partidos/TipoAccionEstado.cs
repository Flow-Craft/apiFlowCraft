namespace ApiNet8.Models.Partidos
{
    public class TipoAccionEstado
    {
        public int Id { get; set; }
        public string DescripcionEstado { get; set; }
        public string NombreEstado { get; set; } // Activo, Inactivo
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

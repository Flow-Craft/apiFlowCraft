namespace ApiNet8.Models.Reservas
{
    public class InstalacionEstado
    {
        public int IdInstalacionEstado { get; set; }
        public string DescripcionEstado { get; set; }
        public string NombreEstado { get; set; } // Activo, Inactivo, Abierta, CerradaReparacion, CerradaRemodelacion
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

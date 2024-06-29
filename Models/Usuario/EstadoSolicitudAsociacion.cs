namespace ApiNet8.Models.Usuario
{
    public class EstadoSolicitudAsociacion
    {
        public string IdEstadoSolicitudAsociacion { get; set; }
        public string DescripcionEstado { get; set; }
        public string NombreEstado { get; set; } // Pendiente, Aprobada, Rechazada
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

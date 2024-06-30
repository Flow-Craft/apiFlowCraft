namespace ApiNet8.Models.Usuarios
{
    public class SolicitudAsociacionHistorial
    {
        public int IdSolicitudAsociacionHistorial { get; set; }
        public string? DetalleCambioEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? UsuarioEditor { get; set; }

        // Relaciones
        public EstadoSolicitudAsociacion EstadoSolicitudAsociacion { get; set; }
    }
}

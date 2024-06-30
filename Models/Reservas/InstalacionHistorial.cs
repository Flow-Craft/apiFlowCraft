namespace ApiNet8.Models.Reservas
{
    public class InstalacionHistorial
    {
        public int IdInstalacionHistorial { get; set; }
        public string? DetalleCambioEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? UsuarioEditor { get; set; }

        // Relaciones
        public InstalacionEstado InstalacionEstado { get; set; }
    }
}

namespace ApiNet8.Models.Eventos
{
    public class HistorialEvento
    {
        public int Id { get; set; }
        public string? DetalleCambioEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? UsuarioEditor { get; set; }

        // Relaciones
        public EstadoEvento EstadoEvento { get; set; }
    }
}

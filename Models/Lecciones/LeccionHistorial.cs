namespace ApiNet8.Models.Lecciones
{
    public class LeccionHistorial
    {
        public int IdLeccionHistorial { get; set; }
        public string? DetalleCambioEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? UsuarioEditor { get; set; }

        // Relaciones
        public LeccionEstado LeccionEstado { get; set; }
    }
}

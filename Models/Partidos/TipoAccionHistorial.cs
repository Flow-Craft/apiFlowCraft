namespace ApiNet8.Models.Partidos
{
    public class TipoAccionHistorial
    {
        public int Id { get; set; }
        public string? DetalleCambioEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? UsuarioEditor { get; set; }

        // Relaciones
        public TipoAccionEstado TipoAccionEstado { get; set;}
    }
}

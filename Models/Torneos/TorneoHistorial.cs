namespace ApiNet8.Models.Torneos
{
    public class TorneoHistorial
    {
        public int Id { get; set; }
        public string? DetalleCambioEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? UsuarioEditor { get; set; }

        public TorneoEstado TorneoEstado { get; set; }
    }
}

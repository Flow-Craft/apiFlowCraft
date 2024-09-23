namespace ApiNet8.Models.DTO
{
    public class TorneoEstadoDTO
    {
        public int Id { get; set; }
        public string? DescripcionEstado { get; set; }
        public string? NombreEstado { get; set; } // Abierto, Finalizado, En curso, Completado, Cancelado    
    }
}

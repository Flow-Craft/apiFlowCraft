namespace ApiNet8.Models.Torneos
{
    public class TorneoEstado
    {
        public int Id { get; set; }
        public string DescripcionEstado { get; set; }
        public string NombreEstado { get; set; } // Abierto, Finalizado, En curso, Completado, Cancelado
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

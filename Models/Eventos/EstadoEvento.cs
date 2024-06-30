namespace ApiNet8.Models.Eventos
{
    public class EstadoEvento
    {
        public int IdEstadoEvento { get; set; }
        public string DescripcionEstado { get; set; }
        public string NombreEstado { get; set; } // Creado, Cancelado, Finalizado, Iniciado, Suspendido, Entretiempo
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

namespace ApiNet8.Models.Usuarios
{
    public class SolicitudAsociacion
    {
        public int Id { get; set; }
        public string? MotivoRechazo { get; set; }

        // Relaciones
        public Usuario Usuario { get; set; }
        public List<SolicitudAsociacionHistorial> SolicitudAsociacionHistoriales { get; set; }
    }
}

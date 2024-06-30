namespace ApiNet8.Models.Usuarios
{
    public class UsuarioHistorial
    {
        public int IdUsuarioHistorial { get; set; }
        public string? DetalleCambioEstado {  get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin {  get; set; }
        public int? UsuarioEditor {  get; set; }

        // Relaciones
        public UsuarioEstado UsuarioEstado { get; set; }
    }
}

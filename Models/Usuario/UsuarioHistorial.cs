namespace ApiNet8.Models.Usuario
{
    public class UsuarioHistorial
    {
        public int IdUsuarioHistorial { get; set; }
        public string? DetalleCambioEstado {  get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin {  get; set; }
        public int? UsuarioEditor {  get; set; }

    }
}

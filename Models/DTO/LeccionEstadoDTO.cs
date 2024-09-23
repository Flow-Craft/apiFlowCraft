namespace ApiNet8.Models.DTO
{
    public class LeccionEstadoDTO
    {
        public int Id { get; set; }
        public string? DescripcionEstado { get; set; }
        public string? NombreEstado { get; set; } // Vigente, ClaseIniciada, Terminada, Eliminada       
        public int UsuarioEditor { get; set; }
    }
}

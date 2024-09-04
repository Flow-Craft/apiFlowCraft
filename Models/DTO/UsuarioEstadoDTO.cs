using System.ComponentModel.DataAnnotations;

namespace ApiNet8.Models.DTO
{
    public class UsuarioEstadoDTO
    {
        public int Id { get; set; }
        public string? NombreEstado { get; set; } // Simpatizante, Socio, Administrativo, Admin, Arbitro, Planillero, Profesor
        public string? DescripcionEstado { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

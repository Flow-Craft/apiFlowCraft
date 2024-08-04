using System.ComponentModel.DataAnnotations;

namespace ApiNet8.Models.DTO
{
    public class UsuarioEstadoDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del estado es obligatorio")]
        public string NombreEstado { get; set; } // Simpatizante, Socio, Administrativo, Admin, Arbitro, Planillero, Profesor
        [Required(ErrorMessage = "La descripcion del estado es obligatorio")]
        public string DescripcionEstado { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

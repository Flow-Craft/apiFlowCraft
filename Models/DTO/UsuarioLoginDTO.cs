using System.ComponentModel.DataAnnotations;

namespace ApiNet8.Models.DTO
{
    public class UsuarioLoginDTO
    {
        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "La contrasena es obligatoria")]
        public string Contrasena { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ApiNet8.Models.DTO
{
    public class UsuarioRegistroDTO
    {
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get; set; }
        public int? CodPostal { get; set; }
        [Required(ErrorMessage = "La contrasena es obligatoria")]
        public string Contrasena { get; set; }
        public string? DeporteFavorito { get; set; }
        [Required(ErrorMessage = "La direccion es obligatoria")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public int Telefono { get; set; }
        [Required(ErrorMessage = "El dni es obligatorio")]
        public int Dni { get; set; }
        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es obligatorio")]
        public DateTime FechaNacimiento { get; set; }
        public byte[]? FotoPerfil { get; set; }
        public string? ImageType { get; set; } // Para almacenar el tipo de la imagen (image/jpeg, image/png)
        public string? Pais { get; set; }
        public string? Provincia { get; set; }
        public string? Localidad { get; set; }
    }
}

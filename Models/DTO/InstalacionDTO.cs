using System.ComponentModel.DataAnnotations;

namespace ApiNet8.Models.DTO
{
    public class InstalacionDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de la instalación es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La ubicacion de la instalación es obligatoria")]
        public string Ubicacion { get; set; }
        [Required(ErrorMessage = "El precio de la instalación es obligatorio")]
        public float Precio { get; set; }
        [Required(ErrorMessage = "Las condiciones de la instalación son obligatorias")]
        public string Condiciones { get; set; }
        [Required(ErrorMessage = "La hora de apertura de la instalación es obligatoria")]
        public TimeOnly HoraInicio { get; set; }
        [Required(ErrorMessage = "La hora de cierre de la instalación es obligatoria")]
        public TimeOnly HoraCierre { get; set; }
    }
}

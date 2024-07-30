using System.ComponentModel.DataAnnotations;

namespace ApiNet8.Models.DTO
{
    public class TerminosYCondicionesDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Los terminos y ocndiciones son obligatorios")]
        public string TYC { get; set; }
    }
}

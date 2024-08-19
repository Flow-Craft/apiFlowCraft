using System.ComponentModel.DataAnnotations;

namespace ApiNet8.Models.DTO
{
    public class NoticiaDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El titulo de la noticia es obligatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "La descripcion de la noticia es obligatoria")]
        public byte[]? Imagen { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<string>? tag { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

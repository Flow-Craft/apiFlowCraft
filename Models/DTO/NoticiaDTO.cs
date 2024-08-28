using System.ComponentModel.DataAnnotations;

namespace ApiNet8.Models.DTO
{
    public class NoticiaDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public byte[]? Imagen { get; set; }
        public DateTime ? FechaInicio { get; set; }
        public DateTime ? FechaFin { get; set; }
        public List<string>? tag { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

namespace ApiNet8.Models.NoticiasYNotificaciones
{
    public class Noticias
    {
        public int Id { get; set; }
        public string Titulo { get; set;}
        public string Descripcion { get; set;}
        public byte[]? Imagen { get; set;}
        public DateTime FechaInicio { get; set;}
        public DateTime FechaFin {  get; set;}
        public DateTime? FechaModificacion { get; set;}
        public DateTime? FechaBaja { get; set;}
        public DateTime FechaCreacion { get; set;}
        public List<string>? tag {  get; set;}
        public int UsuarioEditor { get; set;}
    }
}

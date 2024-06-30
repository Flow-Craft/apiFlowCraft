namespace ApiNet8.Models.Lecciones
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion {  get; set; }
        public int EdadMinima { get; set; }
        public int EdadMaxima { get; set; }
        public string Genero { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

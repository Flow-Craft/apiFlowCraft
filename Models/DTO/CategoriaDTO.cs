namespace ApiNet8.Models.DTO
{
    public class CategoriaDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int EdadMinima { get; set; }
        public int EdadMaxima { get; set; }
        public string? Genero { get; set; }        
    }
}

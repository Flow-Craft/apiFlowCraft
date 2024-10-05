namespace ApiNet8.Models.DTO
{
    public class TipoEventoDTO
    {
        public int Id { get; set; }
        public string? NombreTipoEvento { get; set; } // Partido, Recital, Taller, Curso, Feria
        public string? Descripcion { get; set; }      
    }
}

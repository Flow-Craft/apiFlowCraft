namespace ApiNet8.Models.DTO
{
    public class LeccionDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public List<string>? Dias { get; set; }
        public List<string>? Horarios { get; set; }
        public int CantMaxima { get; set; }
        public string? Descripcion { get; set; }
        public string? Lugar { get; set; }
        public int IdDisciplina { get; set; }
        public int IdCategoria { get; set; }
        public int idProfesor {  get; set; }
    }
}

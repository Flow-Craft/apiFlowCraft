namespace ApiNet8.Models.DTO
{
    public class ReporteLeccionDTO
    {
        public string? Disciplina { get; set; }
        public string? Categoria { get; set; }
        public DateTime? FechaLeccion { get; set; }
        public string? NomProfesor { get; set; }
        public string? Asistencia { get; set; }
        public int? DniAlumno { get; set; }
        public string? NomAlumno { get; set; }

        //Que deben enviar
        public int? idDisciplina { get; set; }
        public int? idCategoria { get; set; }
        public int? idUsuario { get; set; }
        public DateTime? periodoInicio { get; set; }
        public DateTime? periodoFin { get; set; }
    }
}

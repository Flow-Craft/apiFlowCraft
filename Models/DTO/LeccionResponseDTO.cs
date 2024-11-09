using ApiNet8.Models.Lecciones;

namespace ApiNet8.Models.DTO
{
    public class LeccionResponseDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<string> Dias { get; set; }
        public List<string> Horarios { get; set; }
        public int CantMaxima { get; set; }
        public string Descripcion { get; set; }
        public string Lugar { get; set; }
        public int idProfesor { get; set; }

        // Relaciones
        public Disciplina Disciplina { get; set; }
        public Categoria Categoria { get; set; }
        public bool Activa { get; set; }
    }
}

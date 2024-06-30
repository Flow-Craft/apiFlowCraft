using ApiNet8.Models.Usuarios;

namespace ApiNet8.Models.Lecciones
{
    public class Leccion
    {
        public int IdLeccion { get; set; }
        public string Nombre { get; set; }
        public List<string> Dias {  get; set; }
        public List<string> Horarios { get; set; }
        public int CantMaxima { get; set; }
        public string Descripcion { get; set; }
        public string Lugar { get; set; }

        // Relaciones
        public Disciplina Disciplina { get; set; }
        public Categoria Categoria { get; set; }
        public List<LeccionHistorial> LeccionHistoriales { get; set; }
        public Usuario Usuario { get; set; }
    }
}

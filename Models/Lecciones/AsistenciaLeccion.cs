using ApiNet8.Models.Usuarios;

namespace ApiNet8.Models.Lecciones
{
    public class AsistenciaLeccion
    {
        public int Id {  get; set; }
        public bool AsistioAlumno { get; set; }
        public bool ClaseCompleta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }

        // Relaciones
        public Leccion Leccion { get; set; }
        public Usuario Usuario { get; set; }
    }
}

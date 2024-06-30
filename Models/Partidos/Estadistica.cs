using ApiNet8.Models.Lecciones;

namespace ApiNet8.Models.Partidos
{
    public class Estadistica
    {
        public int Id { get; set; }
        public string MarcaEstadistica { get; set; }
        public int PuntajeTipoAccion {  get; set; }
        public string RazonBaja { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }

        // Relaciones
        public TipoAccionPartido TipoAccionPartido { get; set; }
        public Partido Partido { get; set; }
        public AsistenciaLeccion? AsistenciaLeccion { get; set; }
        public Equipo Equipo { get; set; }
    }
}

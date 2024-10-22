using ApiNet8.Models.Eventos;
using ApiNet8.Models.Lecciones;
using Microsoft.EntityFrameworkCore;

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
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public TipoAccionPartido TipoAccionPartido { get; set; }


        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Partido Partido { get; set; }


        [DeleteBehavior(DeleteBehavior.Restrict)]
        public AsistenciaLeccion? AsistenciaLeccion { get; set; }
        

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Equipo? Equipo { get; set; }
        
    }
}

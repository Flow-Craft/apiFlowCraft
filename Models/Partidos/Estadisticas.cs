using ApiNet8.Models.Eventos;
using ApiNet8.Models.Lecciones;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiNet8.Models.Partidos
{
    public class Estadisticas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? MarcaEstadistica { get; set; }
        public int PuntajeTipoAccion {  get; set; }
        public string? RazonBaja { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
        public int? NroJugador { get; set; }

        // Relaciones      
        public TipoAccionPartido? TipoAccionPartido { get; set; }


        public Partido? Partido { get; set; }


        public int? AsistenciaLeccionId { get; set; }
        

        public Equipo? Equipo { get; set; }
        
    }
}

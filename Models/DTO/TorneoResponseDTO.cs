using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Partidos;
using ApiNet8.Models.Torneos;

namespace ApiNet8.Models.DTO
{
    public class TorneoResponseDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CantEquipos { get; set; }
        public byte[] Banner { get; set; }
        public string Condiciones { get; set; }
        public DateTime FechaInicio { get; set; }
        public Disciplina Disciplina { get; set; }
        public Categoria Categoria { get; set; }
        public string TorneoEstado { get; set; }
        public List<Partido> Partidos { get; set; }
        public List<Equipo> Equipos { get; set; }
    }
}

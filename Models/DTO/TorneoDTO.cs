using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Torneos;

namespace ApiNet8.Models.DTO
{
    public class TorneoDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int IdDisciplina { get; set; }
        public int IdCategoria { get; set; }
        public int IdInstalacion { get; set; }
        public int CantEquipos { get; set; }
        public byte[] Banner { get; set; }
        public string? Condiciones { get; set; }
        public DateTime FechaInicio { get; set; }
        public List<int> IdEquipos { get; set; }

    }
}

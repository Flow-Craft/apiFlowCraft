using ApiNet8.Models.Lecciones;

namespace ApiNet8.Models.Partidos
{
    public class TipoAccionPartido
    {
        public int Id { get; set; }
        public string NombreTipoAccion { get; set; }
        public string Descripcion { get; set; }
        public bool ModificaTarjetasAdvertencia { get; set; }
        public bool ModificaTarjetasExpulsion { get; set; }
        public bool secuencial { get; set; }

        // Relaciones
        public IList<TipoAccionHistorial> TipoAccionHistoriales { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}

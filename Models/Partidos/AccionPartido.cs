namespace ApiNet8.Models.Partidos
{
    public class AccionPartido
    {
        public int Id { get; set; }
        public int NroJugador { get; set; }
        public int NroJugadorCambio { get; set; }
        public bool EquipoLocal { get; set; }
        public int Minuto { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
        public int? Periodo { get; set; }
        public int NroJugadorCambio { get; set; }

        // Relaciones
        public TipoAccionPartido TipoAccionPartido { get; set; }
        public Partido Partido { get; set; }
    }
}
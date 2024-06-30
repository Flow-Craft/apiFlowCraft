namespace ApiNet8.Models.Lecciones
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CantJugadores { get; set; }
        public int PeriodosMax { get; set; }
        public int TarjetasAdvertencia { get; set; }
        public int TarjetasExpulsion { get; set; }
        public int CantJugadoresEnBanca { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

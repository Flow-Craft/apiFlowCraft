namespace ApiNet8.Models.DTO
{
    public class DisciplinaDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? CantJugadores { get; set; }
        public int? PeriodosMax { get; set; }
        public int? TarjetasAdvertencia { get; set; }
        public int? TarjetasExpulsion { get; set; }
        public int? CantJugadoresEnBanca { get; set; }  
    }
}

namespace ApiNet8.Models
{
    public class Partido : Evento
    {
        public int IdPartido { get; set; }        
        public string? Resultado {  get; set; }
        public int? Periodo {  get; set; }
        public string? Set { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}

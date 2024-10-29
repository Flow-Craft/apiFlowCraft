namespace ApiNet8.Models.DTO
{
    public class EstadisticasReporteDTO
    {
        public int IdDisciplina { get; set; }
        public int IdUsuario { get; set; }
        public DateTime PeriodoInicio { get; set; }
        public DateTime PeriodoFin {  get; set; }
        public int IdLeccion {  get; set; }
        public int IdEquipo {  get; set; }
        public int IdInstalacion { get; set; }
    }
}

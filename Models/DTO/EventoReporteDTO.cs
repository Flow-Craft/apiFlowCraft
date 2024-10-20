namespace ApiNet8.Models.DTO
{
    public class EventoReporteDTO
    {
        public int idUsuario { get; set; }
        public DateTime periodoInicio { get; set; }
        public DateTime periodoFin {  get; set; }
        public int idTipoEvento { get; set; }
        public int idInstalacion { get; set; }
    }
}

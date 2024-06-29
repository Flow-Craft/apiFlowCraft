namespace ApiNet8.Models.TYC
{
    public class HistorialTerminosYCondiciones
    {
        public int IdHistorialTerminosYCondiciones { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public int UsuarioEditor {  get; set; }
    }
}

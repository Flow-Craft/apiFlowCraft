namespace ApiNet8.Models.DTO
{
    public class SolicitudAsociacionDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni {  get; set; }
        public string EMail { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string MotivoRechazo {  get; set; }
        public string Estado { get; set; }
    }
}

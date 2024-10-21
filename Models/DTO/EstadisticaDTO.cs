namespace ApiNet8.Models.DTO
{
    public class EstadisticaDTO
    {
        public int? Id { get; set; }
        public int? IdPartido { get; set; }
        public int? IdAsistencia { get; set; }
        public int IdTipoAccion { get; set; }
        public int? IdEquipo { get; set; }
        public int? IdUsuario { get; set; }
        public string? MarcaEstadistica { get; set; }
        public int PuntajeTipoAccion { get; set; }
        public string? RazonBaja { get; set; }
        public bool? Secuencial { get; set; }
        public bool? Resta { get; set; }
        public bool? Leccion { get; set; }
    }
}

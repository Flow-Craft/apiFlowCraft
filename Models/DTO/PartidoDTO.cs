namespace ApiNet8.Models.DTO
{
    public class PartidoDTO
    {
        public int Id { get; set; }
        public int? ResultadoLocal { get; set; }
        public int? ResultadoVisitante { get; set; }
        public int? Periodo { get; set; }
        public string? Motivo { get; set; }

        public List<int>? jugadoresCanchaEquipLoc { get; set; }
        public List<int>? jugadoresCanchaEquipVis { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ApiNet8.Models.DTO
{
    public class InstalacionDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Ubicacion { get; set; }
        public float? Precio { get; set; }
        public string? Condiciones { get; set; }
        public TimeOnly? HoraInicio { get; set; }
        public TimeOnly? HoraCierre { get; set; }
        public int EstadoId { get; set; }
    }
}

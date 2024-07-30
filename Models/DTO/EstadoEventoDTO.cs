namespace ApiNet8.Models.DTO
{
    public class EstadoEventoDTO
    {
        public int Id { get; set; }
        public string NombreEstado { get; set; }
        public string DescripcionEstado { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

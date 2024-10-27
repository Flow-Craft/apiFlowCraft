namespace ApiNet8.Models.DTO
{
    public class ReservaDTO
    {
        public int Id { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public int InstalacionId { get; set; }
        public int UsuarioId { get; set; }

    }
}

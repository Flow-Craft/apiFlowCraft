using ApiNet8.Models.Usuarios;

namespace ApiNet8.Models.Reservas
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }

        // Relaciones
        public Instalacion Instalacion { get; set; }
        public Usuario Usuario { get; set; }
    }
}

using ApiNet8.Models.Usuarios;
namespace ApiNet8.Models.Eventos
{
    public class Asistencia
    {
        public int IdAsistencia { get; set; }
        public DateTime HoraEntrada { get; set; }

        // Relaciones
        public Evento Evento { get; set; }
        public Usuario Usuario { get; set; }
    }
}

using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Reservas;
using Microsoft.EntityFrameworkCore;

namespace ApiNet8.Models.Eventos
{
    public class Evento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinEvento { get; set; }
        public byte[]? Banner { get; set; }
        public string? ImageType { get; set; } // Para almacenar el tipo de la imagen (image/jpeg, image/png)
        public int CupoMaximo { get; set; }
        public bool EventoLleno { get; set; }
        public string? LinkStream { get; set; }
        public string? Descripcion { get; set; }

        // Relaciones
        public IList<HistorialEvento>? HistorialEventoList { get; set; }
        public TipoEvento TipoEvento { get; set; }
        public Instalacion Instalacion { get; set; }
        public Categoria Categoria { get; set; }       
        public Disciplina Disciplina { get; set; }
    }
}

namespace ApiNet8.Models
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaInicio { get; set; }
        public byte[]? Banner { get; set; }
        public string? ImageType { get; set; } // Para almacenar el tipo de la imagen (image/jpeg, image/png)
        public int CupoMaximo { get; set; }
        public bool EventoLleno { get; set;}
        public string? LinkStream { get; set; }
        public string? Descripcion { get; set; }

    }
}

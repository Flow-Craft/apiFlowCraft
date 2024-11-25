
namespace ApiNet8.Models.Club
{
    public class Backup
    {
        public int Id { get; set; }
        public int Version { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Tipo { get; set; }
        public byte[] Pdf { get; set; }
        public string Nombre { get; set; }
    }
}

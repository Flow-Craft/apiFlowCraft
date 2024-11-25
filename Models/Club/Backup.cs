
namespace ApiNet8.Models.Club
{
    public class Backup
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public string Tipo { get; set; }
        public byte[] Pdf { get; set; }
        public string Nombre { get; set; }
    }
}

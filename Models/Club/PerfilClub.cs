namespace ApiNet8.Models.Club
{
    public class PerfilClub
    {
        public int IdPerfilClub { get; set; }
        public string NombrePerfilClub { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
    }
}

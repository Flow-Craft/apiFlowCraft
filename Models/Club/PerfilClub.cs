namespace ApiNet8.Models.Club
{
    public class PerfilClub
    {
        public int Id { get; set; }
        public string NombrePerfilClub { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
        public bool Activo {  get; set; }
    }
}

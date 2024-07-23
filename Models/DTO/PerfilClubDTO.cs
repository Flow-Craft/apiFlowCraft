namespace ApiNet8.Models.DTO
{
    public class PerfilClubDTO
    {
        // perfil club
        public int Id { get; set; }
        public string NombrePerfilClub { get; set; }       
        public int UsuarioEditor { get; set; }

        // parametros club
        public string Nombre { get; set; }
        public string ColorPrincipal { get; set; }
        public string ColorSecundario { get; set; }
        public byte[]? LogoPequenio { get; set; }
        public byte[]? LogoGrande { get; set; }
        public byte[]? IconoPlataforma { get; set; }
        public string TextoBannerEmail { get; set; }
        public string TextoFooterEmail { get; set; }
        public string ColorBannerEmail { get; set; }
        public string TextoEmail { get; set; }
        public string QuienesSomos { get; set; }
    }
}

namespace ApiNet8.Models.Club
{
    public class ParametrosClub
    {
        public int Id { get; set; }
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

        // Relaciones
        public List<ClubHistorial>? clubHistoriales { get; set; }
        public PerfilClub? PerfilClub { get; set; }
    }
}

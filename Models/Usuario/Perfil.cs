namespace ApiNet8.Models.Usuario
{
    public class Perfil
    {
        public int IdPerfil { get; set; }
        public string NombrePerfil { get; set; } // Simpatizante, Socio, Administrativo, Admin, Arbitro, Planillero, Profesor
        public string DescripcionPerfil { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int UsuarioEditor {  get; set; }
    }
}

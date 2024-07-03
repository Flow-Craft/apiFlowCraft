namespace ApiNet8.Models.Usuarios
{
    public class Perfil
    {
        public int Id { get; set; }
        public string NombrePerfil { get; set; } // Simpatizante, Socio, Administrativo, Admin, Arbitro, Planillero, Profesor
        public string DescripcionPerfil { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int UsuarioEditor {  get; set; }

        // Relaciones
        public IList<Permiso> Permisos { get; set; }
    }
}

namespace ApiNet8.Models.Usuarios
{
    public class PerfilUsuario
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaBaja { get; set; }

        // Relaciones
        public Perfil Perfil { get; set; }
        public Usuario Usuario { get; set; }

    }
}

namespace ApiNet8.Models.Usuarios
{
    public class PerfilPermiso
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int UsuarioEditor { get; set; }
        //Relaciones
        public Perfil Perfil { get; set; }
        public Permiso Permiso { get; set; }
    }
}

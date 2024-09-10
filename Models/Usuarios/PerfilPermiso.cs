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
        public int PerfilId { get; set; }
        public int PermisoId { get; set; }
    }
}

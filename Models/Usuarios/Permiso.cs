namespace ApiNet8.Models.Usuarios
{
    public class Permiso
    {
        public int Id { get; set; }
        public string NombrePermiso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Modulo { get; set; } // podria ser un Enum de utils
        public string Funcionalidades { get; set; }
    }
}

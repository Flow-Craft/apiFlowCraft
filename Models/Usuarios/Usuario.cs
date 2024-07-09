namespace ApiNet8.Models.Usuarios
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? CodPostal { get; set; }
        public string Contrasena {  get; set; }
        public string? DeporteFavorito { get; set; }
        public string Direccion {  get; set; }
        public int Telefono { get; set; }
        public int Dni {  get; set; }   
        public string Email { get; set; }   
        public DateTime FechaAceptacionTYC { get; set; }
        public DateTime FechaCambioContrasena { get; set; }
        public DateTime FechaNacimiento {  get; set; }
        public byte[]? FotoPerfil { get; set; }
        public string? ImageType { get; set; } // Para almacenar el tipo de la imagen (image/jpeg, image/png)
        public string? Pais {  get; set; }
        public string? Provincia { get; set; }
        public string? Localidad { get; set; }
        public DateTime? UltimoAcceso { get; set; }        

        // Relaciones
        public IList<PerfilUsuario> PerfilesUsuario { get; set; }
        public IList<UsuarioHistorial> UsuarioHistoriales { get; set; }
    }
}

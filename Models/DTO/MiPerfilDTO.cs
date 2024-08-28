namespace ApiNet8.Models.DTO
{
    public class MiPerfilDTO
    {       
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }        
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public byte[]? FotoPerfil { get; set; }
        public string? ImageType { get; set; } // Para almacenar el tipo de la imagen (image/jpeg, image/png)
        public bool? mostrarBotonAsociarse { get; set; }
     }
}

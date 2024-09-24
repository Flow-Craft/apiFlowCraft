using ApiNet8.Models.Usuarios;
using System.ComponentModel.DataAnnotations;

namespace ApiNet8.Models.DTO
{
    public class PerfilDTO
    {
        public int Id { get; set; }
        public string? NombrePerfil { get; set; } // Simpatizante, Socio, Administrativo, Admin, Arbitro, Planillero, Profesor
        public string? DescripcionPerfil { get; set; }
        public int? UsuarioEditor { get; set; }
    }
}

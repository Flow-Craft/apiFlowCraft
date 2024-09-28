using ApiNet8.Models.Usuarios;

namespace ApiNet8.Models.DTO
{
    public class PerfilResponseDTO
    {
        public Perfil? Perfil { get; set; }
        public List<Permiso>? Permisos { get; set; }
    }
}

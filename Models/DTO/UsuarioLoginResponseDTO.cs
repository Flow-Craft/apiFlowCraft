using ApiNet8.Models.Usuarios;

namespace ApiNet8.Models.DTO
{
    public class UsuarioLoginResponseDTO
    {
        public string JwtToken { get; set; }
        public UsuarioDTO Usuario { get; set; }
    }
}

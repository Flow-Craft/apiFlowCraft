using ApiNet8.Models.DTO;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Services.IServices
{
    public interface IUsuarioServices
    {
        List<Usuario> GetUsuarios();
        Usuario GetUsuarioById(int id);
        Usuario CrearUsuario(Usuario usuario);
        bool ExisteUsuario(UsuarioRegistroDTO usuario);
        bool VerificarContraseña(Usuario usuario, string contrasena);
        Task<Usuario> Login (UsuarioLoginDTO usuarioLoginDTO);
        Task<Usuario> Registro(UsuarioRegistroDTO usuarioRegistroDTO);
        Usuario GetUsuarioByEmailAndPassword(string email,string password);
    }
}

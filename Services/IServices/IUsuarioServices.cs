using ApiNet8.Models.Usuarios;

namespace ApiNet8.Services.IServices
{
    public interface IUsuarioServices
    {
        List<Usuario> GetUsuarios();
        Usuario GetUsuarioById(int id);
        Usuario CrearUsuario(Usuario usuario);
        bool ExisteUsuario(string usuario);
        bool VerificarContraseña(Usuario usuario, string contrasena);
    }
}

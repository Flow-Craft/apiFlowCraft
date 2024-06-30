using ApiNet8.Models.Usuario;

namespace ApiNet8.Services.IServices
{
    public interface IUsuarioServices
    {
        Usuario CrearUsuario(string nombre, string contrasena);
        bool VerificarContraseña(Usuario usuario, string contrasena);
    }
}

using ApiNet8.Models;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Services.IServices
{
    public interface IUsuarioEstadoServices
    {
        List<UsuarioEstado> GetUsuarioEstados();
        UsuarioEstado GetUsuarioEstadoById(int Id);
        UsuarioEstado CrearUsuarioEstado(UsuarioEstadoDTO usuarioEstado, JwtToken currentUserJwt);
        UsuarioEstado ActualizarUsuarioEstado(UsuarioEstadoDTO usuarioEstado, JwtToken currentUserJwt);
        UsuarioEstado EliminarUsuarioEstado(int id, JwtToken currentUserJwt);
        bool ExisteUsuarioEstado(string nombre);
    }
}

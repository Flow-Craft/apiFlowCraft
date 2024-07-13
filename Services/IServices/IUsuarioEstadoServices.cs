using ApiNet8.Models.DTO;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Services.IServices
{
    public interface IUsuarioEstadoServices
    {
        List<UsuarioEstado> GetUsuarioEstados();
        UsuarioEstado GetUsuarioEstadoById(int Id);
        UsuarioEstado CrearUsuarioEstado(UsuarioEstado usuarioEstado);
        UsuarioEstado ActualizarUsuarioEstado(UsuarioEstadoDTO perfil);
        UsuarioEstado EliminarUsuarioEstado(int id);
        bool ExisteUsuarioEstado(string nombre);
    }
}

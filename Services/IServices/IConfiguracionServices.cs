using ApiNet8.Models;
using ApiNet8.Models.Club;
using ApiNet8.Models.DTO;
using ApiNet8.Models.TYC;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Services.IServices
{
    public interface IConfiguracionServices
    {
        List<Perfil> GetPerfiles();
        List<Permiso> GetPermisos();
        Perfil GetPerfilById(int Id);
        Perfil CrearPerfil(PerfilDTO perfil, List<Permiso> permisos);
        Perfil ActualizarPerfil(PerfilDTO perfil, List<Permiso> permisos);
        Perfil EliminarPerfil(int id, JwtToken currentUserJwt);
        bool ExistePerfil(string nombre);
        List<Permiso> GetPermisosByPerfil(Perfil perfil);
        PerfilClub CrearPerfilClub(PerfilClubDTO perfilClubDTO);
        PerfilClub ActualizarPerfilClub(PerfilClubDTO perfilClubDTO);
        void EliminarPerfilClub(int id);
        PerfilClub GetPerfilClubById(int Id);
        TerminosYCondiciones CrearTYC(TerminosYCondicionesDTO terminosYCondiciones);
        TerminosYCondiciones ObtenerTYC();
        PerfilClubResponseDTO GetPerfilClubActivo();
    }
}

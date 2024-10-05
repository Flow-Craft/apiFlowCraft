using ApiNet8.Models;
using ApiNet8.Models.Club;
using ApiNet8.Models.DTO;
using ApiNet8.Models.TYC;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Services.IServices
{
    public interface IConfiguracionServices
    {
        List<PerfilResponseDTO> GetPerfiles();
        List<Permiso> GetPermisos();
        Perfil GetPerfilById(int Id);
        PerfilResponseDTO GetPerfilYPermisosById(int Id);
        Perfil CrearPerfil(PerfilDTO perfil, List<int> permisos);
        Perfil ActualizarPerfil(PerfilDTO perfil, List<int> permisos);
        Perfil EliminarPerfil(int id);
        bool ExistePerfil(string nombre);
        List<Permiso> GetPermisosByPerfil(PerfilDTO perfil);
        PerfilClub CrearPerfilClub(PerfilClubDTO perfilClubDTO);
        PerfilClub ActualizarPerfilClub(PerfilClubDTO perfilClubDTO);
        void EliminarPerfilClub(int id);
        PerfilClub GetPerfilClubById(int Id);
        TerminosYCondiciones CrearTYC(TerminosYCondicionesDTO terminosYCondiciones);
        TerminosYCondiciones ObtenerTYC();
        PerfilClubResponseDTO GetPerfilClubActivo();
        PerfilClubQuienesSomosDTO GetPerfilClubQuienesSomos();
        PerfilUsuario GetPerfilUsuario(Usuario usuario);
        Perfil GetPerfilByNombre(string nombre);
    }
}

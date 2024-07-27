using ApiNet8.Models.Club;
using ApiNet8.Models.DTO;
using ApiNet8.Models.TYC;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Services.IServices
{
    public interface IConfiguracionServices
    {
        List<Perfil> GetPerfiles();
        Perfil GetPerfilById(int Id);
        Perfil CrearPerfil(Perfil perfil);
        Perfil ActualizarPerfil(PerfilDTO perfil);
        Perfil EliminarPerfil(int id);
        bool ExistePerfil(string nombre);
        List<Permiso> GetPermisosByPerfil(Perfil perfil);
        PerfilClub CrearPerfilClub(PerfilClubDTO perfilClubDTO);
        PerfilClub ActualizarPerfilClub(PerfilClubDTO perfilClubDTO);
        PerfilClub EliminarPerfilClub(int id);
        PerfilClub GetPerfilClubById(int Id);
        TerminosYCondiciones CrearTYC(TerminosYCondicionesDTO terminosYCondiciones);
    }
}

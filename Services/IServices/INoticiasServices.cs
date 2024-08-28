using ApiNet8.Models.DTO;
using ApiNet8.Models.NoticiasYNotificaciones;

namespace ApiNet8.Services.IServices
{
    public interface INoticiasServices
    {
        List<Noticias> GetNoticias();
        List<Noticias> GetNoticiasActivas();
        Noticias GetNoticiaById(int Id);
        Noticias CrearNoticia(NoticiaDTO noticiaDTO);
        void ActualizarNoticia(NoticiaDTO noticiaDTO);
        Noticias EliminarNoticia(int id);
        bool ExisteNoticia(string nombre);
    }
}

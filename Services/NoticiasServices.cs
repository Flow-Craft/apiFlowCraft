using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.NoticiasYNotificaciones;
using ApiNet8.Models.Reservas;
using ApiNet8.Services.IServices;
using AutoMapper;

namespace ApiNet8.Services
{
    public class NoticiasServices : INoticiasServices
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public NoticiasServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        Noticias INoticiasServices.ActualizarNoticia(NoticiaDTO noticiaDTO)
        {
            throw new NotImplementedException();
        }

        Noticias INoticiasServices.CrearNoticia(NoticiaDTO noticiaDTO)
        {
            throw new NotImplementedException();
        }

        Noticias INoticiasServices.EliminarNoticia(int id)
        {
            throw new NotImplementedException();
        }

        bool INoticiasServices.ExisteNoticia(string nombre)
        {
            throw new NotImplementedException();
        }

        Noticias INoticiasServices.GetNoticiaById(int Id)
        {
            throw new NotImplementedException();
        }

        List<Noticias> INoticiasServices.GetNoticias()
        {
            try
            {
                return _db.Noticias.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        List<Noticias> INoticiasServices.GetNoticiasActivas()
        {
            try
            {
                List<Noticias> noticiasAct = _db.Noticias.Where(i=> i.FechaBaja==null && i.FechaFin>=DateTime.Now).ToList();

                return noticiasAct;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}

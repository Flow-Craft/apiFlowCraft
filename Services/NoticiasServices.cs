using ApiNet8.Data;
using ApiNet8.Models;
using ApiNet8.Models.DTO;
using ApiNet8.Models.NoticiasYNotificaciones;
using ApiNet8.Models.Partidos;
using ApiNet8.Models.Reservas;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using XAct.Users;

namespace ApiNet8.Services
{
    public class NoticiasServices : INoticiasServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public NoticiasServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public void ActualizarNoticia(NoticiaDTO noticiaDTO)
        {
            try
            {
                if (noticiaDTO.FechaFin < noticiaDTO.FechaInicio)
                {
                    throw new Exception("La fecha fin no puede ser menor a la fecha inicio de la publicacion");
                }

                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                using (var transaction = _db.Database.BeginTransaction())
                {
                    Noticias noti = GetNoticiaById(noticiaDTO.Id);

                    noti.Titulo = noticiaDTO.Titulo ?? noti.Titulo;
                    noti.Descripcion = noticiaDTO.Descripcion ?? noti.Descripcion;
                    noti.Imagen = noticiaDTO.Imagen ?? noti.Imagen;
                    noti.FechaInicio = noticiaDTO.FechaInicio ?? noti.FechaInicio;
                    noti.FechaFin = noticiaDTO.FechaFin ?? noti.FechaFin;
                    noti.tag = noticiaDTO.tag ?? noti.tag;
                    noti.UsuarioEditor = currentUser.Id;
                    noti.FechaModificacion = DateTime.Now;                   

                    _db.Noticias.Update(noti);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Noticias CrearNoticia(NoticiaDTO noticiaDTO)
        {
            try { 
                if (noticiaDTO.FechaFin<noticiaDTO.FechaInicio)
                {
                    throw new Exception("La fecha fin no puede ser menor a la fecha inicio de la publicacion");
                }

                Noticias noti = _mapper.Map<Noticias>(noticiaDTO);
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                noti.FechaCreacion = DateTime.Now;
                noti.UsuarioEditor = currentUser.Id;
                _db.Add(noti);
                _db.SaveChanges();
                return noti;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Noticias EliminarNoticia(int id)
        {
            try
            {
                Noticias noti = this.GetNoticiaById(id);
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");
                using (var transaction = _db.Database.BeginTransaction())
                {
                    noti.FechaBaja = DateTime.Now;
                    noti.UsuarioEditor = currentUser.Id;
                    _db.Update(noti);
                    _db.SaveChanges();
                    transaction.Commit();
                }
                return noti;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteNoticia(string titulo)
        {
            var noti = _db.Noticias.FirstOrDefault(ee => ee.Titulo == titulo);
            if (noti == null)
            {
                return false;
            }
            return true;
        }

        public Noticias GetNoticiaById(int Id)
        {
            try
            {
                Noticias noti = _db.Noticias.Find(Id);

                if (noti == null)
                {
                    throw new Exception("No se encontro noticia");
                }

                return noti;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Noticias> GetNoticias()
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

        public List<Noticias> GetNoticiasActivas()
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

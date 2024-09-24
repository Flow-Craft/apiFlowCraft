using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using ApiNet8.Models.Eventos;

namespace ApiNet8.Services
{
    public class TipoEventoServices : ITipoEventoServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TipoEventoServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public List<TipoEvento> GetTiposEvento()
        {
            return _db.TipoEvento.ToList();
        }

        public List<TipoEvento> GetTiposEventoActivos()
        {
            return _db.TipoEvento.Where(a => a.FechaBaja == null).ToList();
        }

        public TipoEvento GetTipoEventoById(int id)
        {
            try
            {
                return _db.TipoEvento.Where(u => u.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteTipoEvento(string nombre)
        {
            TipoEvento? tipoEvento = _db.TipoEvento.Where(n => n.NombreTipoEvento.Equals(nombre) && n.FechaBaja == null).FirstOrDefault();

            return tipoEvento != null ? true : false;

        }

        public void CrearTipoEvento(TipoEventoDTO tipoEventoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                TipoEvento tipoEvento = _mapper.Map<TipoEvento>(tipoEventoDTO);

                if (ExisteTipoEvento(tipoEvento.NombreTipoEvento))
                {
                    throw new Exception("Ya existe un estado de leccion con ese nombre.");
                }

                tipoEvento.FechaCreacion = DateTime.Now;
                tipoEvento.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Add(tipoEvento);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void ActualizarTipoEvento(TipoEventoDTO tipoEventoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                TipoEvento tipoEvento = GetTipoEventoById(tipoEventoDTO.Id);

                tipoEvento.FechaModificacion = DateTime.Now;
                tipoEvento.Descripcion = tipoEventoDTO.Descripcion ?? tipoEvento.Descripcion;
                tipoEvento.NombreTipoEvento = tipoEventoDTO.NombreTipoEvento ?? tipoEvento.NombreTipoEvento;
                tipoEvento.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                if (tipoEventoDTO.NombreTipoEvento != null)
                {
                    bool existe = _db.TipoEvento.Any(le => le.NombreTipoEvento == tipoEventoDTO.NombreTipoEvento && le.Id != tipoEvento.Id && le.FechaBaja == null);

                    if (existe)
                    {
                        throw new Exception("Ya existe un tipo de evento con ese nombre.");
                    }
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.TipoEvento.Update(tipoEvento);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void EliminarTipoEvento(TipoEventoDTO tipoEventoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                TipoEvento tipoEvento = GetTipoEventoById(tipoEventoDTO.Id);

                if (tipoEvento == null)
                {
                    throw new Exception("No existe el tipo de evento que quieres eliminar.");
                }

                if (tipoEvento.FechaBaja != null)
                {
                    throw new Exception("El tipo de evento ya esta eliminado.");
                }

                tipoEvento.FechaBaja = DateTime.Now;
                tipoEvento.FechaModificacion = DateTime.Now;
                tipoEvento.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.TipoEvento.Update(tipoEvento);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}

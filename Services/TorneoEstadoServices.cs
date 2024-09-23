using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using ApiNet8.Models.Torneos;

namespace ApiNet8.Services
{
    public class TorneoEstadoServices : ITorneoEstadoServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TorneoEstadoServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public List<TorneoEstado> GetTorneoEstados()
        {
            return _db.TorneoEstado.ToList();
        }

        public List<TorneoEstado> GetTorneoEstadosActivos()
        {
            return _db.TorneoEstado.Where(a => a.FechaBaja == null).ToList();
        }

        public TorneoEstado GetTorneoEstadoById(int id)
        {
            try
            {
                return _db.TorneoEstado.Where(u => u.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteTorneoEstado(string nombre)
        {
            TorneoEstado? torneoEstado = _db.TorneoEstado.Where(n => n.NombreEstado.Equals(nombre) && n.FechaBaja == null).FirstOrDefault();

            return torneoEstado != null ? true : false;

        }

        public void CrearTorneoEstado(TorneoEstadoDTO torneoEstadoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                TorneoEstado torneoEstado = _mapper.Map<TorneoEstado>(torneoEstadoDTO);

                if (ExisteTorneoEstado(torneoEstado.NombreEstado))
                {
                    throw new Exception("Ya existe un estado de torneo con ese nombre.");
                }

                torneoEstado.FechaCreacion = DateTime.Now;
                torneoEstado.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Add(torneoEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void ActualizarTorneoEstado(TorneoEstadoDTO torneoEstadoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                TorneoEstado torneoEstado = GetTorneoEstadoById(torneoEstadoDTO.Id);

                torneoEstado.FechaModificacion = DateTime.Now;
                torneoEstado.DescripcionEstado = torneoEstadoDTO.DescripcionEstado ?? torneoEstado.DescripcionEstado;
                torneoEstado.NombreEstado = torneoEstadoDTO.NombreEstado ?? torneoEstado.NombreEstado;
                torneoEstado.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                if (torneoEstadoDTO.NombreEstado != null)
                {
                    bool existe = _db.TorneoEstado.Any(le => le.NombreEstado == torneoEstadoDTO.NombreEstado && le.Id != torneoEstado.Id && le.FechaBaja == null);

                    if (existe)
                    {
                        throw new Exception("Ya existe un estado de torneo con ese nombre.");
                    }
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.TorneoEstado.Update(torneoEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void EliminarTorneoEstado(TorneoEstadoDTO torneoEstadoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                TorneoEstado torneoEstado = GetTorneoEstadoById(torneoEstadoDTO.Id);

                if (torneoEstado == null)
                {
                    throw new Exception("No existe el estado que quieres eliminar.");
                }

                if (torneoEstado.FechaBaja != null)
                {
                    throw new Exception("El estado de torneo ya esta eliminado.");
                }

                torneoEstado.FechaBaja = DateTime.Now;
                torneoEstado.FechaModificacion = DateTime.Now;
                torneoEstado.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.TorneoEstado.Update(torneoEstado);
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

using ApiNet8.Data;
using ApiNet8.Models;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Partidos;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;

namespace ApiNet8.Services
{
    public class EquipoEstadoService : IEquipoEstadoService
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EquipoEstadoService(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor) 
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public EquipoEstado ActualizarEquipoEstado(EquipoEstadoDTO equipoEstadoDTO)
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                EquipoEstado equipoEstado = GetEquipoEstadoById(equipoEstadoDTO.Id);

                if (equipoEstado.NombreEstado != equipoEstadoDTO.NombreEstado)
                {
                    var existeEstado = ExisteEquipoEstado(equipoEstadoDTO.NombreEstado);
                    if (existeEstado)
                    {
                        throw new Exception("Ya existe un estado con ese nombre");
                    }
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    equipoEstado.NombreEstado = equipoEstadoDTO.NombreEstado ?? equipoEstado.NombreEstado;
                    equipoEstado.DescripcionEstado = equipoEstadoDTO.DescripcionEstado ?? equipoEstado.DescripcionEstado;
                    equipoEstado.FechaModificacion = DateTime.Now;
                    equipoEstado.UsuarioEditor = currentUser.Id;
                    _db.Update(equipoEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }

                return equipoEstado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e);
            }
        }

        public EquipoEstado CrearEquipoEstado(EquipoEstadoDTO equipoEstadoDTO)
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                var existeEstado = ExisteEquipoEstado(equipoEstadoDTO.NombreEstado);
                if (existeEstado)
                {
                    throw new Exception("Ya existe un estado con ese nombre");
                }

                EquipoEstado estEquip = _mapper.Map<EquipoEstado>(equipoEstadoDTO);
                estEquip.FechaCreacion = DateTime.Now;
                estEquip.UsuarioEditor = currentUser.Id;
                _db.Add(estEquip);
                _db.SaveChanges();
                return estEquip;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public EquipoEstado EliminarEquipoEstado(int id)
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                EquipoEstado equipoEstado = this.GetEquipoEstadoById(id);
                using (var transaction = _db.Database.BeginTransaction())
                {
                    equipoEstado.FechaBaja = DateTime.Now;
                    equipoEstado.UsuarioEditor = currentUser.Id;
                    _db.Update(equipoEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }
                return equipoEstado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteEquipoEstado(string nombre)
        {
            var equipEst = _db.EquipoEstado.FirstOrDefault(ee => ee.NombreEstado == nombre);
            if (equipEst == null)
            {
                return false;
            }
            return true;
        }

        public EquipoEstado GetEquipoEstadoById(int Id)
        {
            try
            {
                EquipoEstado equipoEstado = _db.EquipoEstado.Find(Id);

                return equipoEstado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<EquipoEstado> GetEquipoEstados()
        {
            try
            {
                return _db.EquipoEstado.Where(p => p.FechaBaja == null).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}

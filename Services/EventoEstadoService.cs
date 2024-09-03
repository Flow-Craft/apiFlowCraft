using ApiNet8.Data;
using ApiNet8.Models;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;

namespace ApiNet8.Services
{
    public class EventoEstadoService : IEventoEstadoService
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EventoEstadoService(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }
        public EstadoEvento ActualizarEventoEstado(EstadoEventoDTO eventoEstadoDTO)
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                EstadoEvento eventoEstado = GetEventoEstadoById(eventoEstadoDTO.Id);

                if (eventoEstado.NombreEstado != eventoEstadoDTO.NombreEstado)
                {
                    var existeEstado = ExisteEventoEstado(eventoEstadoDTO.NombreEstado);
                    if (existeEstado)
                    {
                        throw new Exception("Ya existe un estado con ese nombre");
                    }
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    eventoEstado.NombreEstado = eventoEstadoDTO.NombreEstado ?? eventoEstado.NombreEstado;
                    eventoEstado.DescripcionEstado = eventoEstadoDTO.DescripcionEstado ?? eventoEstado.DescripcionEstado;
                    eventoEstado.FechaModificacion = DateTime.Now;
                    eventoEstado.UsuarioEditor = currentUser.Id;
                    _db.Update(eventoEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }
 
                return eventoEstado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e);
            }
        }

        public EstadoEvento CrearEventoEstado(EstadoEventoDTO eventoEstadoDTO)
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                var existeEstado = ExisteEventoEstado(eventoEstadoDTO.NombreEstado);
                if (existeEstado)
                {
                    throw new Exception("Ya existe un estado con ese nombre");
                }

                //mapper de usuariodto a usuario
                EstadoEvento estEvent = _mapper.Map<EstadoEvento>(eventoEstadoDTO);
                estEvent.FechaCreacion = DateTime.Now;
                estEvent.UsuarioEditor = currentUser.Id;
                _db.Add(estEvent);
                _db.SaveChanges();
                return estEvent;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public EstadoEvento EliminarEventoEstado(int id)
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                EstadoEvento eventoEstado = this.GetEventoEstadoById(id);
                using (var transaction = _db.Database.BeginTransaction())
                {
                    eventoEstado.FechaBaja = DateTime.Now;
                    eventoEstado.UsuarioEditor = currentUser.Id;
                    _db.Update(eventoEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }
                return eventoEstado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteEventoEstado(string nombre)
        {
            var eventEst = _db.EstadoEvento.FirstOrDefault(ee => ee.NombreEstado == nombre);
            if (eventEst == null)
            {
                return false;
            }
            return true;
        }

        public EstadoEvento GetEventoEstadoById(int Id)
        {
            try
            {
                EstadoEvento eventEstado = _db.EstadoEvento.Find(Id);

                return eventEstado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<EstadoEvento> GetEventoEstados()
        {
            try
            {
                return _db.EstadoEvento.Where(p => p.FechaBaja == null).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}

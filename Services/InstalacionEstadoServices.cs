using ApiNet8.Data;
using ApiNet8.Models;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Reservas;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using XAct.Library.Settings;

namespace ApiNet8.Services
{
    public class InstalacionEstadoServices : IInstalacionEstadoServices
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public InstalacionEstadoServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public void ActualizarInstalacionEstado(InstalacionEstadoDTO instalacionEstadoDTO)
        {
            try
            {
                InstalacionEstado instEst = GetInstalacionEstadoById(instalacionEstadoDTO.Id);
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                using (var transaction = _db.Database.BeginTransaction())
                {

                    instEst.NombreEstado = instalacionEstadoDTO.NombreEstado ?? instEst.NombreEstado;
                    instEst.DescripcionEstado = instalacionEstadoDTO.DescripcionEstado ?? instEst.DescripcionEstado;
                    instEst.FechaModificacion = DateTime.Now;
                    instEst.UsuarioEditor = currentUser != null ? currentUser.Id : 0;
                    _db.Update(instEst);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void CrearInstalacionEstado(InstalacionEstadoDTO instalacionEstadoDTO)
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                var existeEstado = ExisteInstalacionEstado(instalacionEstadoDTO.NombreEstado);
                if (existeEstado)
                {
                    throw new Exception("Ya existe un estado con ese nombre");
                }

                //mapper de usuariodto a usuario
                InstalacionEstado estInst = _mapper.Map<InstalacionEstado>(instalacionEstadoDTO);
                estInst.FechaCreacion = DateTime.Now;
                estInst.UsuarioEditor = currentUser != null ? currentUser.Id : 0;
                _db.Add(estInst);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void EliminarInstalacionEstado(int id)
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                InstalacionEstado instEstado = this.GetInstalacionEstadoById(id);
                using (var transaction = _db.Database.BeginTransaction())
                {
                    instEstado.FechaBaja = DateTime.Now;
                    instEstado.UsuarioEditor = currentUser != null ? currentUser.Id : 0;
                    _db.Update(instEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteInstalacionEstado(string nombre)
        {
            var instEst = _db.InstalacionEstado.FirstOrDefault(ee => ee.NombreEstado == nombre);
            if (instEst == null)
            {
                return false;
            }
            return true;
        }

        public InstalacionEstado GetInstalacionEstadoById(int Id)
        {
            try
            {
                InstalacionEstado instEstado = _db.InstalacionEstado.Find(Id);

                return instEstado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<InstalacionEstado> GetInstalacionEstados()
        {
            try
            {
                return _db.InstalacionEstado.Where(p => p.FechaBaja == null).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}

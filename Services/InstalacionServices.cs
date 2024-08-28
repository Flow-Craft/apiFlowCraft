using ApiNet8.Data;
using ApiNet8.Models;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Reservas;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using XAct.Library.Settings;
using XAct.Users;

namespace ApiNet8.Services
{
    public class InstalacionServices : IInstalacionServices
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IInstalacionEstadoServices _instalacionEstadoServices;

        public InstalacionServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor, IInstalacionEstadoServices instalacionEstadoServices)
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _instalacionEstadoServices = instalacionEstadoServices;
        }

        public void ActualizarInstalacion(InstalacionDTO instalacionDTO)
        {
            try
            {
                Instalacion inst;
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                using (var transaction = _db.Database.BeginTransaction())
                {

                    inst = GetInstalacionById((int)instalacionDTO.Id);

                    inst.Nombre = instalacionDTO.Nombre ?? inst.Nombre;
                    inst.Ubicacion = instalacionDTO.Ubicacion ?? inst.Ubicacion;
                    inst.Precio = instalacionDTO.Precio ?? inst.Precio;
                    inst.Condiciones = instalacionDTO.Condiciones ?? inst.Condiciones;
                    inst.HoraInicio = instalacionDTO.HoraInicio ?? inst.HoraInicio;
                    inst.HoraCierre = instalacionDTO.HoraCierre ?? inst.HoraCierre;

                    InstalacionHistorial instalacionHistorial = _db.InstalacionHistorial.Include(i => i.InstalacionEstado).Where(i => i.Instalacion.Id == instalacionDTO.Id && i.FechaFin == null).FirstOrDefault();

                    if (instalacionDTO.EstadoId != instalacionHistorial.InstalacionEstado.Id)
                    {
                        instalacionHistorial.FechaFin = DateTime.Now;
                        instalacionHistorial.UsuarioEditor = currentUser?.Id;
                        _db.InstalacionHistorial.Update(instalacionHistorial);

                        InstalacionHistorial historial = new InstalacionHistorial()
                        {
                            FechaInicio = DateTime.Now,
                            DetalleCambioEstado = "Se actualizó instalación",
                            UsuarioEditor = currentUser?.Id,
                            Instalacion = inst,
                            InstalacionEstado = _instalacionEstadoServices.GetInstalacionEstadoById(instalacionDTO.EstadoId) // asigno estado ACTIVO
                        };
                        _db.Add(historial);
                    }

                    _db.Instalacion.Update(inst);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void CrearInstalacion(InstalacionDTO instalacionDTO)
        {
            try
            {
                Instalacion instalacion = _mapper.Map<Instalacion>(instalacionDTO);
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");
                
                using (var transaction = _db.Database.BeginTransaction())
                {
                    InstalacionHistorial historial = new InstalacionHistorial()
                    {
                        FechaInicio = DateTime.Now,
                        DetalleCambioEstado = "Alta Instalacion",
                        UsuarioEditor = currentUser?.Id,
                        Instalacion = instalacion,
                        InstalacionEstado = _instalacionEstadoServices.GetInstalacionEstadoById(1) // asigno estado ACTIVO
                    };


                    _db.Add(historial);
                    _db.Add(instalacion);
                    _db.SaveChanges();
                    transaction.Commit();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void EliminarInstalacion(int id)
        {
            try
            {
                Instalacion instalacionAEliminar = GetInstalacionById(id);

                if (instalacionAEliminar == null)
                {
                    throw new Exception("No se encontró la instalación.");
                }

                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                using (var transaction = _db.Database.BeginTransaction())
                {
                    InstalacionHistorial instalacionEstado = _db.InstalacionHistorial.Include(i => i.InstalacionEstado).Where(i => i.Instalacion.Id == instalacionAEliminar.Id && i.FechaFin == null).FirstOrDefault();
                    instalacionEstado.FechaFin = DateTime.Now;
                    instalacionEstado.UsuarioEditor = currentUser?.Id;
                    _db.InstalacionHistorial.Update(instalacionEstado);

                    InstalacionHistorial nuevoHistorial = new InstalacionHistorial
                    {
                        DetalleCambioEstado = "Se elimina instalacion",
                        FechaInicio = DateTime.Now,
                        UsuarioEditor = currentUser?.Id,
                        Instalacion = instalacionAEliminar,
                        InstalacionEstado = _instalacionEstadoServices.GetInstalacionEstadoById(2) // asigno estado DESACTIVADO
                    };

                    _db.InstalacionHistorial.Add(nuevoHistorial);

                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteInstalacion(string nombre)
        {
            var inst = _db.Instalacion.FirstOrDefault(ee => ee.Nombre== nombre);
            if (inst == null)
            {
                return false;
            }
            return true;
        }

        public Instalacion GetInstalacionById(int Id)
        {
            try
            {
                Instalacion inst = _db.Instalacion.Find(Id);

                return inst;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Instalacion> GetInstalaciones()
        {
            try
            {
                return _db.Instalacion.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Instalacion> GetInstalacionesActivas()
        {
            try
            {
                List<Instalacion> listComp = _db.Instalacion.ToList();
                List<Instalacion> listFiltrada = new List<Instalacion>();

                foreach (var instalacion in listComp)
                {
                    InstalacionHistorial estado = _db.InstalacionHistorial.Where(i => i.InstalacionEstado.Id != 2 && i.FechaFin == null && i.Instalacion.Id==instalacion.Id).FirstOrDefault();
                    if (estado != null)
                    {
                        listFiltrada.Add(instalacion);
                    }
                }

                return listFiltrada;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}

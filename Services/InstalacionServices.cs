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
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IInstalacionEstadoServices _instalacionEstadoServices;

        public InstalacionServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, IInstalacionEstadoServices instalacionEstadoServices)
        {
            this._db = db;           
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

                    // obtengo ultimo historial y lo doy de baja
                    InstalacionHistorial? ultimoHistorial = inst.instalacionHistoriales.Where(ih => ih.FechaFin == null).FirstOrDefault();

                    if (ultimoHistorial != null)
                    {
                        ultimoHistorial.FechaFin = DateTime.Now;
                        _db.InstalacionHistorial.Update(ultimoHistorial);
                    }
                    else
                    {
                        inst.instalacionHistoriales = new List<InstalacionHistorial>();
                    }

                    // creo nuevo historial y lo asigno
                    InstalacionHistorial nuevoHistorial = new InstalacionHistorial
                    {
                        FechaInicio = DateTime.Now,
                        DetalleCambioEstado = "Se actualiza instalacion",
                        UsuarioEditor = currentUser?.Id,
                        InstalacionEstado = _instalacionEstadoServices.GetInstalacionEstadoById(instalacionDTO.EstadoId) // asigno estado ACTIVO
                    };

                    inst.instalacionHistoriales.Add(nuevoHistorial);

                    _db.InstalacionHistorial.Add(nuevoHistorial);
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
                        InstalacionEstado = _instalacionEstadoServices.GetInstalacionEstadoById(1) // asigno estado ACTIVO
                    };

                    instalacion.instalacionHistoriales = new List<InstalacionHistorial>();
                    instalacion.instalacionHistoriales.Add(historial);

                    _db.InstalacionHistorial.Add(historial);
                    _db.Instalacion.Add(instalacion);
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
                    // obtengo ultimo historial y lo doy de baja
                    InstalacionHistorial? ultimoHistorial = instalacionAEliminar.instalacionHistoriales.Where(ih => ih.FechaFin == null).FirstOrDefault();

                    if (ultimoHistorial != null)
                    {
                        ultimoHistorial.FechaFin = DateTime.Now;                        
                        _db.InstalacionHistorial.Update(ultimoHistorial);
                    }
                    else
                    {
                        instalacionAEliminar.instalacionHistoriales = new List<InstalacionHistorial>();
                    }                    

                    InstalacionHistorial nuevoHistorial = new InstalacionHistorial
                    {
                        DetalleCambioEstado = "Se elimina instalacion",
                        FechaInicio = DateTime.Now,
                        UsuarioEditor = currentUser?.Id,
                        InstalacionEstado = _instalacionEstadoServices.GetInstalacionEstadoById(2) // asigno estado DESACTIVADO
                    };

                    instalacionAEliminar.instalacionHistoriales.Add(nuevoHistorial);

                    _db.InstalacionHistorial.Add(nuevoHistorial);
                    _db.Instalacion.Update(instalacionAEliminar);
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
                Instalacion inst = _db.Instalacion.Include(h=>h.instalacionHistoriales).Where(i=>i.Id==Id).FirstOrDefault();

                return inst;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<InstalacionResponseDTO> GetInstalaciones()
        {
            try
            {
                List<Instalacion> instalaciones = _db.Instalacion.Include(ih=>ih.instalacionHistoriales).ThenInclude(ie=>ie.InstalacionEstado).ToList();

                List<InstalacionResponseDTO> response = new List<InstalacionResponseDTO>();

                foreach (var item in instalaciones)
                {
                    // obtengo ultimo historial
                    InstalacionHistorial? instalacionHistorial = item.instalacionHistoriales.Where(f=>f.FechaFin == null).OrderByDescending(f=>f.FechaInicio).FirstOrDefault();

                    bool activo = false;

                    if (instalacionHistorial != null && (instalacionHistorial?.InstalacionEstado.NombreEstado == Enums.EstadoInstalacion.Abierta.ToString() || instalacionHistorial?.InstalacionEstado.NombreEstado == Enums.EstadoInstalacion.Activo.ToString()))
                    {
                        activo = true;
                    }

                    InstalacionResponseDTO instalacionResponse = new InstalacionResponseDTO 
                    {
                        instalacion = item,
                        Activo = activo
                    };

                    response.Add(instalacionResponse);
                }

                return response;
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
                List<Instalacion> instalaciones = _db.Instalacion.Include(ih => ih.instalacionHistoriales).ThenInclude(ie => ie.InstalacionEstado).ToList();

                List<Instalacion> instalacionesActivas = instalaciones.Where(i => i.instalacionHistoriales.Any(h => h.FechaFin == null && (h.InstalacionEstado.NombreEstado == Enums.EstadoInstalacion.Activo.ToString() || h.InstalacionEstado.NombreEstado == Enums.EstadoInstalacion.Abierta.ToString()))).ToList();

                return instalacionesActivas;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}

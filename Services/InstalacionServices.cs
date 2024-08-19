using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Reservas;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using AutoMapper;
using XAct.Library.Settings;

namespace ApiNet8.Services
{
    public class InstalacionServices : IInstalacionServices
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public InstalacionServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        Instalacion IInstalacionServices.ActualizarInstalacion(InstalacionDTO instalacionDTO)
        {
            throw new NotImplementedException();
        }

        Instalacion IInstalacionServices.CrearInstalacion(InstalacionDTO instalacionDTO)
        {
            throw new NotImplementedException();
        }

        Instalacion IInstalacionServices.EliminarInstalacion(int id)
        {
            throw new NotImplementedException();
        }

        bool IInstalacionServices.ExisteInstalacion(string nombre)
        {
            throw new NotImplementedException();
        }

        Instalacion IInstalacionServices.GetInstalacionById(int Id)
        {
            throw new NotImplementedException();
        }

        List<Instalacion> IInstalacionServices.GetInstalaciones()
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

        List<Instalacion> IInstalacionServices.GetInstalacionesActivas()
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

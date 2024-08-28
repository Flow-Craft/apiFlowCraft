using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Reservas;
using ApiNet8.Services.IServices;
using AutoMapper;
using XAct.Library.Settings;

namespace ApiNet8.Services
{
    public class InstalacionEstadoServices : IInstalacionEstadoServices
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;

        public InstalacionEstadoServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper)
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
        }

        InstalacionEstado IInstalacionEstadoServices.ActualizarInstalacionEstado(InstalacionEstadoDTO instalacionEstadoDTO)
        {
            throw new NotImplementedException();
        }

        InstalacionEstado IInstalacionEstadoServices.CrearInstalacionEstado(InstalacionEstadoDTO instalacionEstadoDTO)
        {
            throw new NotImplementedException();
        }

        InstalacionEstado IInstalacionEstadoServices.EliminarInstalacionEstado(int id)
        {
            throw new NotImplementedException();
        }

        bool IInstalacionEstadoServices.ExisteInstalacionEstado(string nombre)
        {
            throw new NotImplementedException();
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

        List<InstalacionEstado> IInstalacionEstadoServices.GetInstalacionEstados()
        {
            throw new NotImplementedException();
        }
    }
}

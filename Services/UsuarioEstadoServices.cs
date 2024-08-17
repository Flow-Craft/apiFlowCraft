using ApiNet8.Data;
using ApiNet8.Models;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using XAct;
using XAct.Library.Settings;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiNet8.Services
{
    public class UsuarioEstadoServices : IUsuarioEstadoServices
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;
        public UsuarioEstadoServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper)
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
        }

        public UsuarioEstado ActualizarUsuarioEstado(UsuarioEstadoDTO usEst)
        {
            try
            {

                UsuarioEstado usuarioEstado = GetUsuarioEstadoById(usEst.Id);

                if (usuarioEstado.NombreEstado != usEst.NombreEstado)
                {
                    var existeEstado = ExisteUsuarioEstado(usEst.NombreEstado);
                    if (existeEstado)
                    {
                        throw new Exception("Ya existe un estado con ese nombre");
                    }
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    usuarioEstado.NombreEstado = usEst.NombreEstado;
                    usuarioEstado.DescripcionEstado = usEst.DescripcionEstado;
                    usuarioEstado.FechaModificacion = DateTime.Now;
                    usuarioEstado.UsuarioEditor = usEst.UsuarioEditor;
                    _db.Update(usuarioEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }

                return usuarioEstado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e);
            }
        }

        public UsuarioEstado CrearUsuarioEstado(UsuarioEstadoDTO usuarioEstado)
        {
            try
            {
                var existeEstado = ExisteUsuarioEstado(usuarioEstado.NombreEstado);
                if (existeEstado)
                {
                    throw new Exception("Ya existe un estado con ese nombre");
                }

                UsuarioEstado estUs = _mapper.Map<UsuarioEstado>(usuarioEstado);
                estUs.FechaCreacion = DateTime.Now;
                _db.Add(estUs);
                _db.SaveChanges();
                return estUs;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

        public UsuarioEstado EliminarUsuarioEstado(int id, JwtToken currentUserJwt)
        {
            try
            {
                UsuarioEstado usuarioEstado = this.GetUsuarioEstadoById(id);
                using (var transaction = _db.Database.BeginTransaction())
                {
                    usuarioEstado.FechaBaja = DateTime.Now;
                    usuarioEstado.UsuarioEditor = currentUserJwt.Id;
                    _db.Update(usuarioEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }
                return usuarioEstado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

        public bool ExisteUsuarioEstado(string nombre)
        {
            var usuarioEst = _db.UsuarioEstado.FirstOrDefault(ue => ue.NombreEstado == nombre);
            if (usuarioEst == null)
            {
                return false;
            }
            return true;
        }

        public UsuarioEstado GetUsuarioEstadoById(int Id)
        {
            try
            {
                UsuarioEstado usuarioEstado = _db.UsuarioEstado.Find(Id);

                return usuarioEstado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public EstadoSolicitudAsociacion GetEstadoSolicitudAsociacion(int Id)
        {
            try
            {
                EstadoSolicitudAsociacion estadoSolicitudAsociacion = _db.EstadoSolicitudAsociacion.Find(Id);

                return estadoSolicitudAsociacion;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public List<UsuarioEstado> GetUsuarioEstados()
        {
            try
            {
                return _db.UsuarioEstado.Where(p => p.FechaBaja == null).ToList();// podriamos devolverlos ordenados por id
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

    }
}

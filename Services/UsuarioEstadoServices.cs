using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
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
        public UsuarioEstadoServices(ApplicationDbContext db)
        {
            this._db = db;
        }

        UsuarioEstado IUsuarioEstadoServices.ActualizarUsuarioEstado(UsuarioEstadoDTO usEst)
        {
            try
            {
                UsuarioEstado usuarioEstado;
                using (var transaction = _db.Database.BeginTransaction())
                {
                    usuarioEstado = ((IUsuarioEstadoServices)this).GetUsuarioEstadoById(usEst.Id);
                    usuarioEstado.NombreEstado = usEst.NombreEstado;
                    usuarioEstado.DescripcionEstado = usEst.DescripcionEstado;
                    usuarioEstado.FechaModificacion = DateTime.Now;
                    usuarioEstado.UsuarioEditor = usEst.UsuarioEditor;//Implementar CurrentUser
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

        UsuarioEstado IUsuarioEstadoServices.CrearUsuarioEstado(UsuarioEstado usuarioEstado)
        {
            try
            {
                usuarioEstado.FechaCreacion = DateTime.Now;
                _db.Add(usuarioEstado);
                _db.SaveChanges();
                return usuarioEstado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

        UsuarioEstado IUsuarioEstadoServices.EliminarUsuarioEstado(int id)
        {
            try
            {
                UsuarioEstado usuarioEstado = ((IUsuarioEstadoServices)this).GetUsuarioEstadoById(id);
                using (var transaction = _db.Database.BeginTransaction())
                {
                    usuarioEstado.FechaBaja = DateTime.Now;
                    //usuarioEstado.UsuarioEditor = Current.User.Id;
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

        bool IUsuarioEstadoServices.ExisteUsuarioEstado(string nombre)
        {
            var usuarioEst = _db.UsuarioEstado.FirstOrDefault(ue => ue.NombreEstado == nombre);
            if (usuarioEst == null)
            {
                return false;
            }
            return true;
        }

        UsuarioEstado IUsuarioEstadoServices.GetUsuarioEstadoById(int Id)
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


        List<UsuarioEstado> IUsuarioEstadoServices.GetUsuarioEstados()
        {
            try
            {
                return _db.UsuarioEstado.ToList();// podriamos devolverlos ordenados por id
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

    }
}

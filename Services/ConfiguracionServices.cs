using ApiNet8.Data;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ApiNet8.Services
{
    public class ConfiguracionServices : IConfiguracionServices
    {
        private readonly ApplicationDbContext _db;
        public ConfiguracionServices(ApplicationDbContext db)
        {
            this._db = db;
        }
        Perfil IConfiguracionServices.ActualizarPerfil(Perfil perfil)
        {
            throw new NotImplementedException();
        }

        Perfil IConfiguracionServices.CrearPerfil(Perfil perfil)
        {
            try
            {
                _db.Add(perfil);
                // para probar descomentar la siguiente linea
                // throw new Exception("333");
                _db.SaveChanges();
                return perfil;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            
        }

        Perfil IConfiguracionServices.EliminarPerfil(Perfil perfil)
        {
            throw new NotImplementedException();
        }

        bool IConfiguracionServices.ExistePerfil(string nombre)
        {
            throw new NotImplementedException();
        }

        Perfil IConfiguracionServices.GetPerfilById(int Id)
        {
            try
            {
                // en el filter action ya verificamos que el id es valido y que el perfil existe, la unica validacion que hacemos aca es por si rompe el llamado a la base
                Perfil perfil = _db.Perfil.Find(Id);
                               
                return perfil;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        List<Perfil> IConfiguracionServices.GetPerfiles()
        {
            return _db.Perfil.ToList();
        }

        List<Permiso> IConfiguracionServices.GetPermisosByPerfil(Perfil perfil)
        {
            throw new NotImplementedException();
        }
    }
}

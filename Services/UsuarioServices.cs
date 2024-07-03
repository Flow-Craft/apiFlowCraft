using ApiNet8.Data;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Identity;

namespace ApiNet8.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly ApplicationDbContext db;
        private readonly PasswordHasher<Usuario> _passwordHasher;

        public UsuarioServices(ApplicationDbContext db)
        {
            _passwordHasher = new PasswordHasher<Usuario>();
            this.db = db;
        }

        public List<Usuario> GetUsuarios()
        {
            return db.Usuario.ToList();
        }

        public Usuario GetUsuarioById(int id)
        {
            try
            {
                Usuario? usuario = db.Usuario.Find(id);

                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario CrearUsuario(Usuario usuario)
        {
            // Hash de la contraseña
            usuario.Contrasena = _passwordHasher.HashPassword(usuario, usuario.Contrasena);

            db.Add(usuario);
            db.SaveChanges();          

            return usuario;
        }

        public bool VerificarContraseña(Usuario usuario, string contrasena)
        {
            var result = _passwordHasher.VerifyHashedPassword(usuario, usuario.Contrasena, contrasena);
            return result == PasswordVerificationResult.Success;
        }

        bool IUsuarioServices.ExisteUsuario(string usuario)
        {
            throw new NotImplementedException();
        }
    }
}



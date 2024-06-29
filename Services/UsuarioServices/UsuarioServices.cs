using ApiNet8.Models.Usuario;
using Microsoft.AspNetCore.Identity;

namespace ApiNet8.Services.UsuarioServices
{
    public class UsuarioServices
    {
        private readonly PasswordHasher<Usuario> _passwordHasher;

        public UsuarioServices()
        {
            _passwordHasher = new PasswordHasher<Usuario>();
        }

        public Usuario CrearUsuario(string nombre, string contrasena)
        {
            var usuario = new Usuario
            {
                Nombre = nombre
            };

            // Hash de la contraseña
            usuario.Contrasena = _passwordHasher.HashPassword(usuario, contrasena);

            // Aquí debes guardar el usuario en la base de datos
            // Ejemplo: _context.Usuarios.Add(usuario);
            // await _context.SaveChangesAsync();

            return usuario;
        }

        public bool VerificarContraseña(Usuario usuario, string contrasena)
        {
            var result = _passwordHasher.VerifyHashedPassword(usuario, usuario.Contrasena, contrasena);
            return result == PasswordVerificationResult.Success;
        }
    }
}



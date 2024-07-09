using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using XSystem.Security.Cryptography;

namespace ApiNet8.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly ApplicationDbContext db;
        private readonly PasswordHasher<Usuario> _passwordHasher;
        private string secretToken;

        public UsuarioServices(ApplicationDbContext db, IConfiguration configuration)
        {
            _passwordHasher = new PasswordHasher<Usuario>();
            this.db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken");
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
            try
            {
                // Hash de la contraseña
                usuario.Contrasena = _passwordHasher.HashPassword(usuario, usuario.Contrasena);

                db.Add(usuario);
                db.SaveChanges();

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            
        }

        public bool VerificarContraseña(Usuario usuario, string contrasena)
        {
            var result = _passwordHasher.VerifyHashedPassword(usuario, usuario.Contrasena, contrasena);
            return result == PasswordVerificationResult.Success;
        }

        public bool ExisteUsuario(UsuarioRegistroDTO usuario)
        {
            var usuarioBd = db.Usuario.FirstOrDefault(u => u.Email == usuario.Email || u.Dni == usuario.Dni);
            if (usuarioBd == null)
            {
                return true;
            }
            return false;
        }

       public async Task<Usuario> Login(UsuarioLoginDTO usuarioLoginDTO)
        {
            var passwordEncriptado = obtenermd5(usuarioLoginDTO.Contrasena);
            Usuario usuario = GetUsuarioByEmailAndPassword(usuarioLoginDTO.Email, passwordEncriptado);

            if (usuario == null)
            {
                throw new Exception("Usuario o contrasena incorrecta");
            }

            // jwt
            var token = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretToken);

            // se crea info que va a ir en el jwt y se setea la duracion
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, usuario.Email.ToString()),
                    new Claim(ClaimTypes.Name,usuario.Nombre)
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                // se firma el token con la clave secreta
                SigningCredentials = new (new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var jwt = token.CreateToken(tokenDescriptor);

            usuario.DeporteFavorito = token.WriteToken(jwt);// guardar jwt en una cookie o en sesion

            return usuario;

        }

        public async Task<Usuario> Registro(UsuarioRegistroDTO usuarioRegistroDTO)
        {
            try
            {
                var existeUsuario = ExisteUsuario(usuarioRegistroDTO);

                if (existeUsuario)
                {
                    throw new Exception("Ya existe un usuario con ese email o dni");
                }

                var passwordEncriptado = obtenermd5(usuarioRegistroDTO.Contrasena);

                Usuario usuario = new Usuario
                {
                    Nombre = usuarioRegistroDTO.Nombre,
                    Apellido = usuarioRegistroDTO.Apellido,
                    Contrasena = passwordEncriptado,
                    Direccion = usuarioRegistroDTO.Direccion,
                    Telefono = usuarioRegistroDTO.Telefono,
                    Dni = usuarioRegistroDTO.Dni,
                    Email = usuarioRegistroDTO.Email,
                    FechaAceptacionTYC = DateTime.Now,
                    FechaCambioContrasena = DateTime.Now,
                    FechaNacimiento = usuarioRegistroDTO.FechaNacimiento
                };

                db.Usuario.Add(usuario);
                await db.SaveChangesAsync();
                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message,e);
            }
          
        }

        //Método para encriptar contraseña con MD5 se usa tanto en el Acceso como en el Registro
        public static string obtenermd5(string valor)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.UTF8.GetBytes(valor);
            data = x.ComputeHash(data);
            string resp = "";
            for (int i = 0; i < data.Length; i++)
                resp += data[i].ToString("x2").ToLower();
            return resp;
        }

        public Usuario GetUsuarioByEmailAndPassword(string email, string password)
        {
            return db.Usuario.FirstOrDefault(u => u.Email == email && u.Contrasena == password);
        }
    }
}



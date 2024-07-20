using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using XAct.Library.Settings;
using XSystem.Security.Cryptography;

namespace ApiNet8.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly ApplicationDbContext _db;        
        private string secretToken;
        private readonly IMapper _mapper;

        public UsuarioServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper)
        {          
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
        }

        public List<Usuario> GetUsuarios()
        {
            return _db.Usuario.ToList();
        }

        public Usuario GetUsuarioById(int id)
        {
            try
            {
                return _db.Usuario.Find(id); 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public UsuarioDTO CrearUsuario(UsuarioDTO usuario)
        {
            try
            {
                //mapper de usuariodto a usuario
                Usuario user = _mapper.Map<Usuario>(usuario);

                // Hash de la contraseña
                var password = obtenermd5(user.Contrasena);
                user.Contrasena = password;

                _db.Add(user);
                _db.SaveChanges();

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            
        }

        public bool ExisteUsuario(UsuarioRegistroDTO usuario)
        {
            var usuarioBd = _db.Usuario.FirstOrDefault(u => u.Email == usuario.Email || u.Dni == usuario.Dni);
            if (usuarioBd == null)
            {
                return false;
            }
            return true;
        }

       public async Task<UsuarioLoginResponseDTO> Login(UsuarioLoginDTO usuarioLoginDTO)
        {
            var passwordEncriptado = obtenermd5(usuarioLoginDTO.Contrasena);
            Usuario usuario = await GetUsuarioByEmailAndPassword(usuarioLoginDTO.Email, passwordEncriptado);

            if (usuario == null)
            {
                throw new Exception("Usuario o contrasena incorrecta");
            }

            // jwt
            var token = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretToken);

            // Duración del token y la validación
            var tokenExpiry = DateTime.UtcNow.AddHours(1);
            var validationExpiry = DateTime.UtcNow.AddHours(2);

            // se crea info que va a ir en el jwt y se setea la duracion
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, usuario.Email.ToString()),
                    new Claim(ClaimTypes.Name,usuario.Nombre),
                    new Claim("validation_expiry", validationExpiry.ToString("o")) // ISO 8601 format
                }),
                Expires = tokenExpiry,
                // se firma el token con la clave secreta
                SigningCredentials = new (new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var jwt = token.CreateToken(tokenDescriptor);

            UsuarioDTO user = new UsuarioDTO
            {
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Email = usuario.Email,
                Id = usuario.Id,
                CodPostal = usuario.CodPostal,
                DeporteFavorito = usuario.DeporteFavorito,
                Direccion = usuario.Direccion,
                Telefono = usuario.Telefono,
                Dni = usuario.Dni,
                FechaNacimiento = usuario.FechaNacimiento,
                FotoPerfil = usuario.FotoPerfil,
                ImageType = usuario.ImageType,
                Pais = usuario.Pais,
                Provincia = usuario.Provincia,
                Localidad = usuario.Localidad,
                FechaAceptacionTYC = usuario.FechaAceptacionTYC,
                FechaCambioContrasena = usuario.FechaCambioContrasena
            };

            UsuarioLoginResponseDTO response = new UsuarioLoginResponseDTO
            {
                JwtToken = token.WriteToken(jwt),
                Usuario = user,
            };          

            return response;
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

                _db.Usuario.Add(usuario);
                await _db.SaveChangesAsync();
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

        public async Task<Usuario> GetUsuarioByEmailAndPassword(string email, string password)
        {
             return await _db.Usuario.FirstOrDefaultAsync(u => u.Email == email && u.Contrasena == password);
        }

        public Usuario ActualizarUsuario(UsuarioDTO usuario)
        {
            try
            {
                Usuario user;
                using (var transaction = _db.Database.BeginTransaction())
                {
                    user = GetUsuarioById((int)usuario.Id);
                    user.Nombre = usuario.Nombre;
                    user.Apellido = usuario.Apellido;
                    user.Direccion = usuario.Direccion;
                    user.Dni = usuario.Dni;
                    user.Email = usuario.Email;
                    user.FechaNacimiento = usuario.FechaNacimiento;
                    user.CodPostal = usuario.CodPostal ?? user.CodPostal;
                    user.DeporteFavorito = usuario.DeporteFavorito ?? user.DeporteFavorito;
                    user.FotoPerfil = usuario.FotoPerfil ?? user.FotoPerfil;
                    user.ImageType = usuario.ImageType ?? user.ImageType;
                    user.Pais = usuario.Pais ?? user.Pais;
                    user.Provincia = usuario.Provincia ?? user.Provincia;
                    user.Localidad = usuario.Localidad ?? user.Localidad;
                    _db.Update(user);
                    _db.SaveChanges();
                    transaction.Commit();
                }
                return user;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Usuario EliminarUsuario(int id)
        {
            throw new NotImplementedException();
            // se debe crear un usuario historial y asignarlo al usuario
            //try
            //{
            //    Usuario user = GetUsuarioById(id);
            //    using (var transaction = db.Database.BeginTransaction())
            //    {
                    
            //        _db.Update(user);
            //        _db.SaveChanges();
            //        transaction.Commit();
            //    }
            //    return user;
            //}
            //catch (Exception e)
            //{
            //    throw new Exception(e.Message, e);
            //}
        }
    }
}



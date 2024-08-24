using ApiNet8.Data;
using ApiNet8.Models;
using ApiNet8.Models.Club;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using XAct.Library.Settings;
using XAct.Users;
using XSystem.Security.Cryptography;

namespace ApiNet8.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly ApplicationDbContext _db;        
        private string secretToken;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUsuarioEstadoServices _usuarioEstadoServices;


        public UsuarioServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor, IUsuarioEstadoServices usuarioEstadoServices)
        {          
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            this._usuarioEstadoServices = usuarioEstadoServices;
        }

        public List<Usuario> GetUsuarios()
        {
            return _db.Usuario.ToList();
        }

        public Usuario? GetUsuarioById(int id)
        {
            try
            {
                return _db.Usuario
                    .Include(u => u.UsuarioHistoriales)
                    .Where(u => u.Id == id)
                    .FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void CrearUsuario(UsuarioDTO usuario)
        {
            try
            {
                //mapper de usuariodto a usuario
                Usuario user = _mapper.Map<Usuario>(usuario);

                // Hash de la contraseña
                var password = obtenermd5(user.Contrasena);
                user.Contrasena = password;

                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                // crear en la base
                using (var transaction = _db.Database.BeginTransaction())
                {
                    UsuarioHistorial historial = new UsuarioHistorial()
                    {
                        FechaInicio = DateTime.Now,
                        DetalleCambioEstado = "Crear usuario",
                        UsuarioEditor = currentUser?.Id,
                        UsuarioEstado = _usuarioEstadoServices.GetUsuarioEstadoById(1) // asigno estado ACTIVO
                    };

                   user.UsuarioHistoriales = new List<UsuarioHistorial>();            
                   user.UsuarioHistoriales.Add(historial);

                    _db.Add(historial);
                    _db.Add(user);                    
                    _db.SaveChanges();
                    transaction.Commit();
                }
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
                    new Claim("User_Email", usuario.Email.ToString()),
                    new Claim(ClaimTypes.Name,usuario.Nombre),
                    new Claim("User_Id",usuario.Id.ToString()),
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

                if (usuarioRegistroDTO.Sexo != "M" && usuarioRegistroDTO.Sexo != "H" && usuarioRegistroDTO.Sexo != "X")
                {
                    throw new Exception("Debe cargar un sexo válido para el usuario");
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
                    FechaNacimiento = usuarioRegistroDTO.FechaNacimiento,
                    Sexo = usuarioRegistroDTO.Sexo,
                    ImageType = usuarioRegistroDTO.ImageType ?? null,
                    FotoPerfil = usuarioRegistroDTO.FotoPerfil ?? [],
                    Pais = usuarioRegistroDTO.Pais ?? null,
                    Provincia = usuarioRegistroDTO.Provincia ?? null,
                    Localidad = usuarioRegistroDTO?.Localidad ?? null
                };

                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                // crear en la base
                using (var transaction = _db.Database.BeginTransaction())
                {
                    UsuarioHistorial historial = new UsuarioHistorial()
                    {
                        FechaInicio = DateTime.Now,
                        DetalleCambioEstado = "Registrar usuario",
                        UsuarioEditor = currentUser?.Id,
                        UsuarioEstado = _usuarioEstadoServices.GetUsuarioEstadoById(1) // asigno estado ACTIVO
                    };

                    usuario.UsuarioHistoriales = new List<UsuarioHistorial>();
                    usuario.UsuarioHistoriales.Add(historial);

                    _db.UsuarioHistorial.Add(historial);
                    _db.Usuario.Add(usuario);
                    await _db.SaveChangesAsync();
                    transaction.Commit();
                }
                // ver si debo obtener user de la base para ver id
                if (usuarioRegistroDTO.Socio)
                {
                    Asociarse(usuario);
                }
              
                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message,e);
            }
          
        }

        public void Asociarse(Usuario usuario)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                // se crea el historial
                SolicitudAsociacionHistorial nuevaSolicitudHistorial = new SolicitudAsociacionHistorial
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Usuario crea solicitud para asociarse",
                    UsuarioEditor = currentUser?.Id,
                    EstadoSolicitudAsociacion = _usuarioEstadoServices.GetEstadoSolicitudAsociacion(1)
                };

                List<SolicitudAsociacionHistorial> historial = new List<SolicitudAsociacionHistorial>();
                historial.Add(nuevaSolicitudHistorial);

                // se crea la solicitud con el historial de pendiente
                SolicitudAsociacion nuevaSolicitud = new SolicitudAsociacion
                {
                    Usuario = usuario,
                    SolicitudAsociacionHistoriales = historial
                };

                // crear en la base
                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.SolicitudAsociacionHistorial.Add(nuevaSolicitudHistorial);
                    _db.SolicitudAsociacion.Add(nuevaSolicitud);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
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

        public void ActualizarUsuario(UsuarioDTO usuario)
        {
            try
            {
                Usuario user;
              
                using (var transaction = _db.Database.BeginTransaction())
                {
                    // obtengo usuario a modificar y lo actualizo
                    user = GetUsuarioById((int)usuario.Id);                  

                    user.Nombre = usuario.Nombre ?? user.Nombre;
                    user.Apellido = usuario.Apellido ?? user.Apellido;
                    user.Direccion = usuario.Direccion ?? user.Direccion;
                    user.Dni = usuario.Dni ?? user.Dni;
                    user.Email = usuario.Email ?? user.Email;
                    user.FechaNacimiento = usuario.FechaNacimiento ?? user.FechaNacimiento;
                    user.CodPostal = usuario.CodPostal ?? user.CodPostal;
                    user.DeporteFavorito = usuario.DeporteFavorito ?? user.DeporteFavorito;
                    user.FotoPerfil = usuario.FotoPerfil ?? user.FotoPerfil;
                    user.ImageType = usuario.ImageType ?? user.ImageType;
                    user.Pais = usuario.Pais ?? user.Pais;
                    user.Provincia = usuario.Provincia ?? user.Provincia;
                    user.Localidad = usuario.Localidad ?? user.Localidad;
                    user.Telefono = usuario.Telefono ?? user.Telefono;

                    _db.Usuario.Update(user);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void EliminarUsuario(int id)
        {
            try
            {
                Usuario usuarioAEliminar = GetUsuarioById(id);

                if (usuarioAEliminar == null)
                {
                    throw new Exception("No se encontró el usuario.");
                }

                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                using (var transaction = _db.Database.BeginTransaction())
                {
                    if (usuarioAEliminar.UsuarioHistoriales.Count != 0 && usuarioAEliminar.UsuarioHistoriales.Any(a=>a.FechaFin == null))
                    {
                        // obtengo ultimo historial y lo doy de baja
                        UsuarioHistorial historialAnterior = usuarioAEliminar.UsuarioHistoriales.FirstOrDefault(u => u.FechaFin == null);
                        historialAnterior.FechaFin = DateTime.Now;
                        _db.UsuarioHistorial.Update(historialAnterior);
                    }                    

                    // se crea nuevo historial con estado desactivado
                    UsuarioHistorial nuevoHistorial = new UsuarioHistorial                    
                    { 
                        DetalleCambioEstado = "Se elimina usuario",
                        FechaInicio = DateTime.Now,
                        UsuarioEditor = currentUser?.Id,
                        UsuarioEstado = _usuarioEstadoServices.GetUsuarioEstadoById(3) // asigno estado DESACTIVADO
                    };

                    // se asigna el historial al usuario
                    usuarioAEliminar.UsuarioHistoriales.Add(nuevoHistorial);

                    
                    _db.UsuarioHistorial.Update(nuevoHistorial);
                    _db.Usuario.Update(usuarioAEliminar);

                    _db.SaveChanges();
                    transaction.Commit();                  
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public MiPerfilDTO GetMiPerfil()
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                if (currentUser.Id == null)
                {
                    throw new Exception("El id del usuario es nulo");
                }

                Usuario usuario = GetUsuarioById(currentUser.Id);

                if (usuario == null)
                {
                    throw new Exception("no se encontró un usuario con el id" + currentUser.Id);
                }

                //mapper de usuario a miperfildto
                MiPerfilDTO miPerfilDTO = _mapper.Map<MiPerfilDTO>(usuario);

                return miPerfilDTO;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}



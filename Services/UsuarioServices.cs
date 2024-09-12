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
        private readonly IEmailService _emailService;


        public UsuarioServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor, IUsuarioEstadoServices usuarioEstadoServices, IEmailService emailService)
        {          
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            this._usuarioEstadoServices = usuarioEstadoServices;
            _emailService = emailService;
        }

        public List<UsuarioDTO> GetUsuarios()
        {
            List <Usuario> ls = _db.Usuario.Include(h=>h.UsuarioHistoriales).ThenInclude(u=>u.UsuarioEstado).ToList();
            List <UsuarioDTO> listaUsuarios = new List<UsuarioDTO>();
            foreach (var item in ls)
            {
                //mapper de usuario a usuarioDTO
                UsuarioDTO user = _mapper.Map<UsuarioDTO>(item);

                // obtengo ultimo historial
                UsuarioHistorial? historial = item.UsuarioHistoriales.Where(f=>f.FechaFin==null).FirstOrDefault();
                if (historial != null) 
                {
                    user.Estado = historial.UsuarioEstado.NombreEstado;
                }
                listaUsuarios.Add(user);
            }
           
            return listaUsuarios;
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

            // verificar estado del usuario
            UsuarioEstado? estado = usuario.UsuarioHistoriales.FirstOrDefault(f => f.FechaFin == null).UsuarioEstado;
            if (estado == null || estado.Id == 2 || estado.Id == 3)
            {
                string mensajeError = "";

                if (estado == null)
                {
                    mensajeError = "El estado del usuario no está definido.";
                }
                else if (estado.Id == 2)
                {
                    mensajeError = "El usuario está bloqueado.";
                }
                else if (estado.Id == 3)
                {
                    mensajeError = "El usuario ha sido eliminado.";
                }

                throw new Exception(mensajeError); 
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

                // verifico si tiene algun historial anterior y lo doy de baja
                SolicitudAsociacion? solicitud = _db.SolicitudAsociacion
                .Include(u => u.Usuario)
                .Include(h => h.SolicitudAsociacionHistoriales).
                Where(s => s.Usuario.Id == usuario.Id
                && s.SolicitudAsociacionHistoriales.Any(sah => sah.FechaFin == null))
                .FirstOrDefault();

                SolicitudAsociacionHistorial solicitudAsociacionHistorialUltimo = null;

                if (solicitud != null)
                {
                    solicitudAsociacionHistorialUltimo = solicitud.SolicitudAsociacionHistoriales.Where(h => h.FechaFin == null).FirstOrDefault();
                    solicitudAsociacionHistorialUltimo.FechaFin = DateTime.Now;
                }


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
                    if (solicitudAsociacionHistorialUltimo != null)
                    {
                        _db.SolicitudAsociacionHistorial.Update(solicitudAsociacionHistorialUltimo);
                    }
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
             return await _db.Usuario.Include(e=>e.UsuarioHistoriales).ThenInclude(s=>s.UsuarioEstado).FirstOrDefaultAsync(u => u.Email == email && u.Contrasena == password);
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
                    user.Sexo = usuario.Sexo ?? user.Sexo;

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

                // verificar si el usuario es socio
                miPerfilDTO.mostrarBotonAsociarse = MostrarBotonAsociarse(usuario);

                return miPerfilDTO;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool MostrarBotonAsociarse(Usuario usuario)
        {
          // verificar que el usuario una solicitud aprobada o tenga una solicitud pendiente

        // verifico si tiene alguna solicitud de asociacion con un historial sin fecha fin, eso significa que tiene alguna solicitud con estado
         SolicitudAsociacion? solicitud = _db.SolicitudAsociacion
                .Include(u => u.Usuario)
                .Include(h=>h.SolicitudAsociacionHistoriales)
                .ThenInclude(h => h.EstadoSolicitudAsociacion).
                Where(s=> s.Usuario.Id == usuario.Id 
                && s.SolicitudAsociacionHistoriales.Any(sah=>sah.FechaFin==null))
                .FirstOrDefault();

            if (solicitud != null)
            {
                // verifico el estado de la ultima solicitud que tenga, si es aprobada o pendiente no muestro boton
                SolicitudAsociacionHistorial solicitudAsociacionHistorial = solicitud.SolicitudAsociacionHistoriales.Where(h => h.FechaFin == null).FirstOrDefault();
                if (solicitudAsociacionHistorial.EstadoSolicitudAsociacion.Id == 1 || solicitudAsociacionHistorial.EstadoSolicitudAsociacion.Id == 2)
                {
                    return false;
                }
            }

            return true;
        }

        //public void EditarMiPerfil(MiPerfilDTO miPerfilDTO)
        //{
        //    try
        //    {
        //        // Obtener el usuario actual desde la sesión
        //        var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

        //        if (currentUser?.Id == null)
        //        {
        //            throw new Exception("El id del usuario es nulo");
        //        }

        //        Usuario usuario = GetUsuarioById(currentUser.Id);

        //        if (usuario == null)
        //        {
        //            throw new Exception("no se encontró un usuario con el id" + currentUser.Id);
        //        }

        //        usuario.Apellido = miPerfilDTO.Apellido ?? usuario.Apellido;
        //        usuario.Telefono = miPerfilDTO.Telefono ?? usuario.Telefono;
        //        usuario.Direccion = miPerfilDTO.Direccion ?? usuario.Direccion;
        //        usuario.Email = miPerfilDTO.Email ?? usuario.Email;
        //        usuario.FechaNacimiento = miPerfilDTO.FechaNacimiento ?? usuario.FechaNacimiento;
        //        usuario.FotoPerfil = miPerfilDTO.FotoPerfil ?? usuario.FotoPerfil;
        //        usuario.Nombre = miPerfilDTO.Nombre ?? usuario.Nombre;
        //        usuario.Sexo = miPerfilDTO.Sexo ?? usuario.Sexo;

        //        using (var transaction = _db.Database.BeginTransaction())
        //        {
        //            if (usuario.UsuarioHistoriales.Count != 0 && usuario.UsuarioHistoriales.Any(a => a.FechaFin == null))
        //            {
        //                // obtengo ultimo historial y lo doy de baja
        //                UsuarioHistorial historialAnterior = usuario.UsuarioHistoriales.FirstOrDefault(u => u.FechaFin == null);
        //                historialAnterior.FechaFin = DateTime.Now;
        //                _db.UsuarioHistorial.Update(historialAnterior);
        //            }

        //            // se crea nuevo historial
        //            UsuarioHistorial nuevoHistorial = new UsuarioHistorial
        //            {
        //                DetalleCambioEstado = "Usuario actualiza datos",
        //                FechaInicio = DateTime.Now,
        //                UsuarioEditor = currentUser?.Id,
        //                UsuarioEstado = _usuarioEstadoServices.GetUsuarioEstadoById(1) // asigno estado ACTIVADO
        //            };

        //            // se asigna el historial al usuario
        //            usuario.UsuarioHistoriales.Add(nuevoHistorial);


        //            _db.UsuarioHistorial.Update(nuevoHistorial);    
        //            _db.Usuario.Update(usuario);
        //            _db.SaveChanges();
        //            transaction.Commit();
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message, e);
        //    }
        //}

        public void CambiarContrasena(string contrasena)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                if (currentUser?.Id == null)
                {
                    throw new Exception("El id del usuario es nulo");
                }

                Usuario usuario = GetUsuarioById(currentUser.Id);

                if (usuario == null)
                {
                    throw new Exception("no se encontró un usuario con el id" + currentUser.Id);
                }

                // hashear contrasena
                var passwordEncriptado = obtenermd5(contrasena);

                usuario.Contrasena = passwordEncriptado;

                using (var transaction = _db.Database.BeginTransaction())
                {
                    if (usuario.UsuarioHistoriales.Count != 0 && usuario.UsuarioHistoriales.Any(a => a.FechaFin == null))
                    {
                        // obtengo ultimo historial y lo doy de baja
                        UsuarioHistorial historialAnterior = usuario.UsuarioHistoriales.FirstOrDefault(u => u.FechaFin == null);
                        historialAnterior.FechaFin = DateTime.Now;
                        _db.UsuarioHistorial.Update(historialAnterior);
                    }

                    // se crea nuevo historial
                    UsuarioHistorial nuevoHistorial = new UsuarioHistorial
                    {
                        DetalleCambioEstado = "Usuario cambia contrasena",
                        FechaInicio = DateTime.Now,
                        UsuarioEditor = currentUser?.Id,
                        UsuarioEstado = _usuarioEstadoServices.GetUsuarioEstadoById(1) // asigno estado ACTIVADO
                    };

                    // se asigna el historial al usuario
                    usuario.UsuarioHistoriales.Add(nuevoHistorial);

                    _db.UsuarioHistorial.Update(nuevoHistorial);
                    _db.Usuario.Update(usuario);
                    _db.SaveChanges();
                    transaction.Commit();
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Usuario? ExisteUsuarioActivobyEmail (string email)
        {
            // obtener usuario
            Usuario? usuario = _db.Usuario.Include(u => u.UsuarioHistoriales).ThenInclude(e => e.UsuarioEstado).Where(u => u.Email == email).FirstOrDefault();

            // obtener ultimo historial del usuario
            UsuarioHistorial? ultimoHistorial = usuario?.UsuarioHistoriales.Where(f => f.FechaFin == null).FirstOrDefault();

            if (ultimoHistorial !=null && ultimoHistorial.UsuarioEstado.Id == 1) // verifico que tenga historial y que el estado sea activo
            {
                return usuario;
            }

            return null;
        }

        public async Task<bool> ReestablecerContrasenaInit(string mail)
        {
            try
            {
                // buscar si el mail pertenece a un usuario activo
                Usuario usuario = ExisteUsuarioActivobyEmail(mail);

                if (usuario == null) 
                {
                    throw new Exception("No existe un usuario activo para el mail ingresado.");
                }

                // creo codigo de verificacion y lo guardo en una instancia de codigo y lo asocio al usuario
                if (usuario != null)
                {
                    Random random = new Random();
                    int numeroAleatorio = random.Next(100000, 1000000);

                    CodigoVerificacion codigoVerificacion = new CodigoVerificacion
                    {
                        FechaCreacion = DateTime.Now,
                        FechaExpiracion = DateTime.Now.AddMinutes(15),
                        Codigo = numeroAleatorio.ToString(),
                        Usuario = usuario
                    };


                    using (var transaction = _db.Database.BeginTransaction())
                    {
                        _db.Add(codigoVerificacion);
                        _db.SaveChanges();;
                        transaction.Commit();
                    }

                    // envio mail al usuario con el codigo
                    await _emailService.SendEmailAsync(mail, "Código de verificación", "Tu código de verificación es: " + codigoVerificacion.Codigo);
                    return true;
                }

                return false;
               
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public bool VerificarCodigo (VerificarCodigoDTO verificarCodigoDTO)
        {
            // obtener usuario con mail
            Usuario? usuario = ExisteUsuarioActivobyEmail(verificarCodigoDTO.Mail);

            // obtener instancia de codigoVerificacion asociada a ese usuario que este vigente y sea la ultima creada
            CodigoVerificacion? codigo = null;
            if (usuario != null)
            {
                codigo = _db.CodigoVerificacion.Include(u => u.Usuario).Where(c => c.Usuario.Id == usuario.Id && c.FechaExpiracion > DateTime.Now).OrderByDescending(c => c.FechaCreacion).FirstOrDefault();
            }

            if (codigo == null)
            {
                throw new Exception("Código expirado");
            }

            // verificar si el codigo es correcto
            if (codigo.Codigo == verificarCodigoDTO.Codigo)
            {
                return true;
            }

            return false;
        }

        public void ReestablecerContrasena(ReestablecerContrasenaDTO reestablecerContrasenaDTO)
        {
            try
            {
                // encriptar contraseña
                var passwordEncriptado = obtenermd5(reestablecerContrasenaDTO.NuevaPassword);

                // obtener usuario
                Usuario? usuario = ExisteUsuarioActivobyEmail(reestablecerContrasenaDTO.Mail);

                if (usuario != null)
                {
                    // verificar si para ese usuario existe un codigo de verificacion asociado igual al recibido
                    VerificarCodigoDTO verificarCodigoDTO = new VerificarCodigoDTO 
                    { 
                        Mail = reestablecerContrasenaDTO.Mail,
                        Codigo = reestablecerContrasenaDTO.Codigo
                    };
                    bool verificacionCodigo = VerificarCodigo(verificarCodigoDTO);

                    if (verificacionCodigo) 
                    {
                        usuario.Contrasena = passwordEncriptado;

                        using (var transaction = _db.Database.BeginTransaction())
                        {
                            _db.Update(usuario);
                            _db.SaveChanges(); ;
                            transaction.Commit();
                        }
                    }                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        public List<SolicitudAsociacion> GetSolicitudesAsociacionDb()
        {
            return _db.SolicitudAsociacion.Include(u=>u.Usuario).Include(h => h.SolicitudAsociacionHistoriales)
                .ThenInclude(e => e.EstadoSolicitudAsociacion).ToList();           
        }

        public List<SolicitudAsociacionDTO> GetSolicitudesAsociacion()
        {
            List<SolicitudAsociacion> solicitudes = GetSolicitudesAsociacionDb();

           return SolicitudesAsociacionMapper(solicitudes);
        }

        public List<SolicitudAsociacionDTO> SolicitudesAsociacionMapper(List<SolicitudAsociacion> solicitudes)
        {
            List<SolicitudAsociacionDTO> solicitudesDTO = new List<SolicitudAsociacionDTO>();
            foreach (var item in solicitudes)
            {
                // obtengo ultimo historial
                SolicitudAsociacionHistorial historial = item.SolicitudAsociacionHistoriales.Where(f => f.FechaFin == null)?.FirstOrDefault();
                //mapper de usuariodto a usuario
                SolicitudAsociacionDTO solicitud = new SolicitudAsociacionDTO
                {
                    Id = item.Id,
                    Nombre = item.Usuario.Nombre,
                    Apellido = item.Usuario.Apellido,
                    Dni = item.Usuario.Dni,
                    EMail = item.Usuario.Email,
                    FechaCreacion = historial?.FechaInicio ?? null,
                    MotivoRechazo = item.MotivoRechazo,
                    Estado = historial?.EstadoSolicitudAsociacion?.NombreEstado ?? ""
                };
                solicitudesDTO.Add(solicitud);
            }

            return solicitudesDTO;
        }

        public List<SolicitudAsociacionDTO> GetSolicitudesAsociacionFiltro(int id)
        {
            // obtengo todas las solicitudes
            List<SolicitudAsociacion> solicitudes = GetSolicitudesAsociacionDb();

            // filtro las solicitudes segun el filtro
            List<SolicitudAsociacion> solicitudesFiltradas = solicitudes
            .Where(h => h.SolicitudAsociacionHistoriales
            .Any(a => a.FechaFin == null && a.EstadoSolicitudAsociacion == _usuarioEstadoServices.GetEstadoSolicitudAsociacion(id))
            ).ToList();

            // mapeo las solicitudes
            return SolicitudesAsociacionMapper(solicitudesFiltradas);
        }

        public void BloquearUsuario(BloquearUsuarioDTO bloquearUsuarioDTO)
        {
            try
            {
                Usuario usuarioABloquear = GetUsuarioById(bloquearUsuarioDTO.Id);

                if (usuarioABloquear == null)
                {
                    throw new Exception("No se encontró el usuario.");
                }

                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                using (var transaction = _db.Database.BeginTransaction())
                {
                    if (usuarioABloquear.UsuarioHistoriales.Count != 0 && usuarioABloquear.UsuarioHistoriales.Any(a => a.FechaFin == null))
                    {
                        // obtengo ultimo historial y lo doy de baja
                        UsuarioHistorial historialAnterior = usuarioABloquear.UsuarioHistoriales.FirstOrDefault(u => u.FechaFin == null);
                        historialAnterior.FechaFin = DateTime.Now;
                        _db.UsuarioHistorial.Update(historialAnterior);
                    }

                    // se crea nuevo historial con estado desactivado
                    UsuarioHistorial nuevoHistorial = new UsuarioHistorial
                    {
                        DetalleCambioEstado = bloquearUsuarioDTO.Razon,
                        FechaInicio = DateTime.Now,
                        UsuarioEditor = currentUser?.Id,
                        UsuarioEstado = _usuarioEstadoServices.GetUsuarioEstadoById(2) // asigno estado Bloqueado
                    };

                    // se asigna el historial al usuario
                    usuarioABloquear.UsuarioHistoriales.Add(nuevoHistorial);


                    _db.UsuarioHistorial.Update(nuevoHistorial);
                    _db.Usuario.Update(usuarioABloquear);

                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void DesbloquearUsuario(BloquearUsuarioDTO bloquearUsuarioDTO)
        {
            try
            {
                Usuario usuarioABloquear = GetUsuarioById(bloquearUsuarioDTO.Id);

                if (usuarioABloquear == null)
                {
                    throw new Exception("No se encontró el usuario.");
                }

                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                using (var transaction = _db.Database.BeginTransaction())
                {
                    if (usuarioABloquear.UsuarioHistoriales.Count != 0 && usuarioABloquear.UsuarioHistoriales.Any(a => a.FechaFin == null))
                    {
                        // obtengo ultimo historial y lo doy de baja
                        UsuarioHistorial historialAnterior = usuarioABloquear.UsuarioHistoriales.FirstOrDefault(u => u.FechaFin == null);
                        historialAnterior.FechaFin = DateTime.Now;
                        _db.UsuarioHistorial.Update(historialAnterior);
                    }

                    // se crea nuevo historial con estado desactivado
                    UsuarioHistorial nuevoHistorial = new UsuarioHistorial
                    {
                        DetalleCambioEstado = bloquearUsuarioDTO.Razon,
                        FechaInicio = DateTime.Now,
                        UsuarioEditor = currentUser?.Id,
                        UsuarioEstado = _usuarioEstadoServices.GetUsuarioEstadoById(1) // asigno estado ACTIVO
                    };

                    // se asigna el historial al usuario
                    usuarioABloquear.UsuarioHistoriales.Add(nuevoHistorial);


                    _db.UsuarioHistorial.Update(nuevoHistorial);
                    _db.Usuario.Update(usuarioABloquear);

                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

        //public void AceptarTermYCond(Usuario usu)
        //{
        //    try
        //    {

        //        using (var transaction = _db.Database.BeginTransaction())
        //        {

        //            instEst.NombreEstado = instalacionEstadoDTO.NombreEstado ?? instEst.NombreEstado;
        //            instEst.DescripcionEstado = instalacionEstadoDTO.DescripcionEstado ?? instEst.DescripcionEstado;
        //            instEst.FechaModificacion = DateTime.Now;
        //            instEst.UsuarioEditor = currentUser.Id;
        //            _db.Update(instEst);
        //            _db.SaveChanges();
        //            transaction.Commit();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message, e);
        //    }
        //}
    }
}



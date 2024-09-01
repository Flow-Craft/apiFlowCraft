using ApiNet8.Filters.ActionFilters;
using ApiNet8.Models;
using ApiNet8.Models.Club;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Partidos;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services;
using ApiNet8.Services.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNet8.Controllers
{ 
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : CustomController
    {
        private const string JWT = "JWT";
        private const string CurrentUserJWT = "CurrentUserJWT";
        
        private readonly IUsuarioServices _usuarioServices;
        private readonly IEmailService _emailService;

        public UsersController(IUsuarioServices usuarioServices, IEmailService emailService)
        {
            _usuarioServices = usuarioServices;
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendMailTest([FromBody] EmailRequestDTO emailRequest)
        {
            await _emailService.SendEmailAsync(emailRequest.ToEmail, emailRequest.Subject, emailRequest.Body);
            return Ok("Email sent successfully!");
        }

        #region Usuario
        // obtener usuarios
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetUsuarios()
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                List<Usuario> partidos = _usuarioServices.GetUsuarios();
                return Ok(partidos);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al obtener usuarios",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        // obtener usuario con id
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [TypeFilter(typeof(ValidateIdFilterAttribute))]
        [EntityType(typeof(Usuario))] // Aquí se especifica el tipo de entidad
        [HttpGet("{id}")]
        [HttpGet]
        public IActionResult GetUsuario(int id)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                Usuario usuario = _usuarioServices.GetUsuarioById(id);

                if (usuario == null)
                {
                    var problemDetails = new ValidationProblemDetails() { Status = StatusCodes.Status404NotFound, Title = "Usuario no encontrado" };

                    return new NotFoundObjectResult(problemDetails);
                }

                return Ok(usuario);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al obtener usuario con id: " + id,
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }


        }

        // crear usuario
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult CrearUsuario([FromBody] UsuarioDTO usuario)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            if (usuario == null)
            {
                return BadRequest("Usuario es nulo");
            }

            try
            {
                _usuarioServices.CrearUsuario(usuario);

                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al crear usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        // Registrar usuario        
        [HttpPost]
        public async Task<IActionResult> Registro([FromBody] UsuarioRegistroDTO usuarioRegistroDTO)
        {
            if (usuarioRegistroDTO == null)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.BadRequest,
                    title = "El usuario es nulo",
                    errors = new List<string> { }
                };
                return BadRequest(respuestaAPI);
            }

            try
            {
                var usuario = await _usuarioServices.Registro(usuarioRegistroDTO);

                return Ok(usuario);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = e.Message == "Ya existe un usuario con ese email o dni" ? HttpStatusCode.BadRequest : HttpStatusCode.InternalServerError,
                    title = "Error al registrar usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        // login de un usuario
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UsuarioLoginDTO usuarioLoginDTO)
        {
            try
            {
                var login = await _usuarioServices.Login(usuarioLoginDTO);

                Response.Headers.Append(JWT, login.JwtToken);


                HttpContext.Session.SetString("pruebaKey", "holaaaaaa");

                // creo el current user para guardar en session
                CurrentUser currentUser = new CurrentUser
                {
                    Id = (int)login.Usuario.Id,
                    Email = login.Usuario.Email,
                    Name = login.Usuario.Nombre
                };
                SetCurrentUser(currentUser);

                return Ok(login.Usuario);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = e.Message == "Usuario o contrasena incorrecta" ? HttpStatusCode.BadRequest : HttpStatusCode.InternalServerError,
                    title = "Error en login",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult ActualizarUsuario([FromBody] UsuarioDTO usuario)
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _usuarioServices.ActualizarUsuario(usuario);
                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al actualizar usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult EliminarUsuario(int id)
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _usuarioServices.EliminarUsuario(id);
                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al eliminar usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }
        #endregion
                
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]        
        [HttpGet]
        public IActionResult GetMiPerfil()
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                MiPerfilDTO miPerfilDTO = _usuarioServices.GetMiPerfil();
                               
                return Ok(miPerfilDTO);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al obtener el perfil del usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult EditarMiPerfil(MiPerfilDTO miPerfilDTO)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _usuarioServices.EditarMiPerfil(miPerfilDTO);

                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al editar el perfil del usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }


        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult DarseDeBaja()
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                CurrentUser currentUser = GetCurrentUser();
                
                _usuarioServices.EliminarUsuario(currentUser.Id);
                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al dar de baja usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult AsociarseMiPerfil()
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);
            try
            {
                CurrentUser currentUser = GetCurrentUser();
                Usuario usuario = _usuarioServices.GetUsuarioById(currentUser.Id);

                if (usuario == null)
                {
                    throw new Exception("El usuario no existe");
                }
                _usuarioServices.Asociarse(usuario);
                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al asociar usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
            
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult CambiarContrasenaMiPerfil(PasswordDTO passwordDTO)
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _usuarioServices.CambiarContrasena(passwordDTO.nuevaPassword);
                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al cambiar contraseña",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [HttpPost]
        public async Task<IActionResult> ReestablecerContrasenaInit([FromBody] PasswordInitDTO mail)
        {
            try
            {
                bool mailEnviado = await _usuarioServices.ReestablecerContrasenaInit(mail.Email);
                if (mailEnviado) 
                {
                    return Ok();
                }
                throw new Exception("Mail no enviado");
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al reestablecer la contraseña",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }           
        }

        [HttpPost]
        public IActionResult VerificarCodigo([FromBody] VerificarCodigoDTO verificarCodigoDTO)
        {
            try
            {
                bool codigoCorrecto = _usuarioServices.VerificarCodigo(verificarCodigoDTO);
                if (codigoCorrecto)
                {
                    return Ok(verificarCodigoDTO);
                }
                throw new Exception("Código incorrecto");
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al verificar código",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [HttpPost]
        public IActionResult ReestablecerContrasena([FromBody] ReestablecerContrasenaDTO reestablecerContrasenaDTO)
        {
            try
            {
               _usuarioServices.ReestablecerContrasena(reestablecerContrasenaDTO);
               return Ok();               
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al reestablecer contraseña",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }


        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult BloquearUsuario([FromBody] BloquearUsuarioDTO bloquearUsuarioDTO)
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _usuarioServices.BloquearUsuario(bloquearUsuarioDTO);
                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al dar bloquear usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ComprobarJWT()
        {
            try
            {
                // seteo jwt en header de respuesta para refrescarlo en el front
                var TOKEN = HttpContext.Items[JWT].ToString();
                Response.Headers.Append(JWT, TOKEN);
                return Ok();

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

    }
}

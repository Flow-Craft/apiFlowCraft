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
    public class UsersController : ControllerBase
    {
        private const string JWT = "JWT";
        private const string CurrentUserJWT = "CurrentUserJWT";
        
        private readonly IUsuarioServices _usuarioServices;        

        public UsersController(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;            
        }

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
        [HttpGet("{id}")]
        [TypeFilter(typeof(ValidateIdFilterAttribute))]
        [EntityType(typeof(Usuario))] // Aquí se especifica el tipo de entidad
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
                var crearUsuario = _usuarioServices.CrearUsuario(usuario);

                return Ok(crearUsuario);
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
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public async Task<IActionResult> Registro([FromBody] UsuarioRegistroDTO usuarioRegistroDTO)
        {
            if (usuarioRegistroDTO == null)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.BadRequest,
                    title = "El usuario es nulo",
                    errors = new List<string> {  }
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

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            try
            {                
                Usuario usuarioAActualizar = _usuarioServices.ActualizarUsuario(usuario);
                return Ok(usuarioAActualizar);
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
        public IActionResult EliminarUsuario([FromBody] int Id)
        {
            //var TOKEN = HttpContext.Items[JWT].ToString();

            //Response.Headers.Append(JWT, TOKEN);

            //try
            //{
            //    Perfil perfilAEliminar = _configuracionServices.EliminarPerfil(id);
            //    return Ok(perfilAEliminar);
            //}
            //catch (Exception e)
            //{
            //    RespuestaAPI respuestaAPI = new RespuestaAPI
            //    {
            //        status = HttpStatusCode.InternalServerError,
            //        title = "Error al eliminar perfil",
            //        errors = new List<string> { e.Message }
            //    };
            //    return StatusCode((int)respuestaAPI.status, respuestaAPI);
            //}
            return Ok(Id);
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

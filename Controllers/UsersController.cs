using ApiNet8.Models.Partidos;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services;
using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNet8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsuarioServices _usuarioServices;

        public UsersController(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
        }

        // obtener usuarios
        [HttpGet]
        public IActionResult GetUsuarios()
        {
            List<Usuario> partidos = _usuarioServices.GetUsuarios();
            return Ok(partidos);           
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult GetUsuario(int id)
        {
            Usuario usuario = _usuarioServices.GetUsuarioById(id);

            if (usuario == null)
            {
                var problemDetails = new ValidationProblemDetails() { Status = StatusCodes.Status404NotFound, Title = "Usuario no encontrado" };

                return new NotFoundObjectResult(problemDetails);
            }

            return Ok(usuario);
           
        }

        // crear usuarios
        [HttpPost]
        public IActionResult CrearUsuario([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return BadRequest("Usuario es nulo");
            }

            var createdUsuario = _usuarioServices.CrearUsuario(usuario);

            // Retornar el usuario creado con el estado 201 Created
            //return CreatedAtAction(nameof(GetUserById), new { id = createdUsuario.Id }, createdUsuario);
            return CreatedAtAction("", usuario);

        }

    }
}

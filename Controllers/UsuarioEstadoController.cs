//using ApiNet8.Models.Usuarios;
//using ApiNet8.Models;
//using ApiNet8.Services.IServices;
//using Microsoft.AspNetCore.Mvc;
//using System.Net;
//using ApiNet8.Filters.ActionFilters;
//using ApiNet8.Models.DTO;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace ApiNet8.Controllers
//{
//    [Route("api/[controller]/[action]")]
//    [ApiController]
//    public class UsuarioEstadoController : ControllerBase
//    {
//        private readonly IUsuarioEstadoServices _usuarioEstadoServices;
//        public UsuarioEstadoController(IUsuarioEstadoServices usuarioEstadoServices)
//        {
//            this._usuarioEstadoServices = usuarioEstadoServices;
//        }

//        // GET: api/<UsuarioEstadoController>
//        [HttpGet]
//        public IActionResult GetUsuarioEstado()
//        {
//            try
//            {
//                List<UsuarioEstado> usuarioEstados = _usuarioEstadoServices.GetUsuarioEstados();
//                return Ok(usuarioEstados);
//            }
//            catch (Exception e)
//            {
//                RespuestaAPI respuestaAPI = new RespuestaAPI
//                {
//                    status = HttpStatusCode.InternalServerError,
//                    title = "Error al buscar estados posibles de un usuario",
//                    errors = new List<string> { e.Message }
//                };
//                return StatusCode((int)respuestaAPI.status, respuestaAPI);
//            }

//        }

//        [HttpGet("{id}")]
//        [TypeFilter(typeof(ValidateIdFilterAttribute))]
//        [EntityType(typeof(UsuarioEstado))] // Aquí se especifica el tipo de entidad
//        public IActionResult GetUsuarioEstadoById(int id)
//        {
//            try
//            {
//                UsuarioEstado usuarioEstado = _usuarioEstadoServices.GetUsuarioEstadoById(id);// guardar en sesion la entidad enciontrada en el filtro
//                return Ok(usuarioEstado);
//            }
//            catch (Exception e)
//            {
//                RespuestaAPI respuestaAPI = new RespuestaAPI
//                {
//                    status = HttpStatusCode.InternalServerError,
//                    title = "Error al buscar estado posible de un usuario ",
//                    errors = new List<string> { e.Message }
//                };
//                return StatusCode((int)respuestaAPI.status, respuestaAPI);
//            }

//        }

//        [HttpPost]
//        public IActionResult CrearUsuarioEstado([FromBody] UsuarioEstado uEst)
//        {
//            try
//            {
//                UsuarioEstado estadoACrear = _usuarioEstadoServices.CrearUsuarioEstado(uEst);
//                return Ok(estadoACrear);
//            }
//            catch (Exception e)
//            {
//                RespuestaAPI respuestaAPI = new RespuestaAPI
//                {
//                    status = HttpStatusCode.InternalServerError,
//                    title = "Error al crear estado para usuario",
//                    errors = new List<string> { e.Message }
//                };
//                return StatusCode((int)respuestaAPI.status, respuestaAPI);
//            }
//        }

//        [HttpPost]
//        public IActionResult ActualizarUsuarioEstado([FromBody] UsuarioEstadoDTO usuarioEstadoDTO)
//        {
//            try
//            {
//                UsuarioEstado estadoAActualizar = _usuarioEstadoServices.ActualizarUsuarioEstado(usuarioEstadoDTO);
//                return Ok(estadoAActualizar);
//            }
//            catch (Exception e)
//            {
//                RespuestaAPI respuestaAPI = new RespuestaAPI
//                {
//                    status = HttpStatusCode.InternalServerError,
//                    title = "Error al actualizar estado para usuario",
//                    errors = new List<string> { e.Message }
//                };
//                return StatusCode((int)respuestaAPI.status, respuestaAPI);
//            }
//        }

//        [HttpPost]
//        public IActionResult EliminarUsuarioEstado(int id)//ver con Mario como enviar los parametros
//        {
//            try
//            {
//                UsuarioEstado estadoAEliminar = _usuarioEstadoServices.EliminarUsuarioEstado(id);
//                return Ok(estadoAEliminar);
//            }
//            catch (Exception e)
//            {
//                RespuestaAPI respuestaAPI = new RespuestaAPI
//                {
//                    status = HttpStatusCode.InternalServerError,
//                    title = "Error al eliminar estado para usuario",
//                    errors = new List<string> { e.Message }
//                };
//                return StatusCode((int)respuestaAPI.status, respuestaAPI);
//            }
//        }

//        [HttpGet]
//        public IActionResult ExisteUsuarioEstado(string nombre)
//        {
//            try
//            {
//                bool exist = _usuarioEstadoServices.ExisteUsuarioEstado(nombre);
//                return Ok(exist);
//            }
//            catch (Exception e)
//            {
//                RespuestaAPI respuestaAPI = new RespuestaAPI
//                {
//                    status = HttpStatusCode.InternalServerError,
//                    title = "Error al buscar estado de usuario",
//                    errors = new List<string> { e.Message }
//                };
//                return StatusCode((int)respuestaAPI.status, respuestaAPI);
//            }

//        }
//    }
//}

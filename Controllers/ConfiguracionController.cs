using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using ApiNet8.Models.Usuarios;
using ApiNet8.Models;
using System.Net;
using ApiNet8.Filters.ActionFilters;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Club;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Partidos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNet8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConfiguracionController : ControllerBase
    {
        private const string JWT = "JWT";
        private const string CurrentUserJWT = "CurrentUserJWT";

        private readonly IConfiguracionServices _configuracionServices;
        private readonly IUsuarioEstadoServices _usuarioEstadoServices;
        private readonly IEventoEstadoService _eventoEstadoServices;
        private readonly IEquipoEstadoService _equipoEstadoServices;

        public ConfiguracionController(IConfiguracionServices configuracionServices, IUsuarioEstadoServices usuarioEstadoServices, IEventoEstadoService eventoEstadoServices, IEquipoEstadoService equipoEstadoServices)
        {
            this._configuracionServices = configuracionServices;
            this._usuarioEstadoServices = usuarioEstadoServices;
            this._eventoEstadoServices = eventoEstadoServices;
            this._equipoEstadoServices = equipoEstadoServices;
        }

        /////////////////////////////////////////PERFIL///////////////////////////////////////////////////////
        
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetPerfiles()
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
            List<Perfil> perfiles = _configuracionServices.GetPerfiles();
            return Ok(perfiles);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar perfiles",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
            
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet("{id}")]
        [TypeFilter(typeof(ValidateIdFilterAttribute))]
        [EntityType(typeof(Perfil))] 
        public IActionResult GetPerfilById(int id)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                Perfil perfil = _configuracionServices.GetPerfilById(id);// guardar en sesion la entidad enciontrada en el filtro
                return Ok(perfil);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar perfil",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
            
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult CrearPerfil([FromBody] Perfil perfil)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            try
            {
            Perfil perfilACrear = _configuracionServices.CrearPerfil(perfil, currentUserJwt);
            return Ok(perfilACrear);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al crear perfil",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }            
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult ActualizarPerfil([FromBody] PerfilDTO perfil)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            try
            {
                Perfil perfilAActualizar = _configuracionServices.ActualizarPerfil(perfil, currentUserJwt);
                return Ok(perfilAActualizar);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al actualizar perfil",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult EliminarPerfil(int id)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            try
            {
                Perfil perfilAEliminar = _configuracionServices.EliminarPerfil(id, currentUserJwt);
                return Ok(perfilAEliminar);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al eliminar perfil",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult GetPermisosByPerfil(Perfil perfil)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                List<Permiso> permisos = _configuracionServices.GetPermisosByPerfil(perfil);// guardar en sesion la entidad enciontrada en el filtro
                return Ok(permisos);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar permisos del perfil",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ExistePerfil(string nombre)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                bool exist = _configuracionServices.ExistePerfil(nombre);
                return Ok(exist);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar perfil",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        //////////////////////////////////////////PERFIL DEL CLUB///////////////////////////////////////////////
        
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult CrearPerfilClub([FromBody] PerfilClubDTO perfilClubDTO)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                PerfilClub perfilACrear = _configuracionServices.CrearPerfilClub(perfilClubDTO);
                return Ok(perfilACrear);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = e.Message == "Ya existe un perfil con ese nombre" ? HttpStatusCode.BadRequest :  HttpStatusCode.InternalServerError,
                    title = "Error al crear perfil de club",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult ActualizarPerfilClub([FromBody] PerfilClubDTO perfilClub)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN); 

            try
            {
                PerfilClub perfilAActualizar = _configuracionServices.ActualizarPerfilClub(perfilClub);
                return Ok(perfilAActualizar);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = e.Message == "No existe el perfil" || e.Message == "No existe un parametro o un historial asociado a ese perfil" ? HttpStatusCode.BadRequest : HttpStatusCode.InternalServerError,
                    title = "Error al actualizar perfil de club",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult EliminarPerfilClub(int id)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                PerfilClub perfilAEliminar = _configuracionServices.EliminarPerfilClub(id);
                return Ok(perfilAEliminar);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = e.Message == "No existe un parametro o un historial asociado a ese perfil" ? HttpStatusCode.BadRequest : HttpStatusCode.InternalServerError,
                    title = "Error al eliminar perfil de club",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        //////////////////////////////////USUARIO ESTADO/////////////////////////////////////////////////////
        
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetUsuarioEstado()
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                List<UsuarioEstado> usuarioEstados = _usuarioEstadoServices.GetUsuarioEstados();
                return Ok(usuarioEstados);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar estados posibles de un usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet("{id}")]
        [TypeFilter(typeof(ValidateIdFilterAttribute))]
        [EntityType(typeof(UsuarioEstado))]
        public IActionResult GetUsuarioEstadoById(int id)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                UsuarioEstado usuarioEstado = _usuarioEstadoServices.GetUsuarioEstadoById(id);// guardar en sesion la entidad enciontrada en el filtro
                return Ok(usuarioEstado);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar estado posible de un usuario ",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult CrearUsuarioEstado([FromBody] UsuarioEstadoDTO usuarioEstadoDTO)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            if (usuarioEstadoDTO == null)
            {
                return BadRequest("Estado de usuario es nulo");
            }

            try
            {
                UsuarioEstado estadoACrear = _usuarioEstadoServices.CrearUsuarioEstado(usuarioEstadoDTO, currentUserJwt);
                return Ok(estadoACrear);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al crear estado para usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult ActualizarUsuarioEstado([FromBody] UsuarioEstadoDTO usuarioEstadoDTO)
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            try
            {
                UsuarioEstado estadoAActualizar = _usuarioEstadoServices.ActualizarUsuarioEstado(usuarioEstadoDTO, currentUserJwt);
                return Ok(estadoAActualizar);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al actualizar estado para usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult EliminarUsuarioEstado(int id)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            try
            {
                UsuarioEstado estadoAEliminar = _usuarioEstadoServices.EliminarUsuarioEstado(id, currentUserJwt);
                return Ok(estadoAEliminar);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al eliminar estado para usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ExisteUsuarioEstado(string nombre)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                bool exist = _usuarioEstadoServices.ExisteUsuarioEstado(nombre);
                return Ok(exist);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar estado de usuario",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        //////////////////////////////////EVENTO ESTADO/////////////////////////////////////////////////////
        
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetEventoEstado()
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                List<EstadoEvento> eventoEstados = _eventoEstadoServices.GetEventoEstados();
                return Ok(eventoEstados);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar estados posibles de un evento",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet("{id}")]
        [TypeFilter(typeof(ValidateIdFilterAttribute))]
        [EntityType(typeof(EstadoEvento))] 
        public IActionResult GetEventoEstadoById(int id)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                EstadoEvento eventoEstado = _eventoEstadoServices.GetEventoEstadoById(id);// guardar en sesion la entidad enciontrada en el filtro
                return Ok(eventoEstado);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar estado posible de un evento ",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult CrearEventoEstado([FromBody] EstadoEventoDTO eventoEstadoDTO)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            if (eventoEstadoDTO == null)
            {
                return BadRequest("Estado de evento es nulo");
            }

            try
            {
                EstadoEvento estadoACrear = _eventoEstadoServices.CrearEventoEstado(eventoEstadoDTO, currentUserJwt);
                return Ok(estadoACrear);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al crear estado para evento",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult ActualizarEventoEstado([FromBody] EstadoEventoDTO eventoEstadoDTO)
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            try
            {
                EstadoEvento estadoAActualizar = _eventoEstadoServices.ActualizarEventoEstado(eventoEstadoDTO, currentUserJwt);
                return Ok(estadoAActualizar);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al actualizar estado para evento",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult EliminarEventoEstado(int id)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            try
            {
                EstadoEvento estadoAEliminar = _eventoEstadoServices.EliminarEventoEstado(id, currentUserJwt);
                return Ok(estadoAEliminar);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al eliminar estado para evento",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ExisteEventoEstado(string nombre)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                bool exist = _eventoEstadoServices.ExisteEventoEstado(nombre);
                return Ok(exist);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar estado de evento",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        //////////////////////////////////EQUIPO ESTADO/////////////////////////////////////////////////////
        
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetEquipoEstado()
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                List<EquipoEstado> equipoEstados = _equipoEstadoServices.GetEquipoEstados();
                return Ok(equipoEstados);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar estados posibles de un equipo",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet("{id}")]
        [TypeFilter(typeof(ValidateIdFilterAttribute))]
        [EntityType(typeof(EquipoEstado))]
        public IActionResult GetEquipoEstadoById(int id)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                EquipoEstado equipoEstado = _equipoEstadoServices.GetEquipoEstadoById(id);// guardar en sesion la entidad enciontrada en el filtro
                return Ok(equipoEstado);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar estado posible de un equipo ",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult CrearEquipoEstado([FromBody] EquipoEstadoDTO equipoEstadoDTO)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            if (equipoEstadoDTO == null)
            {
                return BadRequest("Estado de equipo es nulo");
            }

            try
            {
                EquipoEstado estadoACrear = _equipoEstadoServices.CrearEquipoEstado(equipoEstadoDTO, currentUserJwt);
                return Ok(estadoACrear);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al crear estado para equipo",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult ActualizarEquipoEstado([FromBody] EquipoEstadoDTO equipoEstadoDTO)
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            try
            {
                EquipoEstado estadoAActualizar = _equipoEstadoServices.ActualizarEquipoEstado(equipoEstadoDTO, currentUserJwt);
                return Ok(estadoAActualizar);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al actualizar estado para equipo",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult EliminarEquipoEstado(int id)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            // obtengo datos de jwt para utilizar
            JwtToken currentUserJwt = (JwtToken)HttpContext.Items[CurrentUserJWT];

            try
            {
                EquipoEstado estadoAEliminar = _equipoEstadoServices.EliminarEquipoEstado(id, currentUserJwt);
                return Ok(estadoAEliminar);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al eliminar estado para equipo",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ExisteEquipoEstado(string nombre)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                bool exist = _equipoEstadoServices.ExisteEquipoEstado(nombre);
                return Ok(exist);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar estado de equipo",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

    }
}

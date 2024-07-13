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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNet8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConfiguracionController : ControllerBase
    {
        private readonly IConfiguracionServices _configuracionServices;
        public ConfiguracionController(IConfiguracionServices configuracionServices)
        {
            this._configuracionServices = configuracionServices;
        }
        // GET: api/<ConfiguracionController>
        [HttpGet]
        public IActionResult GetPerfiles()
        {
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

       
        [HttpGet("{id}")]
        [TypeFilter(typeof(ValidateIdFilterAttribute))]
        [EntityType(typeof(Perfil))] // Aquí se especifica el tipo de entidad
        public IActionResult GetPerfilById(int id)
        {
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

        // POST api/<ConfiguracionController>
        [HttpPost]
        public IActionResult CrearPerfil([FromBody] Perfil perfil)
        {
            try
            {
            Perfil perfilACrear = _configuracionServices.CrearPerfil(perfil);
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

        [HttpPost]
        public IActionResult ActualizarPerfil([FromBody] PerfilDTO perfil)
        {
            try
            {
                Perfil perfilAActualizar = _configuracionServices.ActualizarPerfil(perfil);
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

        [HttpPost]
        public IActionResult EliminarPerfil(int id)//ver con Mario como enviar los parametros
        {
            try
            {
                Perfil perfilAEliminar = _configuracionServices.EliminarPerfil(id);
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

        [HttpPost]
        public IActionResult GetPermisosByPerfil(Perfil perfil)
        {
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

        [HttpGet]
        public IActionResult ExistePerfil(string nombre)
        {
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

        [HttpPost]
        public IActionResult CrearPerfilClub([FromBody] PerfilClubDTO perfilClubDTO)
        {
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

        [HttpPost]
        public IActionResult ActualizarPerfilClub([FromBody] PerfilClubDTO perfilClub)
        {
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

        [HttpPost]
        public IActionResult EliminarPerfilClub(int id)
        {
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

    }
}

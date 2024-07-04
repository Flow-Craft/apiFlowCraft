using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using ApiNet8.Models.Usuarios;
using ApiNet8.Models;
using System.Net;
using ApiNet8.Filters.ActionFilters;

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
                return BadRequest(e.Message);
            }
            
        }

       
        [HttpGet("{id}")]
        [TypeFilter(typeof(ValidateIdFilterAttribute))]
        [EntityType(typeof(Perfil))] // Aquí se especifica el tipo de entidad
        public IActionResult GetPerfilById(int id)
        {
            try
            {
                Perfil perfil = _configuracionServices.GetPerfilById(id);
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
        
    }
}

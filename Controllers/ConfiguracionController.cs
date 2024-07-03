using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using ApiNet8.Models.Usuarios;
using ApiNet8.Models;
using System.Net;

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

        // GET api/<ConfiguracionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
                RespuestaAPI respuestaAPI = new RespuestaAPI();
                respuestaAPI.StatusCode = HttpStatusCode.InternalServerError;
                respuestaAPI.ErrorMessages.Add("Error al crear perfil" + e.ToString());
                respuestaAPI.IsSuccess = false;
                return BadRequest(respuestaAPI);
            }
            
        }

        // PUT api/<ConfiguracionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ConfiguracionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

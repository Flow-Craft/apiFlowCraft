using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models;
using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ApiNet8.Models.Torneos;
using ApiNet8.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNet8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TorneosController : CustomController
    {
        private const string JWT = "JWT";

        private readonly ITorneoEstadoServices _torneoEstadoServices;
        private readonly ITorneoServices _torneoServices;

        public TorneosController(ITorneoEstadoServices torneoEstadoServices, ITorneoServices torneoServices)
        {
            _torneoEstadoServices = torneoEstadoServices;
            _torneoServices = torneoServices;
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetTorneoEstados()
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                List<TorneoEstado> torneoEstado = _torneoEstadoServices.GetTorneoEstados();
                return Ok(torneoEstado);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al obtener estados de torneos",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetTorneoEstadosActivos()
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                List<TorneoEstado> torneoEstado = _torneoEstadoServices.GetTorneoEstadosActivos();
                return Ok(torneoEstado);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al obtener estados de torneos",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetTorneoEstadoById(TorneoEstadoDTO torneoEstadoDTO)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                TorneoEstado torneoEstado = _torneoEstadoServices.GetTorneoEstadoById(torneoEstadoDTO.Id);

                if (torneoEstado == null)
                {
                    var problemDetails = new ValidationProblemDetails() { Status = StatusCodes.Status404NotFound, Title = "Estado de torneo no encontrado" };

                    return new NotFoundObjectResult(problemDetails);
                }

                return Ok(torneoEstado);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al obtener estado de torneo con id: " + torneoEstadoDTO.Id,
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }


        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult CrearTorneoEstado([FromBody] TorneoEstadoDTO torneoEstadoDTO)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _torneoEstadoServices.CrearTorneoEstado(torneoEstadoDTO);

                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al crear estado de torneo",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult ActualizarTorneoEstado([FromBody] TorneoEstadoDTO torneoEstadoDTO)
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _torneoEstadoServices.ActualizarTorneoEstado(torneoEstadoDTO);
                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al actualizar estado de torneo",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult EliminarTorneoEstado(TorneoEstadoDTO torneoEstadoDTO)
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _torneoEstadoServices.EliminarTorneoEstado(torneoEstadoDTO);
                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al eliminar estado de torneo",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult AltaTorneo(TorneoDTO torneoDTO)
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _torneoServices.CrearTorneo(torneoDTO);
                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al crear torneo",
                    errors = new List<string>{
                                e.Message,
                                "Exception: " + e.ToString()
                            }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ApiNet8.Services.IServices;
using ApiNet8.Models.Reservas;
using ApiNet8.Models;
using ApiNet8.Services;
using System.Net;
using ApiNet8.Models.NoticiasYNotificaciones;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNet8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NoticiasController : ControllerBase
    {
        private const string JWT = "JWT";
        private const string CurrentUserJWT = "CurrentUserJWT";

        private readonly INoticiasServices _noticiasServices;

        public NoticiasController(INoticiasServices noticiasServices)
        {
            this._noticiasServices = noticiasServices;
        }

        // GET: api/<NoticiasController>
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetNoticias()
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                List<Noticias> noticias = _noticiasServices.GetNoticias();
                return Ok(noticias);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar noticias",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        // GET: ReservasController
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetNoticiasActivas()
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                List<Noticias> noticias = _noticiasServices.GetNoticiasActivas();
                return Ok(noticias);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar noticias",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }
    }
}

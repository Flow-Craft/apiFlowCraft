using ApiNet8.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ApiNet8.Services.IServices;
using ApiNet8.Models.Reservas;

namespace ApiNet8.Controllers
{
    public class ReservasController : ControllerBase
    {
        private const string JWT = "JWT";
        private const string CurrentUserJWT = "CurrentUserJWT";

        private readonly IInstalacionServices _instalacionServices;

        public ReservasController(IInstalacionServices instalacionServices)
        {
            this._instalacionServices = instalacionServices;
        }

        // GET: ReservasController
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetInstalaciones()
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                List<Instalacion> instalaciones = _instalacionServices.GetInstalaciones();
                return Ok(instalaciones);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar instalaciones",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        // GET: ReservasController
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetInstalacionesActivas()
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                List<Instalacion> instalaciones = _instalacionServices.GetInstalacionesActivas();
                return Ok(instalaciones);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar instalaciones",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

    }
}

using Microsoft.AspNetCore.Mvc;
using ApiNet8.Services.IServices;
using ApiNet8.Models.Reservas;
using ApiNet8.Models;
using ApiNet8.Services;
using System.Net;
using ApiNet8.Models.NoticiasYNotificaciones;
using ApiNet8.Filters.ActionFilters;
using ApiNet8.Models.Usuarios;
using ApiNet8.Models.DTO;

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

        // GET: ReservasController
        [HttpGet]
        public IActionResult GetNoticiasActivasSimpatizante()
        {
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

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet("{id}")]
        [TypeFilter(typeof(ValidateIdFilterAttribute))]
        [EntityType(typeof(Noticias))]
        public IActionResult GetNoticiaById(int id)//LISTO
        {
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                Noticias noticia = _noticiasServices.GetNoticiaById(id);// guardar en sesion la entidad enciontrada en el filtro
                return Ok(noticia);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar noticia",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult CrearNoticia([FromBody] NoticiaDTO noticiaDTO)//LISTO
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                Noticias noticia = _noticiasServices.CrearNoticia(noticiaDTO);
                return Ok(noticia);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al crear noticia",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult ActualizarNoticia([FromBody] NoticiaDTO noticiaDTO)//LISTO
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _noticiasServices.ActualizarNoticia(noticiaDTO);
                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al actualizar noticia",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost("{id}")]
        public IActionResult EliminarNoticia(int id)//LISTO
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                Noticias noticia = _noticiasServices.EliminarNoticia(id);
                return Ok(noticia);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al eliminar noticia",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ExisteNoticia(string titulo)//LISTO
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                bool exist = _noticiasServices.ExisteNoticia(titulo);
                return Ok(exist);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al buscar noticia",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }
    }
}

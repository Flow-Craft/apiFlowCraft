using ApiNet8.Models.DTO;
using ApiNet8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ApiNet8.Services.IServices;
using ApiNet8.Services;
using ApiNet8.Filters.ActionFilters;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DisciplinasYLeccionesController : CustomController
    {
        private const string JWT = "JWT";
        private const string CurrentUserJWT = "CurrentUserJWT";

        private readonly IDisciplinasYLeccionesServices _disciplinasYLeccionesServices;

        public DisciplinasYLeccionesController(IDisciplinasYLeccionesServices disciplinasYLeccionesServices)
        {
            _disciplinasYLeccionesServices = disciplinasYLeccionesServices;
        }

        // crear disciplina
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult CrearDisciplina([FromBody] DisciplinaDTO disciplina)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _disciplinasYLeccionesServices.CrearDisciplina(disciplina);

                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al crear disciplina",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }


        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult ActualizarDisciplina([FromBody] DisciplinaDTO disciplina)
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _disciplinasYLeccionesServices.ActualizarDisciplina(disciplina);
                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al actualizar disciplina",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public IActionResult EliminarDisciplina(int id)
        {
            // seteo jwt en header de respuesta
            var TOKEN = HttpContext.Items[JWT].ToString();
            Response.Headers.Append(JWT, TOKEN);

            try
            {
                _disciplinasYLeccionesServices.EliminarDisciplina(id);
                return Ok();
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al eliminar disciplina",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [TypeFilter(typeof(ValidateIdFilterAttribute))]
        [EntityType(typeof(Disciplina))] // Aquí se especifica el tipo de entidad
        [HttpGet("{id}")]
        [HttpGet]
        public IActionResult GetDisciplina(int id)
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                Disciplina disciplina = _disciplinasYLeccionesServices.GetDisciplinaById(id);

                if (disciplina == null)
                {
                    var problemDetails = new ValidationProblemDetails() { Status = StatusCodes.Status404NotFound, Title = "Disciplina no encontrada" };

                    return new NotFoundObjectResult(problemDetails);
                }

                return Ok(disciplina);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al obtener disciplina con id: " + id,
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }


        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult GetDisciplinas()
        {
            var TOKEN = HttpContext.Items[JWT].ToString();

            Response.Headers.Append(JWT, TOKEN);

            try
            {
                List<Disciplina> disciplinas = _disciplinasYLeccionesServices.GetDisciplinas();
                return Ok(disciplinas);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al obtener disciplinas",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }

        [HttpGet]
        public IActionResult GetDisciplinasMenu()
        {
            try
            {
                List<DisciplinaMenuDTO> disciplinas = _disciplinasYLeccionesServices.GetDisciplinasMenu();
                return Ok(disciplinas);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = "Error al obtener disciplinas del menu",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }
    }
}

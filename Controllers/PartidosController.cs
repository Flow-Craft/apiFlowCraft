using ApiNet8.Data;
using ApiNet8.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ApiNet8.Models.Partidos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNet8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PartidosController : ControllerBase
    {
        private readonly PartidoServices partidosServices;

        public PartidosController(PartidoServices partidosServices)
        {
            this.partidosServices = partidosServices;
        }

        // GET: api/<PartidosController>
        [HttpGet]
        public IActionResult GetPartidos()
        {
            List<Partido> partidos = partidosServices.GetPartidos();
            return Ok(partidos);
        }

        // GET api/<PartidosController>/5
        [HttpGet("{id}")]
        public IActionResult GetPartido(int id)
        {
            Partido partido = partidosServices.GetPartidos(id);

            if (partido == null)
            {
                var problemDetails = new ValidationProblemDetails() { Status = StatusCodes.Status404NotFound, Title="Partido no encontrado" };
              
                return new NotFoundObjectResult(problemDetails);
            }

            return Ok(partido);
        }

        // POST api/<PartidosController>
        //[HttpPost]
        //public IActionResult CreatePartido([FromBody] Partido partido)
        //{
        //    if (partido == null)
        //    {
        //        var problemDetails = new ValidationProblemDetails() { Status = StatusCodes.Status404NotFound, Title = "Partido no encontrado" };

        //        return new NotFoundObjectResult(problemDetails);
        //    }

        //    if (partidosServices.PartidoExist(partido)) {

        //        var problemDetails = new ValidationProblemDetails() { Status = StatusCodes.Status400BadRequest, Title = "Partido ya existe" };

        //        return new BadRequestObjectResult(problemDetails);
        //    }

        //    try
        //    {
        //        partidosServices.CreatePartido(partido);
        //        return CreatedAtAction(nameof(GetPartido), 
        //            new { id=partido.IdPartido},
        //            partido);
        //    }
        //    catch (Exception ex)
        //    {
        //        var problemDetails = new ValidationProblemDetails() { Status = StatusCodes.Status500InternalServerError,
        //            Title = "Error al crear el partido",
        //            Detail = ex.Message
        //        };

        //        return new ObjectResult(problemDetails) { StatusCode = StatusCodes.Status500InternalServerError };
        //    }
           
        //}

     
    }
}

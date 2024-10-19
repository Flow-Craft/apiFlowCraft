using ApiNet8.Models.DTO;
using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNet8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportesController : ControllerBase
    {
        private readonly IReporteServices _reporteServices;

        public ReportesController(IReporteServices reporteServices)
        {
            _reporteServices = reporteServices;
        }

        [HttpGet("ReporteEvento")]
        public IActionResult ReporteEvento(EventoReporteDTO reporte) // poner el dto para que me mande los datos
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteEventoUsuarioPeriodo(reporte.periodoInicio, reporte.periodoFin, reporte.idUsuario);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteEventos.pdf");
        }
    }
}

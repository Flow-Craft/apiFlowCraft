using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ApiNet8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportesController : CustomController
    {
        private readonly IReporteServices _reporteServices;

        public ReportesController(IReporteServices reporteServices)
        {
            _reporteServices = reporteServices;
        }

        #region Eventos
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ReporteEventoByUsuarioPeriodo([FromQuery] EventoReporteDTO reporte)
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteEventoUsuarioPeriodo(reporte.periodoInicio, reporte.periodoFin, reporte.idUsuario);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteEventos_Usuario_Periodo.pdf");
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ReporteEventoByTipoEventoPeriodo([FromQuery] EventoReporteDTO reporte)
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteEventoTipoEventoPeriodo(reporte.periodoInicio, reporte.periodoFin, reporte.idTipoEvento);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteEventos_TipoEvento_Periodo.pdf");
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ReporteEventoByInstalacionPeriodo([FromQuery] EventoReporteDTO reporte)
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteEventoInstalacionPeriodo(reporte.periodoInicio, reporte.periodoFin, reporte.idInstalacion);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteEventos_Instalacion_Periodo.pdf");
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ReporteEventoByEvento([FromQuery] EventoReporteDTO reporte)
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteEventoByEvento(reporte.idEvento);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteEventos_Evento.pdf");
        }

        #endregion

        #region estadisticas
        //[ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ReporteEstadisticasByDiscUsuPeriodo([FromQuery] EstadisticasReporteDTO reporte)
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteEstadisticaDiscUsuPeriodo(reporte.PeriodoInicio, reporte.PeriodoFin, reporte.IdDisciplina, reporte.IdUsuario);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteEstadisticass_Disciplina_Usuario_Periodo.pdf");
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ReporteEstadisticasByDiscUsuLeccionPeriodo([FromQuery] EstadisticasReporteDTO reporte)
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteEstadisticaDiscUsuLeccionPeriodo(reporte.PeriodoInicio, reporte.PeriodoFin, reporte.IdDisciplina, reporte.IdLeccion, reporte.IdUsuario);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteEstadisticass_Disciplina_Usuario_Periodo.pdf");
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ReporteEstadisticasByDiscEquipoPeriodo([FromQuery] EstadisticasReporteDTO reporte)
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteEstadisticaDiscEquipoPeriodo(reporte.PeriodoInicio, reporte.PeriodoFin, reporte.IdDisciplina, reporte.IdEquipo);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteEstadisticass_Disciplina_Equipo_Periodo.pdf");
        }

        #endregion

        #region Reservas
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ReporteReservasByUsuarioPeriodo([FromQuery] EstadisticasReporteDTO reporte)
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteReservaUsuarioPeriodo(reporte.PeriodoInicio, reporte.PeriodoFin,reporte.IdUsuario);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteReservass_Usuario_Periodo.pdf");
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ReporteReservasByInstalacionPeriodo([FromQuery] EstadisticasReporteDTO reporte)
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteReservaInstalacionPeriodo(reporte.PeriodoInicio, reporte.PeriodoFin, reporte.IdInstalacion);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteReservass_Instalacion_Periodo.pdf");
        }

        //[ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ReporteReservasByPeriodo([FromQuery] EstadisticasReporteDTO reporte)
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteReservaPeriodo(reporte.PeriodoInicio, reporte.PeriodoFin);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteReservass_Periodo.pdf");
        }

        #endregion

        #region Lecciones
        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ReporteLeccionUsuarioPeriodo([FromQuery] ReporteLeccionDTO reporte)
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteLeccionUsuarioPeriodo((DateTime)reporte.periodoInicio, (DateTime)reporte.periodoFin, (int)reporte.idUsuario);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteLeccion_Usuario_Periodo.pdf");
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult ReporteLeccionDisciplinaCategoriaPeriodo([FromQuery] ReporteLeccionDTO reporte)
        {
            // Llamar al servicio para crear el reporte
            byte[] pdfReporte = _reporteServices.ReporteLeccionDisciplinaCategoriaPeriodo((DateTime) reporte.periodoInicio, (DateTime) reporte.periodoFin, (int) reporte.idDisciplina, (int) reporte.idCategoria);

            // Retornar el PDF como archivo descargable
            return File(pdfReporte, "application/pdf", "ReporteLeccion_Disciplina_Categoria_Periodo.pdf");
        }
        #endregion
    }
}

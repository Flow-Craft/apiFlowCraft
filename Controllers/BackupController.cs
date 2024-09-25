using ApiNet8.Models;
using ApiNet8.Models.Partidos;
using ApiNet8.Services;
using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNet8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BackupController : ControllerBase
    {
        private const string JWT = "JWT";
        private readonly IBackupServices _backupServices;

        public BackupController(IBackupServices backupServices)
        {
            this._backupServices = backupServices;
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpPost]
        public async Task<IActionResult> SubirBackup(IFormFile file)
        {
            try
            {
                // seteo jwt en header de respuesta
                var TOKEN = HttpContext.Items[JWT].ToString();
                Response.Headers.Append(JWT, TOKEN);

                string fullPath = await _backupServices.SubirPDF(file);

                return Ok(new { Message = "Archivo subido exitosamente", FilePath = fullPath });
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = $"Error al guardar el archivo: {e.Message}",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult DescargarBackup(string fileName)
        {
            try
            {
                // seteo jwt en header de respuesta
                var TOKEN = HttpContext.Items[JWT].ToString();
                Response.Headers.Append(JWT, TOKEN);

                var (fileBytes, name, error) = _backupServices.DescargarBackup(fileName);

                if (error != null)
                    return NotFound(error);

                return File(fileBytes, "application/pdf", name);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = $"Error al obtener el archivo: {e.Message}",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }
           
        }

        [ServiceFilter(typeof(ValidateJwtAndRefreshFilter))]
        [HttpGet]
        public IActionResult VerificarArchivo(string fileName)
        {
            try
            {
                // seteo jwt en header de respuesta
                var TOKEN = HttpContext.Items[JWT].ToString();
                Response.Headers.Append(JWT, TOKEN);

                bool archivoExiste = _backupServices.VerificarArchivoExiste(fileName);

                var response = new
                {
                    Existe = archivoExiste
                };

                return Ok(response);
            }
            catch (Exception e)
            {
                RespuestaAPI respuestaAPI = new RespuestaAPI
                {
                    status = HttpStatusCode.InternalServerError,
                    title = $"Error al obtener el archivo: {e.Message}",
                    errors = new List<string> { e.Message }
                };
                return StatusCode((int)respuestaAPI.status, respuestaAPI);
            }

        }
    }
}

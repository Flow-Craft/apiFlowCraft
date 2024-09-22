using ApiNet8.Services;
using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNet8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BackupController : ControllerBase
    {
        private readonly IBackupServices _backupServices;

        public BackupController(IBackupServices backupServices)
        {
            this._backupServices = backupServices;
        }

        [HttpPost]
        public async Task<IActionResult> SubirBackup(IFormFile file)
        {
            try
            {
                string fullPath = await _backupServices.SubirPDF(file);

                return Ok(new { Message = "Archivo subido exitosamente", FilePath = fullPath });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al guardar el archivo: {ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult DescargarBackup(string fileName)
        {
            var (fileBytes, name, error) = _backupServices.DescargarBackup(fileName);

            if (error != null)
                return NotFound(error);

            return File(fileBytes, "application/pdf", name);
        }
    }
}

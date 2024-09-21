using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNet8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BackupController : ControllerBase
    {
        private readonly string _filePath = "D:\\OneDrive\\Repositorios\\ApiNet8\\Backup"; // Ruta donde se guardará el archivo

        [HttpPost]
        public async Task<IActionResult> SubirGuiaBackup(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No se ha enviado ningún archivo");

            // Verifica si el archivo es un PDF
            if (file.ContentType != "application/pdf")
                return BadRequest("Solo se permiten archivos PDF");

            try
            {
                // Asegúrate de que la carpeta exista
                if (!Directory.Exists(_filePath))
                {
                    Directory.CreateDirectory(_filePath);
                }

                // Nombre único para el archivo
                var fileName = Path.GetFileName(file.FileName);
                var fullPath = Path.Combine(_filePath, fileName);

                // Guardar el archivo en el sistema de archivos
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return Ok(new { Message = "Archivo subido exitosamente", FilePath = fullPath });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al guardar el archivo: {ex.Message}");
            }
        }
    }
}

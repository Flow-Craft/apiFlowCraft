using ApiNet8.Data;
using ApiNet8.Services.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiNet8.Services
{
    public class BackupServices : IBackupServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly string _filePath = "D:\\Flowcraft\\Backup"; // Ruta donde se guardará el archivo

        public BackupServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> SubirPDF(IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new Exception("No se ha enviado ningún archivo");

            // Verifica si el archivo es un PDF
            if (file.ContentType != "application/pdf")
                throw new Exception("Solo se permiten archivos PDF");

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

                return fullPath;

            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el archivo: {ex.Message}");
            }
        }

        public (byte[] fileBytes, string fileName, string error) DescargarBackup(string fileName)
        {
            var fullPath = Path.Combine(_filePath, fileName);

            if (!System.IO.File.Exists(fullPath))
                return (null, null, "El archivo no existe");

            var fileBytes = System.IO.File.ReadAllBytes(fullPath);
            return (fileBytes, fileName, null);
        }

        public bool VerificarArchivoExiste(string fileName)
        {
            // Combinar la ruta con el nombre del archivo
            string fullPath = Path.Combine(_filePath, fileName);

            // Verificar si el archivo existe
            return File.Exists(fullPath);        }


    }
}

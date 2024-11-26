using ApiNet8.Data;
using ApiNet8.Services.IServices;
using AutoMapper;
using ApiNet8.Models;
using Microsoft.EntityFrameworkCore;
using ApiNet8.Models.Club;

namespace ApiNet8.Services
{
    public class BackupServices : IBackupServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BackupServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }      

        public async Task SubirPDF(IFormFile file, string tipo)
        {
            if (tipo != "Backup" && tipo != "Recuperacion")
            {
                throw new Exception("El tipo del pdf debe ser Backup o Recuperacion");
            }

            if (file == null || file.Length == 0)
                throw new Exception("No se ha enviado ningún archivo");

            // Verifica si el archivo es un PDF
            if (file.ContentType != "application/pdf")
                throw new Exception("Solo se permiten archivos PDF");

            try
            {
                // guardar pdf en memoria
                using var memoryStream = new MemoryStream();
                await file.CopyToAsync(memoryStream);

                // asignar numero de version
                int newVersion = 1;
                var lastBackup = await _db.Backup.Where(b=>b.Tipo == tipo).OrderByDescending(b => b.Version).FirstOrDefaultAsync();

                if (lastBackup != null)
                {
                    newVersion = lastBackup.Version + 1;
                }

                // obtener nombre del archivo
                var fileName = Path.GetFileName(file.FileName);

                // crear instancia de backup y guardar en la base
                var backup = new Backup
                { 
                    Version = newVersion, 
                    Tipo = tipo, 
                    Pdf = memoryStream.ToArray(),
                    FechaCreacion = DateTime.Now,
                    Nombre = fileName
                };

                _db.Backup.Add(backup);

                await _db.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el archivo: {ex.Message}");
            }
        }

        public async Task<(byte[] fileBytes, string fileName, string? error)> DescargarBackup(int id)
        {
            try
            {
                var backup = await _db.Backup.FindAsync(id);

                if (backup == null)
                { 
                    throw new Exception("El archivo no existe");
                }

                return (backup.Pdf, backup.Nombre, null);
            }
            catch (Exception e)
            {
                throw new Exception (e.Message);
            }           
        }

        public List<Backup> GetBackups() 
        {
            List<Backup> result = _db.Backup.ToList();
            return result;
        }
    }
}

using ApiNet8.Models.Club;

namespace ApiNet8.Services.IServices
{
    public interface IBackupServices
    {
        Task SubirPDF(IFormFile file, string tipo);
        Task<(byte[] fileBytes, string fileName, string? error)> DescargarBackup(int id);
        List<Backup> GetBackups();
    }
}

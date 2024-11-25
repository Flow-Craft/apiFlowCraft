using Microsoft.AspNetCore.Mvc;

namespace ApiNet8.Services.IServices
{
    public interface IBackupServices
    {
        Task SubirPDF(IFormFile file, string tipo);
        (byte[] fileBytes, string fileName, string error) DescargarBackup(string fileName);
        bool VerificarArchivoExiste(string fileName);
    }
}

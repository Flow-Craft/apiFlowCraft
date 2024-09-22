using Microsoft.AspNetCore.Mvc;

namespace ApiNet8.Services.IServices
{
    public interface IBackupServices
    {
        Task<string> SubirPDF(IFormFile file);
        (byte[] fileBytes, string fileName, string error) DescargarBackup(string fileName);
        //Task ObtenerGuiaBackup();
        //Task ObtenerGuiarRecuperacion();
    }
}

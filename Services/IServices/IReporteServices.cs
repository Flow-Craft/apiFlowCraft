namespace ApiNet8.Services.IServices
{
    public interface IReporteServices
    {
        byte[] ReporteEventoUsuarioPeriodo(DateTime periodoInicio, DateTime periodoFin, int idUsuario);
    }
}

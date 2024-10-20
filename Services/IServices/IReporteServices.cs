namespace ApiNet8.Services.IServices
{
    public interface IReporteServices
    {
        byte[] ReporteEventoUsuarioPeriodo(DateTime periodoInicio, DateTime periodoFin, int idUsuario);
        byte[] ReporteEventoTipoEventoPeriodo(DateTime periodoInicio, DateTime periodoFin, int idTipoEvento);
        byte[] ReporteEventoInstalacionPeriodo(DateTime periodoInicio, DateTime periodoFin, int idInstalacion);
    }
}

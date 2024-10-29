namespace ApiNet8.Services.IServices
{
    public interface IReporteServices
    {
        byte[] ReporteEventoUsuarioPeriodo(DateTime periodoInicio, DateTime periodoFin, int idUsuario);
        byte[] ReporteEventoTipoEventoPeriodo(DateTime periodoInicio, DateTime periodoFin, int idTipoEvento);
        byte[] ReporteEventoInstalacionPeriodo(DateTime periodoInicio, DateTime periodoFin, int idInstalacion);
        byte[] ReporteEventoByEvento(int idEvento);
        byte[] ReporteEstadisticaDiscUsuPeriodo(DateTime periodoInicio, DateTime periodoFin, int idDisciplina, int idUsuario);
        byte[] ReporteEstadisticaDiscUsuLeccionPeriodo(DateTime periodoInicio, DateTime periodoFin, int idDisciplina, int idLeccion, int idUsuario);
        byte[] ReporteEstadisticaDiscEquipoPeriodo(DateTime periodoInicio, DateTime periodoFin, int idDisciplina, int idEquipo);
        byte[] ReporteReservaUsuarioPeriodo(DateTime periodoInicio, DateTime periodoFin, int idUsuario);
    }
}

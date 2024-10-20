using ApiNet8.Models.DTO;
using ApiNet8.Models.Partidos;

namespace ApiNet8.Services.IServices
{
    public interface IPartidoServices
    {
        List<Partido> GetPartidos();//
        List<Partido> GetPartidosAsignados();//
        Partido GetPartidoById(int Id);//
        void IniciarPartido(PartidoDTO partidoDTO);//
        void SuspenderPartido(PartidoDTO partidoDTO);//
        void FinalizarPartido(int partidoId);//
        void IniciarTiempo(int partidoId);//
        void FinalizarTiempo(int partidoId);//
        List<AccionPartido> GetAccionPartidoByPartido(int IdPartido);//
        List<AccionPartido> GetAccionPartidoByPartidoTipoAccion(AccionPartidoDTO accion);//
        AccionPartidoDTO AltaAccionPartido(AccionPartidoDTO accion);//
        AccionPartido GetAccionPartidoById(int Id);//
        void BajaAccionPartido(int idAccionPartido, int idPartido);//

        List<EquipoUsuario> GetEquipoLocal(int partidoId);//
        List<EquipoUsuario> GetEquipoVisitante(int partidoId);//

        //Estadisticas
        Estadistica AltaEstadistica(EstadisticaDTO estadisticaDTO);//
        List<Estadistica> GetEstadisticasByUsuario(int IdUsuario, bool leccion);//
        Estadistica GetEstadisticaById(int Id);
        void ActualizarEstadistica(EstadisticaDTO estadisticaDTO); //
        void BajaEstadistica(EstadisticaDTO estadisticaDTO);//

    }
}

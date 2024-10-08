using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Partidos;

namespace ApiNet8.Services.IServices
{
    public interface IEquipoServices
    {
        List<EquipoResponseDTO> GetEquipos();
        EquipoResponseDTO GetEquipoById(int id);
        Equipo CrearEquipo(EquipoDTO equipoDTO);
        void ActualizarEquipo(EquipoDTO equipoDTO);
        void EliminarEquipo(EquipoDTO equipoDTO);
        bool ExisteEquipo(string nombre);
        List<EquipoResponseDTO> GetEquiposActivos();
        List<EquipoResponseDTO> GetEquiposByCategoriaAndDisciplinaActivos(int IdCategoria, int IdDisciplina);
    }
}

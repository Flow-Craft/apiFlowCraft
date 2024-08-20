using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;

namespace ApiNet8.Services.IServices
{
    public interface IDisciplinasYLeccionesServices
    {
        List<Disciplina> GetDisciplinas();
        Disciplina? GetDisciplinaById(int id);
        void CrearDisciplina(DisciplinaDTO disciplina);
        void ActualizarDisciplina(DisciplinaDTO disciplina);
        void EliminarDisciplina(int id);
        List<DisciplinaMenuDTO> GetDisciplinasMenu();
    }
}

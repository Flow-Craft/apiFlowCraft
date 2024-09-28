using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;

namespace ApiNet8.Services.IServices
{
    public interface ICategoriaServices
    {
        List<Categoria> GetCategoria();
        Categoria GetCategoriaById(int Id);
        void CrearCategoria(CategoriaDTO categoriaDTO);
        void ActualizarCategoria(CategoriaDTO categoriaDTO);
        void EliminarCategoria(CategoriaDTO categoriaDTO);
        bool ExisteCategoria(string nombre);
        List<Categoria> GetCategoriaActivas();
    }
}

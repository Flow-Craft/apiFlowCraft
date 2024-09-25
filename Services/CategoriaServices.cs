using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;

namespace ApiNet8.Services
{
    public class CategoriaServices : ICategoriaServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CategoriaServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public List<Categoria> GetCategoria()
        {
            return _db.Categoria.ToList();
        }

        public List<Categoria> GetCategoriaActivas()
        {
            return _db.Categoria.Where(a => a.FechaBaja == null).ToList();
        }

        public Categoria GetCategoriaById(int id)
        {
            try
            {
                return _db.Categoria.Where(u => u.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteCategoria(string nombre)
        {
            Categoria? categoria = _db.Categoria.Where(n => n.Nombre.Equals(nombre) && n.FechaBaja == null).FirstOrDefault();

            return categoria != null ? true : false;

        }

        public void CrearCategoria(CategoriaDTO categoriaDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Categoria categoria = _mapper.Map<Categoria>(categoriaDTO);

                if (ExisteCategoria(categoria.Nombre))
                {
                    throw new Exception("Ya existe una categoria con ese nombre.");
                }

                categoria.FechaCreacion = DateTime.Now;
                categoria.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Add(categoria);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void ActualizarCategoria(CategoriaDTO categoriaDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Categoria categoria = GetCategoriaById(categoriaDTO.Id);

                categoria.FechaModificacion = DateTime.Now;
                categoria.Descripcion = categoriaDTO.Descripcion ?? categoria.Descripcion;
                categoria.Nombre = categoriaDTO.Nombre ?? categoria.Nombre;
                categoria.UsuarioEditor = currentUser != null ? currentUser.Id : 0;
                categoria.EdadMaxima = categoriaDTO?.EdadMaxima != null ? categoriaDTO.EdadMaxima : categoria.EdadMaxima;
                categoria.EdadMinima = categoriaDTO?.EdadMinima != null ? categoriaDTO.EdadMinima : categoria.EdadMinima;
                categoria.Genero = categoriaDTO?.Genero ?? categoria.Genero;

                if (categoriaDTO?.Nombre != null)
                {
                    bool existe = _db.Categoria.Any(le => le.Nombre == categoriaDTO.Nombre && le.Id != categoria.Id && le.FechaBaja == null);

                    if (existe)
                    {
                        throw new Exception("Ya existe una categoria con ese nombre.");
                    }
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Categoria.Update(categoria);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void EliminarCategoria(CategoriaDTO categoriaDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Categoria categoria = GetCategoriaById(categoriaDTO.Id);

                if (categoria == null)
                {
                    throw new Exception("No existe la categoria que quieres eliminar.");
                }

                if (categoria.FechaBaja != null)
                {
                    throw new Exception("La categoria ya esta eliminada.");
                }

                categoria.FechaBaja = DateTime.Now;
                categoria.FechaModificacion = DateTime.Now;
                categoria.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Categoria.Update(categoria);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}

using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using ApiNet8.Models.Usuarios;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace ApiNet8.Services
{
    public class LeccionesServices 
        //: 
        //ILeccionesServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILeccionEstadoServices _leccionEstadoServices;

        public LeccionesServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, ILeccionEstadoServices leccionEstadoServices)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _leccionEstadoServices = leccionEstadoServices;
        }

        public List<Leccion> GetLecciones()
        {
            List<Leccion> lecciones = _db.Leccion.Include(d=>d.Disciplina).Include(c=>c.Categoria).Include(lh=>lh.LeccionHistoriales).ThenInclude(le=>le.LeccionEstado).ToList();
            return lecciones;
        }

        public List<Leccion> GetLeccionesActivas()
        {
            List<Leccion> lecciones = _db.Leccion
            .Include(d => d.Disciplina)
            .Include(c => c.Categoria)
            .Include(lh => lh.LeccionHistoriales)
                .ThenInclude(le => le.LeccionEstado)
            .Where(l => l.LeccionHistoriales.Any(h =>
                h.FechaFin == null && 
                (h.LeccionEstado.NombreEstado == "Vigente" || h.LeccionEstado.NombreEstado == "Clase Iniciada"))) 
            .ToList();

            return lecciones;
        }

        public Leccion GetLeccionById(int id)
        {
            try
            {
                return _db.Leccion.Include(d => d.Disciplina).Include(c => c.Categoria).Include(lh => lh.LeccionHistoriales).ThenInclude(le => le.LeccionEstado).Where(u => u.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteLeccion(string nombre)
        {
            Leccion? leccion = _db.Leccion.Include(lh => lh.LeccionHistoriales).ThenInclude(le => le.LeccionEstado)
                .Where(n => n.Nombre.Equals(nombre) && n.LeccionHistoriales.Any(h => h.FechaFin == null &&
                (h.LeccionEstado.NombreEstado == "Vigente" || h.LeccionEstado.NombreEstado == "Clase Iniciada")))
                .FirstOrDefault();

            return leccion != null ? true : false;

        }

        public void CrearLeccion(LeccionDTO leccionDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Leccion leccion = _mapper.Map<Leccion>(leccionDTO);

                if (ExisteLeccion(leccion.Nombre))
                {
                    throw new Exception("Ya existe una leccion con ese nombre.");
                }

                // crear historial de leccion y asignarle estado Vigente
                LeccionHistorial leccionHistorial = new LeccionHistorial
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se crea nueva leccion",
                    UsuarioEditor = currentUser?.Id,
                    LeccionEstado = _leccionEstadoServices.GetLeccionEstadoById(1) // asigno estado vigente
                };
                leccion.LeccionHistoriales = new List<LeccionHistorial>();
                leccion.LeccionHistoriales.Add(leccionHistorial);

                // asignarle la categoria y disciplina
                leccion.Categoria = _db.Categoria.Where(u => u.Id == leccionDTO.IdCategoria).FirstOrDefault();
                leccion.Disciplina = _db.Disciplina.Where(d => d.Id == leccionDTO.IdDisciplina).FirstOrDefault();

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.LeccionHistorial.Add(leccionHistorial);
                    _db.Add(leccion);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        //public void ActualizarLeccion(LeccionDTO leccionDTO)
        //{
        //    try
        //    {
        //        // Obtener el usuario actual desde la sesión
        //        var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

        //        Categoria categoria = GetCategoriaById(categoriaDTO.Id);

        //        categoria.FechaModificacion = DateTime.Now;
        //        categoria.Descripcion = categoriaDTO.Descripcion ?? categoria.Descripcion;
        //        categoria.Nombre = categoriaDTO.Nombre ?? categoria.Nombre;
        //        categoria.UsuarioEditor = currentUser != null ? currentUser.Id : 0;
        //        categoria.EdadMaxima = categoriaDTO?.EdadMaxima != null ? categoriaDTO.EdadMaxima : categoria.EdadMaxima;
        //        categoria.EdadMinima = categoriaDTO?.EdadMinima != null ? categoriaDTO.EdadMinima : categoria.EdadMinima;
        //        categoria.Genero = categoriaDTO?.Genero ?? categoria.Genero;

        //        if (categoriaDTO?.Nombre != null)
        //        {
        //            bool existe = _db.Categoria.Any(le => le.Nombre == categoriaDTO.Nombre && le.Id != categoria.Id && le.FechaBaja == null);

        //            if (existe)
        //            {
        //                throw new Exception("Ya existe una categoria con ese nombre.");
        //            }
        //        }

        //        using (var transaction = _db.Database.BeginTransaction())
        //        {
        //            _db.Categoria.Update(categoria);
        //            _db.SaveChanges();
        //            transaction.Commit();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message, e);
        //    }
        //}

        //public void EliminarCategoria(CategoriaDTO categoriaDTO)
        //{
        //    try
        //    {
        //        // Obtener el usuario actual desde la sesión
        //        var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

        //        Categoria categoria = GetCategoriaById(categoriaDTO.Id);

        //        if (categoria == null)
        //        {
        //            throw new Exception("No existe la categoria que quieres eliminar.");
        //        }

        //        if (categoria.FechaBaja != null)
        //        {
        //            throw new Exception("La categoria ya esta eliminada.");
        //        }

        //        categoria.FechaBaja = DateTime.Now;
        //        categoria.FechaModificacion = DateTime.Now;
        //        categoria.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

        //        using (var transaction = _db.Database.BeginTransaction())
        //        {
        //            _db.Categoria.Update(categoria);
        //            _db.SaveChanges();
        //            transaction.Commit();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message, e);
        //    }
        //}
    }
}

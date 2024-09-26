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
    public class LeccionesServices : ILeccionesServices
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
                (h.LeccionEstado.NombreEstado == Enums.LeccionEstado.Vigente.ToString() || h.LeccionEstado.NombreEstado == Enums.LeccionEstado.ClaseIniciada.ToString()))) 
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
                (h.LeccionEstado.NombreEstado == Enums.LeccionEstado.Vigente.ToString() || h.LeccionEstado.NombreEstado == Enums.LeccionEstado.ClaseIniciada.ToString())))
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

        public void ActualizarLeccion(LeccionDTO leccionDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Leccion leccion = GetLeccionById(leccionDTO.Id);

                leccion.CantMaxima = leccionDTO?.CantMaxima != null ? leccionDTO.CantMaxima : leccion.CantMaxima;
                leccion.Dias = leccionDTO?.Dias ?? leccion.Dias;
                leccion.Nombre = leccionDTO?.Nombre ?? leccion.Nombre;
                leccion.Descripcion = leccionDTO?.Descripcion ?? leccion.Descripcion;
                leccion.Horarios = leccionDTO?.Horarios ?? leccion.Horarios;
                leccion.Lugar = leccionDTO?.Lugar ?? leccion.Lugar;
                
                if (leccionDTO?.Nombre != null)
                {
                    bool existe = _db.Leccion.Include(a=>a.LeccionHistoriales).Any(le => (le.Nombre == leccionDTO.Nombre && le.Id != leccionDTO.Id) && le.LeccionHistoriales.Any(h => h.FechaFin == null &&
                (h.LeccionEstado.NombreEstado == ApiNet8.Utils.Enums.LeccionEstado.Vigente.ToString() || h.LeccionEstado.NombreEstado == ApiNet8.Utils.Enums.LeccionEstado.ClaseIniciada.ToString())));

                    if (existe)
                    {
                        throw new Exception("Ya existe una leccion con ese nombre.");
                    }
                }

                // crear historial de leccion y asignarle estado Vigente
                LeccionHistorial leccionHistorial = new LeccionHistorial
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se modifica leccion",
                    UsuarioEditor = currentUser?.Id,
                    LeccionEstado = _leccionEstadoServices.GetLeccionEstadoById(1) // asigno estado vigente
                };
                leccion.LeccionHistoriales = new List<LeccionHistorial>();
                leccion.LeccionHistoriales.Add(leccionHistorial);

                // se finaliza historial anterior
                LeccionHistorial? ultimoHistorial = leccion.LeccionHistoriales.Where(le => le.FechaFin == null).FirstOrDefault();
                if (ultimoHistorial != null)
                {
                    ultimoHistorial.FechaFin = DateTime.Now;
                    _db.LeccionHistorial.Update(ultimoHistorial);
                }

                // asignarle la categoria y disciplina
                leccion.Categoria = leccionDTO?.IdCategoria != null ? _db.Categoria.Where(u => u.Id == leccionDTO.IdCategoria).FirstOrDefault() : leccion.Categoria;
                leccion.Disciplina = leccionDTO?.IdDisciplina != null ? _db.Disciplina.Where(d => d.Id == leccionDTO.IdDisciplina).FirstOrDefault() : leccion.Disciplina;


                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.LeccionHistorial.Add(leccionHistorial);
                    _db.Leccion.Update(leccion);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void EliminarLeccion(LeccionDTO leccionDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Leccion leccion = GetLeccionById(leccionDTO.Id);

                if (leccion == null)
                {
                    throw new Exception("No existe la leccion que quieres eliminar.");
                }
                
                // obtener ultimo historial
                LeccionHistorial? ultimoHistorial = leccion.LeccionHistoriales.Where(f=> f.FechaFin == null).FirstOrDefault();
                if (ultimoHistorial == null)
                {
                    if (ultimoHistorial.LeccionEstado.NombreEstado == ApiNet8.Utils.Enums.LeccionEstado.Eliminada.ToString())
                    {
                    throw new Exception("Esta leccion ya ha sido eliminada");
                    }

                    ultimoHistorial.FechaFin = DateTime.Now;
                    _db.LeccionHistorial.Update(ultimoHistorial);
                }

                // crear nuevo historial
                LeccionHistorial leccionHistorial = new LeccionHistorial
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se elimina leccion",
                    UsuarioEditor = currentUser?.Id,
                    LeccionEstado = _leccionEstadoServices.GetLeccionEstadoById(4) // se asigna estado eliminada
                };                

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.LeccionHistorial.Add(leccionHistorial);               
                    _db.Leccion.Update(leccion);
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

using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Torneos;
using ApiNet8.Models;
using ApiNet8.Utils;
using AutoMapper;
using ApiNet8.Services.IServices;
using ApiNet8.Models.Partidos;
using ApiNet8.Models.Lecciones;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiNet8.Services
{
    public class TipoAccionPartidoServices : ITipoAccionPartidoServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDisciplinasYLeccionesServices _disciplinasYLeccionesServices;

        public TipoAccionPartidoServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, IDisciplinasYLeccionesServices disciplinasYLeccionesServices)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _disciplinasYLeccionesServices = disciplinasYLeccionesServices;
        }

        public List<TipoAccionPartido> GetTiposAccionPartido()
        {
            List <TipoAccionPartido> acciones = _db.TipoAccionPartido.Include(d=>d.Disciplina).ToList();
            return acciones;
        }

        public List<TipoAccionPartido> GetTiposAccionPaneles(TipoAccionPartidoDTO tipAc)
        {
            List<TipoAccionPartido> acciones = new List<TipoAccionPartido>();

            if (tipAc.IdDisciplina == 1)
            {
                if (tipAc.Estadistica == true)
                {
                    if (tipAc.Partido == true)
                    {
                        acciones = _db.TipoAccionPartido.Include(d => d.Disciplina).Where(a => a.FechaBaja == null && a.Disciplina.Id == tipAc.IdDisciplina && a.NombreTipoAccion != "Cambio Jugador").ToList();
                    }
                    else {
                        acciones = _db.TipoAccionPartido.Include(d => d.Disciplina).Where(a => a.FechaBaja == null && a.Disciplina.Id == tipAc.IdDisciplina && a.NombreTipoAccion != "Tarjeta Amarilla" && a.NombreTipoAccion != "Tarjeta Roja" && a.NombreTipoAccion != "Cambio Jugador").ToList();
                    }
                }
                else
                {
                    acciones = _db.TipoAccionPartido.Include(d => d.Disciplina).Where(a => a.FechaBaja == null && a.Disciplina.Id == tipAc.IdDisciplina && (a.NombreTipoAccion == "Tarjeta Amarilla" || a.NombreTipoAccion == "Tarjeta Roja" || a.NombreTipoAccion == "Falta" || a.NombreTipoAccion == "Gol" || a.NombreTipoAccion == "Cambio Jugador")).ToList();
                } 
            }
            if (tipAc.IdDisciplina == 2)
            {
                if (tipAc.Estadistica == true)
                {
                    acciones = _db.TipoAccionPartido.Include(d => d.Disciplina).Where(a => a.FechaBaja == null && a.Disciplina.Id == tipAc.IdDisciplina && a.NombreTipoAccion != "Tarjeta Amarilla" && a.NombreTipoAccion != "Tarjeta Roja" && a.NombreTipoAccion != "Cambio Jugador" && a.NombreTipoAccion != "Punto").ToList();
                    
                }
                else
                {
                    acciones = _db.TipoAccionPartido.Include(d => d.Disciplina).Where(a => a.FechaBaja == null && a.Disciplina.Id == tipAc.IdDisciplina && (a.NombreTipoAccion == "Tarjeta Amarilla" || a.NombreTipoAccion == "Tarjeta Roja" ||  a.NombreTipoAccion == "Punto" || a.NombreTipoAccion == "Cambio Jugador")).ToList();
                }
            }
            return acciones;
        }
        public List<TipoAccionPartido> GetTiposAccionVoley(bool leccion)
        {
            List<TipoAccionPartido> acciones = new List<TipoAccionPartido>();

            if (leccion)
            {
                acciones = _db.TipoAccionPartido.Include(d => d.Disciplina).
                Where(a => a.FechaBaja == null && a.Disciplina.Nombre == "Voleyball" &&
                (a.NombreTipoAccion != "Tarjeta Amarilla" || a.NombreTipoAccion != "Tarjeta Roja" || a.NombreTipoAccion != "Punto" || a.NombreTipoAccion != "Cambio Jugador")).ToList();
            }
            else
            {
                acciones = _db.TipoAccionPartido.Include(d => d.Disciplina).
                Where(a => a.FechaBaja == null && a.Disciplina.Nombre == "Voleyball" &&
                (a.NombreTipoAccion == "Tarjeta Amarilla" || a.NombreTipoAccion == "Tarjeta Roja" || a.NombreTipoAccion == "Punto" || a.NombreTipoAccion == "Cambio Jugador")).ToList();
            }
            return acciones;
        }

        public List<TipoAccionPartido> GetTiposAccionLeccionByDisciplina(int idDis, bool leccion)
        {
            List<TipoAccionPartido> acciones = _db.TipoAccionPartido.Include(d => d.Disciplina).Where(a => a.FechaBaja == null && a.Disciplina.Id == idDis).ToList();

            if (leccion)
            {
                acciones.RemoveAll(a => a.NombreTipoAccion == "Tarjeta Amarilla" || a.NombreTipoAccion == "Tarjeta Roja");
            }

            return acciones;
        }

        public List<TipoAccionPartido> GetTiposAccionPartidoActivos()
        {
            return _db.TipoAccionPartido.Where(a => a.FechaBaja == null).ToList();
        }

        public TipoAccionPartido GetTipoAccionPartidoById(int id)
        {
            try
            {
                return _db.TipoAccionPartido.Where(u => u.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteTipoAccionPartido(string nombre)
        {
            TipoAccionPartido? tipoAccionPartido = _db.TipoAccionPartido.Where(n => n.NombreTipoAccion.Equals(nombre) && n.FechaBaja == null).FirstOrDefault();

            return tipoAccionPartido != null ? true : false;

        }

        public void CrearTipoAccionPartido(TipoAccionPartidoDTO tipoAccionPartidoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                TipoAccionPartido tipoAccionPartido = _mapper.Map<TipoAccionPartido>(tipoAccionPartidoDTO);

                if (ExisteTipoAccionPartido(tipoAccionPartido.NombreTipoAccion))
                {
                    throw new Exception("Ya existe un tipo de accion de partido con ese nombre.");
                }
                Disciplina? disciplina = new Disciplina();

                if (tipoAccionPartidoDTO.IdDisciplina == null)
                {
                    throw new Exception("Debe seleccionar una disciplina");
                }
                else
                {
                    disciplina = _disciplinasYLeccionesServices.GetDisciplinaById((int)tipoAccionPartidoDTO.IdDisciplina);
                    if (disciplina == null)
                    {
                        throw new Exception("No existe la disciplina seleccionada");
                    }
                }
                
                tipoAccionPartido.FechaCreacion = DateTime.Now;
                tipoAccionPartido.UsuarioEditor = currentUser != null ? currentUser.Id : 0;
                tipoAccionPartido.Disciplina = disciplina;   

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Add(tipoAccionPartido);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void ActualizarTipoAccionPartido(TipoAccionPartidoDTO tipoAccionPartidoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                TipoAccionPartido tipoAccionPartido = GetTipoAccionPartidoById(tipoAccionPartidoDTO.Id);

                tipoAccionPartido.FechaModificacion = DateTime.Now;
                tipoAccionPartido.Descripcion = tipoAccionPartidoDTO.Descripcion ?? tipoAccionPartido.Descripcion;
                tipoAccionPartido.NombreTipoAccion = tipoAccionPartidoDTO.NombreTipoAccion ?? tipoAccionPartido.NombreTipoAccion;
                tipoAccionPartido.ModificaTarjetasAdvertencia = tipoAccionPartidoDTO.ModificaTarjetasAdvertencia ?? tipoAccionPartido.ModificaTarjetasAdvertencia;
                tipoAccionPartido.ModificaTarjetasExpulsion = tipoAccionPartidoDTO.ModificaTarjetasExpulsion ?? tipoAccionPartido.ModificaTarjetasExpulsion;
                tipoAccionPartido.secuencial = tipoAccionPartidoDTO.secuencial ?? tipoAccionPartido.secuencial;
                tipoAccionPartido.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                if (tipoAccionPartidoDTO.IdDisciplina != null)
                {
                    Disciplina? nuevaDisciplina = _disciplinasYLeccionesServices.GetDisciplinaById((int)tipoAccionPartidoDTO.IdDisciplina);

                    tipoAccionPartido.Disciplina = nuevaDisciplina ?? tipoAccionPartido.Disciplina;
                }
                               

                if (tipoAccionPartidoDTO.NombreTipoAccion != null)
                {
                    bool existe = _db.TipoAccionPartido.Any(le => le.NombreTipoAccion == tipoAccionPartidoDTO.NombreTipoAccion && le.Id != tipoAccionPartido.Id && le.FechaBaja == null);

                    if (existe)
                    {
                        throw new Exception("Ya existe un tipo de accion con ese nombre.");
                    }
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.TipoAccionPartido.Update(tipoAccionPartido);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void EliminarTipoAccionPartido(TipoAccionPartidoDTO tipoAccionPartidoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                TipoAccionPartido tipoAccionPartido = GetTipoAccionPartidoById(tipoAccionPartidoDTO.Id);

                if (tipoAccionPartido == null)
                {
                    throw new Exception("No existe el tipo de accion que quieres eliminar.");
                }

                if (tipoAccionPartido.FechaBaja != null)
                {
                    throw new Exception("El tipo de accion ya esta eliminado.");
                }

                tipoAccionPartido.FechaBaja = DateTime.Now;
                tipoAccionPartido.FechaModificacion = DateTime.Now;
                tipoAccionPartido.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.TipoAccionPartido.Update(tipoAccionPartido);
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

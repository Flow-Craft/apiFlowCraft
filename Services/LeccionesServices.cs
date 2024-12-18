﻿using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using ApiNet8.Models.Usuarios;
using Microsoft.EntityFrameworkCore;
using System.Xml;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Partidos;
using ApiNet8.Models.Reservas;
using XAct;

namespace ApiNet8.Services
{
    public class LeccionesServices : ILeccionesServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILeccionEstadoServices _leccionEstadoServices;
        private readonly IEmailService _emailService;
        private readonly IUsuarioServices _usuarioServices;

        public LeccionesServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, ILeccionEstadoServices leccionEstadoServices, IEmailService emailService, IUsuarioServices usuarioServices)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _leccionEstadoServices = leccionEstadoServices;
            _emailService = emailService;
            _usuarioServices = usuarioServices;
        }

        public List<Leccion> GetLecciones()
        {
            List<Leccion> lecciones = _db.Leccion.Include(d=>d.Disciplina).Include(c=>c.Categoria).ToList();
            return lecciones;
        }

        public List<LeccionResponseDTO> GetLeccionesCompletas()
        {
            List<Leccion> lecciones = _db.Leccion.Include(d => d.Disciplina).Include(c => c.Categoria).Include(h=>h.LeccionHistoriales).ThenInclude(le=>le.LeccionEstado).ToList();
            List<LeccionResponseDTO> response = new List<LeccionResponseDTO>();

            foreach (var item in lecciones)
            {
                LeccionResponseDTO le = new LeccionResponseDTO
                {
                    Id = item.Id,
                    CantMaxima = item.CantMaxima,
                    Descripcion = item.Descripcion,
                    Dias = item.Dias,
                    Nombre = item.Nombre,
                    Horarios = item.Horarios,
                    Lugar = item.Lugar,
                    idProfesor = item.idProfesor,
                    Disciplina = item.Disciplina,
                    Categoria = item.Categoria,
                    Activa = false
                };

                LeccionHistorial? ultimoHistorial = item.LeccionHistoriales.Where(l => l.FechaFin == null).OrderByDescending(f => f.FechaInicio).FirstOrDefault();
                if (ultimoHistorial != null && (ultimoHistorial.LeccionEstado.NombreEstado == Enums.LeccionEstado.Vigente.ToString() || ultimoHistorial.LeccionEstado.NombreEstado == Enums.LeccionEstado.ClaseIniciada.ToString()))
                {
                    le.Activa = true;
                }

                response.Add(le);
            }

            return response;
        }

        public List<Leccion> GetLeccionesActivas()
        {
            List<Leccion> lecciones = _db.Leccion
            .Include(d => d.Disciplina)
            .Include(c => c.Categoria)
            //.Include(lh => lh.LeccionHistoriales)
            //    .ThenInclude(le => le.LeccionEstado)
            .Where( l => l.LeccionHistoriales.Any(h =>
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

        public List<Leccion> GetLeccionesAsignadas()
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                List<Leccion> lecciones = _db.Leccion
                .Include(d => d.Disciplina)
                .Include(c => c.Categoria)
                .Include(lh => lh.LeccionHistoriales)
                .ThenInclude(le => le.LeccionEstado)
                .Where(l => l.LeccionHistoriales.Any(h =>
                    h.FechaFin == null &&
                    (h.LeccionEstado.NombreEstado != Enums.LeccionEstado.Eliminada.ToString()))
                    && l.idProfesor==currentUser.Id)
                .ToList();

                return lecciones;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<ReporteLeccionDTO> GetAsistenciasByUsuarioAndPeriodo(int idUsuario, DateTime periodoInicio, DateTime periodoFin)
        {
            try
            {
                List<AsistenciaLeccion> leccionesDadas = _db.AsistenciaLeccion
                .Include(d => d.Leccion)
                .ThenInclude(c => c.Categoria)
                .Include(d => d.Leccion)
                .ThenInclude(c => c.Disciplina)
                .Where(l => l.FechaCreacion >= periodoInicio && l.FechaCreacion <= periodoFin && l.FechaBaja==null)
                .GroupBy(l => l.FechaCreacion)
                .Select(g => g.First())
                .ToList();

                List<AsistenciaLeccion> leccionesAsistidas = _db.AsistenciaLeccion
                .Where(l => l.FechaCreacion >= periodoInicio && l.FechaCreacion <= periodoFin && l.Usuario.Id==idUsuario && l.FechaBaja==null)
                .ToList();

                List<ReporteLeccionDTO> lecciones = new List<ReporteLeccionDTO>();

                foreach (var leccion in leccionesDadas)
                {
                    var asistio = leccionesAsistidas.Any(a => a.FechaCreacion == leccion.FechaCreacion);

                    Usuario prof = _usuarioServices.GetUsuarioById(leccion.Leccion.idProfesor);

                    lecciones.Add(new ReporteLeccionDTO
                    {
                        Disciplina = leccion.Leccion.Disciplina.Nombre,
                        Categoria = leccion.Leccion.Categoria.Nombre,
                        FechaLeccion = leccion.FechaCreacion,
                        NomProfesor = prof.Apellido + ", " + prof.Nombre,
                        Asistencia = asistio ? "Sí" : "No"
                    });
                }

                List<ReporteLeccionDTO> asistenciasOrdenadas = lecciones
                .OrderBy(a => a.Disciplina)
                .ThenBy(a => a.Categoria)
                .ThenBy(a => a.FechaLeccion)
                .ToList();

                return asistenciasOrdenadas;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<ReporteLeccionDTO> GetAsistenciasByDisciplinaCategoriaAndPeriodo(int idDisciplina, int idCategoria, DateTime periodoInicio, DateTime periodoFin)
        {
            try
            {
                List<InscripcionUsuario> inscripciones = _db.InscripcionUsuario
                .Include(d => d.Leccion)
                .ThenInclude(c => c.Categoria)
                .Include(d => d.Leccion)
                .ThenInclude(c => c.Disciplina)
                .Where(l => l.Leccion.Disciplina.Id == idDisciplina && l.Leccion.Categoria.Id <= idCategoria && l.FechaBaja == null)
                .ToList();

                List<AsistenciaLeccion> leccionesDadas = _db.AsistenciaLeccion
                .Include(d => d.Leccion)
                .ThenInclude(c => c.Categoria)
                .Include(d => d.Leccion)
                .ThenInclude(c => c.Disciplina)
                .Where(l => l.FechaCreacion >= periodoInicio && l.FechaCreacion <= periodoFin && l.Leccion.Disciplina.Id == idDisciplina && l.Leccion.Categoria.Id <= idCategoria && l.FechaBaja == null)
                .GroupBy(l => l.FechaCreacion)
                .Select(g => g.First())
                .ToList();


                List<ReporteLeccionDTO> lecciones = new List<ReporteLeccionDTO>();

                foreach (var leccion in leccionesDadas)
                {
                    foreach (var insc in inscripciones)
                    {
                        var asistio = _db.AsistenciaLeccion.Where(a=> a.Usuario.Id==insc.UsuarioId && a.Leccion.Disciplina.Id == insc.Leccion.Disciplina.Id && a.Leccion.Categoria.Id== insc.Leccion.Categoria.Id && a.FechaBaja==null)
                        .Any(a => a.FechaCreacion == leccion.FechaCreacion);

                        Usuario prof = _usuarioServices.GetUsuarioById(leccion.Leccion.idProfesor);

                        Usuario alumno = _usuarioServices.GetUsuarioById(insc.UsuarioId);

                        lecciones.Add(new ReporteLeccionDTO
                        {
                            FechaLeccion = leccion.FechaCreacion,
                            DniAlumno = alumno.Dni,
                            NomAlumno = alumno.Apellido + ", " + alumno.Nombre,
                            NomProfesor = prof.Apellido + ", " + prof.Nombre,
                            Asistencia = asistio ? "Sí" : "No"
                        });
                    }
                }

                List<ReporteLeccionDTO> asistenciasOrdenadas = lecciones
                .OrderBy(a => a.FechaLeccion)
                .ToList();

                return asistenciasOrdenadas;
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
                leccion.idProfesor = leccionDTO?.idProfesor ?? leccion.idProfesor;
                
                if (leccionDTO?.Nombre != null)
                {
                    bool existe = _db.Leccion.Include(a=>a.LeccionHistoriales).Any(le => (le.Nombre == leccionDTO.Nombre && le.Id != leccionDTO.Id) && le.LeccionHistoriales.Any(h => h.FechaFin == null &&
                (h.LeccionEstado.NombreEstado == ApiNet8.Utils.Enums.LeccionEstado.Vigente.ToString() || h.LeccionEstado.NombreEstado == ApiNet8.Utils.Enums.LeccionEstado.ClaseIniciada.ToString())));

                    if (existe)
                    {
                        throw new Exception("Ya existe una leccion con ese nombre.");
                    }
                }

                // se finaliza historial anterior
                LeccionHistorial? ultimoHistorial = leccion.LeccionHistoriales.Where(le => le.FechaFin == null).FirstOrDefault();
                if (ultimoHistorial != null)
                {
                    ultimoHistorial.FechaFin = DateTime.Now;
                    _db.LeccionHistorial.Update(ultimoHistorial);
                }
                else
                {
                    leccion.LeccionHistoriales = new List<LeccionHistorial>();
                }

                // crear historial de leccion y asignarle estado Vigente
                LeccionHistorial leccionHistorial = new LeccionHistorial
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se modifica leccion",
                    UsuarioEditor = currentUser?.Id,
                    LeccionEstado = _leccionEstadoServices.GetLeccionEstadoById(1) // asigno estado vigente
                };
                
                leccion.LeccionHistoriales.Add(leccionHistorial);
               

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
                if (ultimoHistorial != null)
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
                leccion.LeccionHistoriales.Add(leccionHistorial);

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

        public List<InscripcionUsuario> GetInscripcionesALecciones(int id)
        {
            List<InscripcionUsuario> inscripciones = _db.InscripcionUsuario.
                Include(e => e.Leccion).
                ThenInclude(e => e.LeccionHistoriales).
                ThenInclude(e => e.LeccionEstado).
                Where(i => i.Leccion.Id == id).ToList();

            return inscripciones;
        }

        public List<InscripcionUsuario> GetInscripcionesLeccionVigentes(int id)
        {
            List<InscripcionUsuario> inscripciones = _db.InscripcionUsuario.
                Include(e => e.Leccion).
                ThenInclude(e => e.LeccionHistoriales).
                ThenInclude(e => e.LeccionEstado).
                Where(i => i.Leccion.Id == id && i.FechaBaja == null).ToList();
            return inscripciones;
        }

        public List<InscripcionUsuario> GetInscripcionesByUsuario()
        {
            var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

            if (currentUser == null)
            {
                throw new Exception("Current user es null");
            }

            List<InscripcionUsuario> inscripciones = _db.InscripcionUsuario.
                Include(e => e.Leccion).
                ThenInclude(e => e.LeccionHistoriales).
                ThenInclude(e => e.LeccionEstado).
                Where(u => u.UsuarioId == currentUser.Id).ToList();
            return inscripciones;
        }

        public List<InscripcionUsuario> GetInscripcionesByUsuarioActivas()
        {
            var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

            if (currentUser == null)
            {
                throw new Exception("Current user es null");
            }

            List<InscripcionUsuario> inscripciones = _db.InscripcionUsuario.
                Include(e => e.Leccion).
                ThenInclude(e => e.LeccionHistoriales).
                ThenInclude(e => e.LeccionEstado).
                Where(u => u.UsuarioId == currentUser.Id && u.FechaBaja == null).ToList();
            return inscripciones;
        }

        public void InscribirseALeccion(InscripcionLeccionDTO inscripcion)//listo
        {
            try
            {
                
                // verificar si existe leccion
                Leccion leccion = GetLeccionById(inscripcion.IdLeccion);
                List<InscripcionUsuario> alumnosInsc = GetInscripcionesLeccionVigentes(leccion.Id);
                
                if (leccion == null)
                {
                    throw new Exception("No existe la lección");
                }

                // verificar si hay cupo disponible
                if (alumnosInsc.Count() == leccion.CantMaxima)
                {
                    throw new Exception("La lección esta completa.");
                }

                // verificar estado leccion
                if (leccion?.LeccionHistoriales?.Where(f => f.FechaFin == null)?.OrderByDescending(f => f.FechaInicio)?.FirstOrDefault()?.LeccionEstado.NombreEstado == Enums.LeccionEstado.Eliminada.ToString())
                {
                    throw new Exception("Las inscripciones a la lección estan cerradas: la lección ya no esta vigente.");
                }

                // verificar si ya esta inscripto
                List<InscripcionUsuario> inscripciones = _db.InscripcionUsuario.Include(e => e.Leccion).Where(u => u.UsuarioId == inscripcion.IdUsuario && u.Leccion.Id == inscripcion.IdLeccion && u.FechaBaja == null).ToList();
                if (inscripciones.Count() > 0)
                {
                    throw new Exception("El usuario ya esta inscripto para esta lección.");
                }

                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                // verificar estado del usuario y perfil
                Usuario? usuario = _db.Usuario
                        .Include(u => u.UsuarioHistoriales).ThenInclude(a => a.UsuarioEstado)
                        .Where(u => u.Id == currentUser.Id)
                        .FirstOrDefault();

                if (usuario == null)
                {
                    throw new Exception("No existe el usuario que se quiere inscribir");
                }

                if (usuario?.UsuarioHistoriales?.Where(h => h.FechaFin == null)?.FirstOrDefault()?.UsuarioEstado.NombreEstado != Enums.EstadoUsuario.Activo.ToString())
                {
                    throw new Exception("El usuario no esta activo");
                }

                int edad = DateTime.Now.Year - usuario.FechaNacimiento.Year;

                // Ajustar si aún no ha cumplido años este año
                if (DateTime.Now.DayOfYear < usuario.FechaNacimiento.DayOfYear)
                {
                    edad--;
                }

                if (leccion.Categoria.Genero != usuario.Sexo || edad < leccion.Categoria.EdadMinima || edad > leccion.Categoria.EdadMaxima)
                {
                    throw new Exception("No es posible inscribirse a esta categoria");
                }

                List<PerfilUsuario> perfilesUsuario = _db.PerfilUsuario.Include(u => u.Usuario).Include(p => p.Perfil).Where(pu => pu.Usuario.Id == currentUser.Id).ToList();
                bool tienePerfilSocio = perfilesUsuario.Any(pu => pu.Perfil.NombrePerfil == Enums.Perfiles.Socio.ToString());

                if (!tienePerfilSocio)
                {
                    throw new Exception("No puede inscribirse porque no tiene perfil de socio");
                }

                InscripcionUsuario? inscripcionLeccion = _db.InscripcionUsuario.Include(e => e.Leccion).Where(f => f.Leccion.Id == inscripcion.IdLeccion && f.UsuarioId == currentUser.Id).FirstOrDefault();
                if (inscripcionLeccion == null)
                {
                    inscripcionLeccion = new InscripcionUsuario
                    {
                        Leccion = leccion,
                        FechaCreacion = DateTime.Now,
                        UsuarioId = usuario.Id
                    };
                    _db.InscripcionUsuario.Add(inscripcionLeccion);
                }
                else {
                    inscripcionLeccion.FechaBaja = null;
                    inscripcionLeccion.FechaModificacion = DateTime.Now;
                    _db.InscripcionUsuario.Update(inscripcionLeccion);
                }

                // crear instancia de inscripcion

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.SaveChanges();
                    transaction.Commit();
                }

                // envio mail al usuario 
                _emailService.SendEmail(usuario.Email, usuario.Nombre + usuario.Apellido, "Inscripcion a lección", "Se inscribió exitosamente a : " + leccion.Nombre + ", " + leccion.Categoria.Nombre);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<AsistenciaLeccion> GetAsistenciaLeccionById(int idLeccion)
        {
            // obtengo las asistenciasLeccion del dia
            DateTime fechaActual = DateTime.Today;
            List<AsistenciaLeccion> asistenciaLecciones = _db.AsistenciaLeccion
                .Include(u => u.Usuario)
                .Include(l=>l.Leccion)
                .Where(a => a.Leccion.Id == idLeccion && a.FechaCreacion.Date == fechaActual)
                .ToList();

            if (asistenciaLecciones.Count == 0)
            {
                // si no encuentro asistenciasLeccion en el dia busco la fecha mas cercana donde existan
                DateTime? ultimaFecha = _db.AsistenciaLeccion
                    .Where(a => a.Leccion.Id == idLeccion)
                    .OrderBy(a => Math.Abs((a.FechaCreacion - fechaActual).TotalDays))
                    .Select(a => a.FechaCreacion.Date)
                    .FirstOrDefault();

                // si existen asistencias en una fecha cercana obtengo todas las de ese dia
                if (ultimaFecha != null)
                {
                    asistenciaLecciones = _db.AsistenciaLeccion
                        .Include(u => u.Usuario)
                        .Where(a => a.Leccion.Id == idLeccion && a.FechaCreacion.Date == ultimaFecha.Value)
                        .ToList();
                }
            }

            return asistenciaLecciones;
        }

        public List<Estadisticas> GetEstadisticasByLeccionUsuario(int idLeccion, int idUsuario)
        {
            List<Estadisticas> estadisticas = new List<Estadisticas> ();

            // obtener la ultima asistencia leccion del usuario para esa leccion
            AsistenciaLeccion? asistenciaLeccion = _db.AsistenciaLeccion.Where(u => u.Usuario.Id == idUsuario && u.Leccion.Id == idLeccion && u.FechaBaja == null).OrderByDescending(f=>f.FechaCreacion).FirstOrDefault();

            if (asistenciaLeccion != null)
            {
                // obtener las estadisticas de esa asistencia
                estadisticas = _db.Estadisticas
                    .Include(t=>t.TipoAccionPartido)
                    .Where(a => a.AsistenciaLeccionId == asistenciaLeccion.Id)
                    .ToList();
            }
           
            return estadisticas;            
        } 

        public void DesinscribirseALeccion(InscripcionLeccionDTO inscripcion)//listo
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                // busco la inscripcion y la doy de baja
                InscripcionUsuario? inscripcionLeccion = _db.InscripcionUsuario.Include(e => e.Leccion).Where(f => f.Leccion.Id==inscripcion.IdLeccion && f.UsuarioId == currentUser.Id && f.FechaBaja==null).FirstOrDefault();

                inscripcionLeccion.FechaBaja = DateTime.Now;

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.InscripcionUsuario.Update(inscripcionLeccion);
                    _db.SaveChanges();
                    transaction.Commit();
                }

                Leccion leccion = GetLeccionById(inscripcion.IdLeccion);
                Usuario? usuario = _db.Usuario
                        .Include(u => u.UsuarioHistoriales).ThenInclude(a => a.UsuarioEstado)
                        .Where(u => u.Id == currentUser.Id)
                        .FirstOrDefault();

                // envio mail al usuario 
                _emailService.SendEmail(usuario.Email, usuario.Nombre + usuario.Apellido, "Desinscripción a lección", "Se desinscribió exitosamente a : " + leccion.Nombre + ", " + leccion.Categoria.Nombre);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public void IniciarLeccion(AsistenciaLeccionDTO asistencias)//listo
        {
            try
            {
                Leccion leccion = GetLeccionById(asistencias.IdLeccion);
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");
                
                //Cambio estado
                LeccionHistorial? ultimoHistorial = leccion.LeccionHistoriales.Where(ih => ih.FechaFin == null).FirstOrDefault();

                if (ultimoHistorial != null)
                {
                    ultimoHistorial.FechaFin = DateTime.Now;
                    _db.LeccionHistorial.Update(ultimoHistorial);
                }
                else
                {
                    leccion.LeccionHistoriales = new List<LeccionHistorial>();
                }

                // creo nuevo historial y lo asigno
                LeccionHistorial nuevoHistorial = new LeccionHistorial
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se inició lección",
                    UsuarioEditor = currentUser?.Id,
                    LeccionEstado = _leccionEstadoServices.GetLeccionEstadoById(2) // asigno estado Iniciado
                };

                leccion.LeccionHistoriales.Add(nuevoHistorial);

                //Guardo lista de asistentes

                foreach (var idAlum in asistencias.AlumnosAsist)
                {
                    Usuario? usuario = _db.Usuario
                        .Include(u => u.UsuarioHistoriales).ThenInclude(a => a.UsuarioEstado)
                        .Where(u => u.Id == idAlum)
                        .FirstOrDefault();

                    AsistenciaLeccion asist = new AsistenciaLeccion
                    {
                        FechaCreacion = DateTime.Now,
                        AsistioAlumno = true,
                        Usuario = usuario,
                        Leccion = leccion
                    };
                    
                    _db.AsistenciaLeccion.Add(asist);
                }


                _db.LeccionHistorial.Add(nuevoHistorial);
                _db.Leccion.Update(leccion);
                _db.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void FinalizarLeccion(int id)//listo
        {
            try
            {
                Leccion leccion = GetLeccionById(id);
                List<AsistenciaLeccion> asistencias = _db.AsistenciaLeccion.Where(a => a.Leccion.Id == id && a.FechaCreacion.Date == DateTime.Now.Date).ToList();
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                //Cambio estado
                LeccionHistorial? ultimoHistorial = leccion.LeccionHistoriales.Where(ih => ih.FechaFin == null).FirstOrDefault();

                if (ultimoHistorial != null)
                {
                    ultimoHistorial.FechaFin = DateTime.Now;
                    _db.LeccionHistorial.Update(ultimoHistorial);
                }
                else
                {
                    leccion.LeccionHistoriales = new List<LeccionHistorial>();
                }

                // creo nuevo historial y lo asigno
                LeccionHistorial nuevoHistorial = new LeccionHistorial
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se finalizó la leccion",
                    UsuarioEditor = currentUser?.Id,
                    LeccionEstado = _leccionEstadoServices.GetLeccionEstadoById(1) // asigno estado Vigente
                };

                leccion.LeccionHistoriales.Add(nuevoHistorial);

                foreach (var idAlum in asistencias)
                {
                    idAlum.ClaseCompleta = true;

                    _db.AsistenciaLeccion.Update(idAlum);
                }

                _db.LeccionHistorial.Add(nuevoHistorial);
                _db.Leccion.Update(leccion);
                _db.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

    }
}

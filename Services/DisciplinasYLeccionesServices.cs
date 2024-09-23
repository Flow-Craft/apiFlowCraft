using ApiNet8.Data;
using ApiNet8.Models;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.TYC;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;

namespace ApiNet8.Services
{
    public class DisciplinasYLeccionesServices : IDisciplinasYLeccionesServices, ILeccionEstadoServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DisciplinasYLeccionesServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        void IDisciplinasYLeccionesServices.ActualizarDisciplina(DisciplinaDTO disciplinaDTO)
        {
            try
            {
                Disciplina disciplina;

                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                using (var transaction = _db.Database.BeginTransaction())
                {
                    // obtengo usuario a modificar y lo actualizo
                    disciplina = GetDisciplinaById(disciplinaDTO.Id);

                    if (disciplina == null)
                    {
                        throw new Exception("No se encontró la disciplina.");
                    }
                   
                        disciplina.CantJugadores = disciplinaDTO.CantJugadores ?? disciplina.CantJugadores;
                        disciplina.CantJugadoresEnBanca = disciplinaDTO.CantJugadoresEnBanca ?? disciplina.CantJugadoresEnBanca;
                        disciplina.Descripcion = disciplinaDTO.Descripcion ?? disciplina.Descripcion;
                        disciplina.FechaModificacion = DateTime.Now;
                        disciplina.Nombre = disciplinaDTO.Nombre ?? disciplina.Nombre;
                        disciplina.PeriodosMax = disciplinaDTO.PeriodosMax ?? disciplina.PeriodosMax;
                        disciplina.TarjetasAdvertencia = disciplinaDTO.TarjetasAdvertencia ?? disciplina.TarjetasAdvertencia;
                        disciplina.TarjetasExpulsion = disciplinaDTO.TarjetasExpulsion ?? disciplina.TarjetasExpulsion;
                        disciplina.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                    _db.Disciplina.Update(disciplina);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        void IDisciplinasYLeccionesServices.CrearDisciplina(DisciplinaDTO disciplinaDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                //mapper de disciplinadto a disciplina
                Disciplina disciplina = _mapper.Map<Disciplina>(disciplinaDTO);

                // Agrego los atributos que faltan
                disciplina.FechaCreacion = DateTime.Now;
                disciplina.UsuarioEditor = currentUser != null ? currentUser.Id : 0;                

                // crear en la base
                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Add(disciplina);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        void IDisciplinasYLeccionesServices.EliminarDisciplina(int id)
        {
            try
            {
                Disciplina disciplinaAEliminar = GetDisciplinaById(id);

                if (disciplinaAEliminar == null)
                {
                    throw new Exception("No se encontró la disciplina.");
                }

                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                disciplinaAEliminar.UsuarioEditor = currentUser != null ? currentUser.Id : 0;
                disciplinaAEliminar.FechaBaja = DateTime.Now;

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Disciplina.Update(disciplinaAEliminar);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Disciplina? GetDisciplinaById(int id)
        {
            try
            {
                return _db.Disciplina.Where(u => u.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        List<Disciplina> IDisciplinasYLeccionesServices.GetDisciplinas()
        {
            return _db.Disciplina.ToList();
        }

        List<DisciplinaMenuDTO> IDisciplinasYLeccionesServices.GetDisciplinasMenu()
        {
            try
            {
                List<Disciplina> disciplinas = _db.Disciplina.Where(d=> d.FechaBaja == null).ToList();
                List<DisciplinaMenuDTO> response = new List<DisciplinaMenuDTO>();
                foreach (var disc in disciplinas)
                {
                    DisciplinaMenuDTO disciplina = _mapper.Map<DisciplinaMenuDTO>(disc);
                    response.Add(disciplina);
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
          
        }

        public List<LeccionEstado> GetLeccionEstados()
        {
            return _db.LeccionEstado.ToList();
        }

        public List<LeccionEstado> GetLeccionEstadosActivos()
        {
            return _db.LeccionEstado.Where(a=> a.FechaBaja == null).ToList();
        }

        public LeccionEstado GetLeccionEstadoById(int id)
        {
            try
            {
                return _db.LeccionEstado.Where(u => u.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteLeccionEstado(string nombre) 
        {
            LeccionEstado? leccionEstado = _db.LeccionEstado.Where(n=> n.NombreEstado.Equals(nombre) && n.FechaBaja == null).FirstOrDefault();            

            return leccionEstado != null ? true : false;

        }

        public void CrearLeccionEstado(LeccionEstadoDTO leccionEstadoDTO) 
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                LeccionEstado leccionEstado = _mapper.Map<LeccionEstado>(leccionEstadoDTO);

                if (ExisteLeccionEstado(leccionEstado.NombreEstado)) 
                {
                    throw new Exception("Ya existe un estado de leccion con ese nombre.");
                }

                leccionEstado.FechaCreacion = DateTime.Now;
                leccionEstado.UsuarioEditor = currentUser != null ? currentUser.Id : 0 ;

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.Add(leccionEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void ActualizarLeccionEstado(LeccionEstadoDTO leccionEstadoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                LeccionEstado leccionEstado = GetLeccionEstadoById(leccionEstadoDTO.Id);

                leccionEstado.FechaModificacion = DateTime.Now;
                leccionEstado.DescripcionEstado = leccionEstadoDTO.DescripcionEstado ?? leccionEstado.DescripcionEstado;
                leccionEstado.NombreEstado = leccionEstadoDTO.NombreEstado ?? leccionEstado.NombreEstado;
                leccionEstado.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                if (leccionEstadoDTO.NombreEstado!=null)
                {
                    bool existe = _db.LeccionEstado.Any(le => le.NombreEstado == leccionEstadoDTO.NombreEstado && le.Id != leccionEstado.Id && le.FechaBaja == null);

                    if (existe)
                    {
                        throw new Exception("Ya existe un estado de leccion con ese nombre.");
                    }
                }               

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.LeccionEstado.Update(leccionEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void EliminarLeccionEstado(LeccionEstadoDTO leccionEstadoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                LeccionEstado leccionEstado = GetLeccionEstadoById(leccionEstadoDTO.Id);

                if (leccionEstado == null)
                {
                    throw new Exception("No existe el estado que quieres eliminar.");
                }

                if (leccionEstado.FechaBaja != null)
                {
                    throw new Exception("El estado de leccion ya esta eliminado.");
                }

                leccionEstado.FechaBaja = DateTime.Now;
                leccionEstado.FechaModificacion = DateTime.Now;
                leccionEstado.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.LeccionEstado.Update(leccionEstado);
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

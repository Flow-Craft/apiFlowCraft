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
    public class DisciplinasYLeccionesServices : IDisciplinasYLeccionesServices
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

    }
}

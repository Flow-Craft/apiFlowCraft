using ApiNet8.Data;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using ApiNet8.Models.Partidos;
using ApiNet8.Models.Usuarios;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using XAct;
using ApiNet8.Models.Eventos;

namespace ApiNet8.Services
{
    public class EquipoServices : IEquipoServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEquipoEstadoService _equipoEstadoService;
        private readonly IUsuarioServices _usuarioServices;
        private readonly IDisciplinasYLeccionesServices _disciplinasYLeccionesServices;
        private readonly ICategoriaServices _categoriaServices;

        public EquipoServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, IEquipoEstadoService equipoEstadoService, IUsuarioServices usuarioServices, IDisciplinasYLeccionesServices disciplinasYLeccionesServices, ICategoriaServices categoriaServices)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _equipoEstadoService = equipoEstadoService;
            _usuarioServices = usuarioServices;
            _disciplinasYLeccionesServices = disciplinasYLeccionesServices;
            _categoriaServices = categoriaServices;
        }

        public List<EquipoResponseDTO> GetEquipos()
        {
            List<Equipo> equipos = _db.Equipo.Include(d=>d.Disciplina).Include(c=>c.Categoria).Include(eu=>eu.EquipoUsuarios).ThenInclude(u=>u.Usuario).Include(h=>h.EquipoHistoriales).ThenInclude(e=>e.EquipoEstado).ToList();
            List<EquipoResponseDTO> response = new List<EquipoResponseDTO>();

            foreach (var equip in equipos) 
            {
                // obtengo los jugadores de cada equipo
                List<JugadoresDTO> jugadores = new List<JugadoresDTO>();
                foreach (var item in equip.EquipoUsuarios)
                {
                    JugadoresDTO jugador = new JugadoresDTO
                    {
                        Nombre = item.Usuario.Nombre,
                        Apellido = item.Usuario.Apellido,
                        Dni = item.Usuario.Dni,
                        NumCamiseta = item.NumCamiseta,
                        Puesto = item.Puesto,
                    };
                    jugadores.Add(jugador);
                }

                // obtengo estado del equipo
                string estado = equip.EquipoHistoriales.Where(f => f.FechaFin == null).OrderByDescending(f => f.FechaInicio).FirstOrDefault().EquipoEstado.NombreEstado;

                // creo la respuesta
                EquipoResponseDTO equipoResponseDTO = new EquipoResponseDTO
                {
                    Id = equip.Id,
                    Nombre = equip.Nombre,
                    Local = equip.Local,
                    Descripcion = equip.Descripcion,
                    FechaCreacion = equip.FechaCreacion,
                    FechaModificacion = equip.FechaModificacion,
                    FechaBaja = equip.FechaBaja,
                    Disciplina = equip.Disciplina,
                    Categoria = equip.Categoria,
                    Jugadores = jugadores,
                    Estado = estado
                };

                response.Add(equipoResponseDTO);
            }

            return response;
        }

        public List<EquipoResponseDTO> GetEquiposActivos()
        {
            List <EquipoResponseDTO> equipos = GetEquipos();
            equipos = equipos.Where(f=>f.Estado == Enums.EstadoEquipo.Activo.ToString()).ToList();

            return equipos;
        }

        public List<EquipoResponseDTO> GetEquiposByCategoriaAndDisciplinaActivos(int IdCategoria, int IdDisciplina)
        {
            List<EquipoResponseDTO> equipos = GetEquiposActivos();
            equipos = equipos.Where(f => f.Categoria.Id == IdCategoria && f.Disciplina.Id == IdDisciplina).ToList();

            return equipos;
        }

        public EquipoResponseDTO GetEquipoById(int id)
        {
            try
            {
                EquipoResponseDTO? equipo = GetEquipos().Where(e=>e.Id == id).FirstOrDefault();
                return equipo;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Equipo GetEquipoEventoById(int id)
        {
            try
            {
                Equipo equipo = _db.Equipo.Include(u=>u.EquipoUsuarios).ThenInclude(u=>u.Usuario).Where(e => e.Id == id).FirstOrDefault();
                return equipo;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteEquipo(string nombre)
        {
            Equipo? equipo = _db.Equipo.Where(n => n.Nombre.Equals(nombre) && n.FechaBaja == null).FirstOrDefault();

            return equipo != null ? true : false;

        }

        public Equipo CrearEquipo(EquipoDTO equipoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Equipo equipo = _mapper.Map<Equipo>(equipoDTO);
                equipo.Local = equipoDTO.Local == null ? false : (bool)equipoDTO.Local;
                equipo.FechaCreacion = DateTime.Now;
                equipo.EquipoUsuarios = new List<EquipoUsuario>();

                if (ExisteEquipo(equipo.Nombre))
                {
                    throw new Exception("Ya existe un equipo con ese nombre.");
                }

                // asignar disciplina
                if (equipoDTO.IdDisciplina < 1 )
                {
                    throw new Exception("Debe selecionar una disciplina al equipo");
                }
                equipo.Disciplina = _disciplinasYLeccionesServices.GetDisciplinaById(equipoDTO.IdDisciplina);

                // asignar categoria
                equipo.Categoria = _categoriaServices.GetCategoriaById(equipoDTO.IdCategoria);                               

                if (equipoDTO.Jugadores == null)
                {
                    throw new Exception("Debe agregar jugadores al equipo");
                }

                // crear instancias de equipoUsuario por cada jugador y relacionarla al usuario
                foreach (var jugador in equipoDTO.Jugadores)
                {
                    // obtener usuario
                    Usuario? usuario = _usuarioServices.GetUsuarioByDni(jugador.Dni);

                    if (usuario == null) { throw new Exception("No existe el usuario con dni: " + jugador.Dni); }

                    // crear equipo usuario
                    EquipoUsuario equipoUsuario = new EquipoUsuario
                    {
                        NumCamiseta = jugador.NumCamiseta,
                        Puesto = jugador.Puesto ?? "",
                        FechaCreacion = DateTime.Now,
                        Usuario = usuario
                    };
                    _db.EquipoUsuario.Add(equipoUsuario);

                    // asignar equipo usuario al equipo
                    equipo.EquipoUsuarios.Add(equipoUsuario);
                }

                // crear historial de equipo                
                EquipoHistorial equipoHistorial = new EquipoHistorial
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se crea equipo",
                    UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                    EquipoEstado = _equipoEstadoService.GetEquipoEstadoById(1) // asigno estado activo
                };
                equipo.EquipoHistoriales = new List<EquipoHistorial>();
                equipo.EquipoHistoriales.Add(equipoHistorial);

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.EquipoHistorial.Add(equipoHistorial);
                    _db.Equipo.Add(equipo);
                    _db.SaveChanges();
                    transaction.Commit();
                }

                return equipo;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void ActualizarEquipo(EquipoDTO equipoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Equipo? equipo = _db.Equipo.Include(eu => eu.EquipoUsuarios).ThenInclude(u => u.Usuario).Include(h => h.EquipoHistoriales).ThenInclude(e => e.EquipoEstado).Where(e=>e.Id == equipoDTO.Id).FirstOrDefault();

                if (equipo == null) { throw new Exception("No existe el equipo que quieres editar"); }

                // editar datos equipo
                equipo.Nombre = equipoDTO.Nombre ?? equipo.Nombre;
                equipo.Local = equipoDTO.Local ?? equipo.Local;
                equipo.Descripcion = equipoDTO.Descripcion ?? equipo.Descripcion;
                equipo.FechaModificacion = DateTime.Now;

                // asignar disciplina
                if (equipoDTO.IdDisciplina > 0)
                {
                    equipo.Disciplina = _disciplinasYLeccionesServices.GetDisciplinaById(equipoDTO.IdDisciplina);
                }

                // asignar categoria
                if (equipoDTO.IdCategoria > 0)
                {
                    equipo.Categoria = _categoriaServices.GetCategoriaById(equipoDTO.IdCategoria);
                }

                // verificar si ya existe otro equipo con el mismo nombre
                if (equipoDTO?.Nombre != null)
                {
                    bool existe = _db.Equipo.Include(a => a.EquipoHistoriales).Any(le => (le.Nombre == equipoDTO.Nombre && le.Id != equipoDTO.Id) && le.EquipoHistoriales.Any(h => h.FechaFin == null &&
                     (h.EquipoEstado.NombreEstado != ApiNet8.Utils.Enums.EstadoEquipo.Inactivo.ToString())));

                    if (existe)
                    {
                        throw new Exception("Ya existe un equipo con ese nombre.");
                    }
                }

                // verificar si cambiaron los jugadores
                if (equipoDTO?.Jugadores != null)
                {
                    // dar de baja los equipo usuario anteriores 
                    foreach (var item in equipo.EquipoUsuarios)
                    {
                        item.FechaBaja = DateTime.Now;
                        _db.EquipoUsuario.Update(item);
                    }

                    // limpiar la lista de equipo usuarios antes de agregar los nuevos
                    equipo.EquipoUsuarios.Clear(); 

                    // crear instancias de equipoUsuario por cada jugador y relacionarla al usuario
                    foreach (var jugador in equipoDTO.Jugadores)
                    {
                        // obtener usuario
                        Usuario? usuario = _usuarioServices.GetUsuarioByDni(jugador.Dni);

                        if (usuario == null) { throw new Exception("No existe el usuario con dni: " + jugador.Dni); }

                        // crear equipo usuario
                        EquipoUsuario equipoUsuario = new EquipoUsuario
                        {
                            NumCamiseta = jugador.NumCamiseta,
                            Puesto = jugador.Puesto ?? "",
                            FechaCreacion = DateTime.Now,
                            Usuario = usuario
                        };
                        _db.EquipoUsuario.Add(equipoUsuario);

                        // asignar equipo usuario al equipo
                        equipo.EquipoUsuarios.Add(equipoUsuario);
                    }
                }

                // se da de baja el historial anterior
                EquipoHistorial? ultimoHistorial = equipo.EquipoHistoriales.Where(f => f.FechaFin == null).FirstOrDefault();
                if (ultimoHistorial != null)
                {
                    ultimoHistorial.FechaFin = DateTime.Now;
                    _db.EquipoHistorial.Update(ultimoHistorial);
                }

                // crear nuevo historial y asignarlo
                EquipoHistorial equipoHistorial = new EquipoHistorial
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se edita equipo",
                    UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                    EquipoEstado = _equipoEstadoService.GetEquipoEstadoById(1) // asigno estado activo
                };
                equipo.EquipoHistoriales = equipo.EquipoHistoriales == null ? new List<EquipoHistorial>() : equipo.EquipoHistoriales;
                equipo.EquipoHistoriales.Add(equipoHistorial);

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.EquipoHistorial.Add(equipoHistorial);
                    _db.Equipo.Update(equipo);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void EliminarEquipo(EquipoDTO equipoDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Equipo? equipo = _db.Equipo.Include(eu => eu.EquipoUsuarios).ThenInclude(u => u.Usuario).Include(h => h.EquipoHistoriales).ThenInclude(e => e.EquipoEstado).Where(e => e.Id == equipoDTO.Id).FirstOrDefault();
                    
                if (equipo == null)
                {
                    throw new Exception("No existe el equipo que quieres eliminar.");
                }

                equipo.FechaBaja = DateTime.Now;

                // dar de baja las relaciones equipo usuario
                foreach (var item in equipo.EquipoUsuarios)
                {
                    item.FechaBaja = DateTime.Now;
                    item.FechaModificacion = DateTime.Now;
                }

                // obtener ultimo historial y darlo de baja
                EquipoHistorial? ultimoHistorial = equipo.EquipoHistoriales?.Where(f => f.FechaFin == null).OrderByDescending(f => f.FechaInicio).FirstOrDefault();
                if (ultimoHistorial != null)
                {
                    if (ultimoHistorial.EquipoEstado.NombreEstado == Enums.EstadoEquipo.Inactivo.ToString())
                    {
                        throw new Exception("Este equipo ya ha sido eliminado");
                    }

                    ultimoHistorial.FechaFin = DateTime.Now;
                    _db.EquipoHistorial.Update(ultimoHistorial);
                }

                // crear nuevo historial
                EquipoHistorial nuevoHistorial = new EquipoHistorial
                {
                    FechaInicio = DateTime.Now,
                    DetalleCambioEstado = "Se elimina equipo",
                    UsuarioEditor = currentUser?.Id,
                    EquipoEstado = _equipoEstadoService.GetEquipoEstadoById(2) // se asigna estado inactivo
                };
                equipo.EquipoHistoriales = equipo.EquipoHistoriales == null ? new List<EquipoHistorial>() : equipo.EquipoHistoriales;
                equipo.EquipoHistoriales.Add(nuevoHistorial);


                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.EquipoHistorial.Add(nuevoHistorial);
                    _db.Equipo.Update(equipo);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<string> GetPuestosJugador (int idUsuario)
        { 
            List<string> result = new List<string>();
            List<EquipoUsuario> equiposJugador = _db.EquipoUsuario.Where(u => u.Usuario.Id == idUsuario).ToList();

            foreach (var item in equiposJugador)
            {
                result.Add(item.Puesto);
            }

            return result;
        }
    }
}

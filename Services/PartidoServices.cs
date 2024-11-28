using ApiNet8.Data;
using ApiNet8.Models;
using ApiNet8.Models.Partidos;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Reservas;
using ApiNet8.Models.Eventos;
using System;
using XSystem.Security.Cryptography;
using XAct;
using ApiNet8.Migrations;
using Estadisticas = ApiNet8.Models.Partidos.Estadisticas;
using TipoAccionPartido = ApiNet8.Models.Partidos.TipoAccionPartido;
using ApiNet8.Models.Torneos;
using static ApiNet8.Utils.Enums;

namespace ApiNet8.Services
{
    public class PartidoServices : IPartidoServices
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUsuarioServices _usuarioServices;
        private readonly IEventoServices _eventoServices;
        private readonly IEventoEstadoService _eventoEstadoServices;
        private readonly ITipoAccionPartidoServices _tipoAccionPartidoServices;
        private readonly ILeccionesServices _leccionesServices;
        private readonly ITorneoServices _torneoServices;
        private readonly ITorneoEstadoServices _torneoEstadoServices;

        public PartidoServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor, IUsuarioServices usuarioServices, IEventoEstadoService eventoEstadoServices, ITipoAccionPartidoServices tipoAccionPartidoServices, IEventoServices eventoServices, ILeccionesServices leccionesServices, ITorneoServices torneoServices, ITorneoEstadoServices torneoEstadoServices)
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _usuarioServices = usuarioServices;
            _eventoEstadoServices = eventoEstadoServices;
            _tipoAccionPartidoServices = tipoAccionPartidoServices;
            _eventoServices = eventoServices;
            _leccionesServices = leccionesServices;
            _torneoServices = torneoServices;
            _torneoEstadoServices = torneoEstadoServices;
        }

        public void ActualizarEstadistica(EstadisticaDTO estadisticaDTO)//listo
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");
                Estadisticas estadistica = ExisteEstadistica(estadisticaDTO);

                if (estadistica == null)
                {
                    estadisticaDTO.NoEsta = true;
                    AltaEstadistica(estadisticaDTO);
                }
                else
                {
                    //estadistica = GetEstadisticaById((int)estadisticaDTO.Id);
                    if (estadisticaDTO.Resta == true)
                    {
                        estadistica.PuntajeTipoAccion = estadistica.PuntajeTipoAccion - 1;
                    }
                    else
                    {
                        estadistica.PuntajeTipoAccion = estadistica.PuntajeTipoAccion + 1;
                    }

                    estadistica.FechaModificacion = DateTime.Now;
                    estadistica.UsuarioEditor = currentUser.Id;

                    _db.Estadisticas.Update(estadistica);
                    using (var transaction = _db.Database.BeginTransaction())
                    {
                        _db.SaveChanges();
                        transaction.Commit();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Estadisticas GetEstadisticaById(int Id)//listo
        {
            try
            {
                Estadisticas? est = _db.Estadisticas.
                    Include(p => p.Equipo).
                    ThenInclude(eq => eq.EquipoUsuarios).
                    ThenInclude(u => u.Usuario).
                    Include(p => p.Partido).
                    Include(p => p.TipoAccionPartido).
                    Where(a => a.Id == Id).FirstOrDefault();

                int idEvento = (est?.Partido as Evento)?.Id ?? 0;

                if (idEvento != 0)
                {
                    est.Partido = GetPartidoById(idEvento);
                }
                    
                return est;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        // si es una estadistica de partido usar siempre null para la propiedad de asistencia leccion
        public Estadisticas AltaEstadistica(EstadisticaDTO estadisticaDTO) //Listo
        {
            try
            {

                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");
                Partido? part = new Partido();
                Equipo? equipo = new Equipo();
                AsistenciaLeccion? asist = new AsistenciaLeccion();
                Estadisticas? estadistica = new Estadisticas();

                if (estadisticaDTO.NoEsta != true)
                {
                    estadistica = ExisteEstadistica(estadisticaDTO);
                }
                else
                {
                    estadistica = null;
                }

                if (estadistica == null)
                {
                    if (estadisticaDTO.IdPartido != null)
                    {
                        part = GetPartidoById((int)estadisticaDTO.IdPartido);
                        equipo = _db.Equipo.Where(p => p.Id == estadisticaDTO.IdEquipo).FirstOrDefault();
                        asist = null;
                    }
                    else
                    {
                        part = null;
                        equipo = null;
                        asist = _db.AsistenciaLeccion.Where(p => p.Id == estadisticaDTO.IdAsistencia).FirstOrDefault();
                    }

                    estadistica = new Estadisticas()
                    {
                        Partido = part,
                        TipoAccionPartido = _tipoAccionPartidoServices.GetTipoAccionPartidoById(estadisticaDTO.IdTipoAccion),
                        PuntajeTipoAccion = 1,
                        AsistenciaLeccionId = estadisticaDTO.IdAsistencia,
                        NroJugador = estadisticaDTO.NroJugador,
                        MarcaEstadistica = estadisticaDTO.MarcaEstadistica,
                        FechaCreacion = DateTime.Now,
                        Equipo = equipo,
                        RazonBaja = "",
                        UsuarioEditor = currentUser != null ? currentUser.Id : 0
                    };
                    _db.Estadisticas.Add(estadistica);
                    

                }
                else
                {
                    estadistica.PuntajeTipoAccion = estadistica.PuntajeTipoAccion + 1;
                    _db.Estadisticas.Update(estadistica);
                }

               

                using (var transaction = _db.Database.BeginTransaction())
                {
                    _db.SaveChanges();
                    transaction.Commit();
                }

                return estadistica;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void Asistencia()
        {
            try
            {
                AsistenciaLeccion asistenciaLeccion = new AsistenciaLeccion
                {
                    AsistioAlumno = false,
                    ClaseCompleta = false,
                    FechaCreacion = DateTime.Now,
                    Leccion = _leccionesServices.GetLeccionById(2),
                    Usuario = _usuarioServices.GetUsuarioById(13)
                };

                using (var transaction = _db.Database.BeginTransaction())
                {
                    

                    _db.AsistenciaLeccion.Add(asistenciaLeccion);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Estadisticas? ExisteEstadistica(EstadisticaDTO estadisticaDTO)
        {
            try
            {
                Estadisticas? estadistica = new Estadisticas();

                if (estadisticaDTO.Secuencial == false)  // si es false es voley, sino futbol
                {
                    estadistica = _db.Estadisticas.Where(p => p.MarcaEstadistica == estadisticaDTO.MarcaEstadistica && p.Equipo.Id == estadisticaDTO.IdEquipo && p.TipoAccionPartido.Id == estadisticaDTO.IdTipoAccion && p.Partido.Id == estadisticaDTO.IdPartido && p.AsistenciaLeccionId == estadisticaDTO.IdAsistencia && p.NroJugador == estadisticaDTO.NroJugador && p.FechaBaja == null).FirstOrDefault();
                }
                else
                {
                    estadistica = _db.Estadisticas.Where(p => p.TipoAccionPartido.Id == estadisticaDTO.IdTipoAccion && p.Equipo.Id == estadisticaDTO.IdEquipo && p.Partido.Id == estadisticaDTO.IdPartido && p.AsistenciaLeccionId == estadisticaDTO.IdAsistencia && p.NroJugador == estadisticaDTO.NroJugador && p.FechaBaja == null).FirstOrDefault();
                }

                return estadistica;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void BajaEstadistica(EstadisticaDTO estadisticaDTO)//listo
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");
                Estadisticas estadistica = GetEstadisticaById((int)estadisticaDTO.Id);

                using (var transaction = _db.Database.BeginTransaction())
                {
                    estadistica.RazonBaja = estadisticaDTO.RazonBaja;
                    estadistica.FechaBaja = DateTime.Now;
                    estadistica.UsuarioEditor = currentUser.Id;

                    _db.Estadisticas.Update(estadistica);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        public List<Estadisticas> GetEstadisticasByDiscUsuPer(EstadisticaDTO estadisticaDTO)//listo
        {
            try
            {
                List<Estadisticas> est = new List<Estadisticas>();
                if (estadisticaDTO.Leccion == true)
                {
                    List<int> asist = _db.AsistenciaLeccion.Where(a => 
                    a.Usuario.Dni == estadisticaDTO.DNIUsuario && 
                    a.Leccion.Disciplina.Id == estadisticaDTO.IdDisciplina &&  
                    a.Leccion.Id == estadisticaDTO.IdLeccion &&
                    a.FechaCreacion < estadisticaDTO.FechaHasta && 
                    a.FechaCreacion > estadisticaDTO.FechaDesde && 
                    a.FechaBaja==null).
                    Select(a => a.Id).ToList();

                    foreach (var item in asist)
                    {
                        est.Add(_db.Estadisticas.
                        Include(p => p.TipoAccionPartido).
                        Where(a => a.AsistenciaLeccionId==item).ToList());
                    }

                }
                else {                    
                    List<int> estadisticasIds= _db.Estadisticas.
                    Where(a =>/* a.NroJugador==estadisticaDTO.NroJugador && */
                    a.Partido.Disciplina.Id==estadisticaDTO.IdDisciplina &&
                    a.FechaCreacion < estadisticaDTO.FechaHasta &&
                    a.FechaCreacion > estadisticaDTO.FechaDesde &&
                    a.Equipo.EquipoUsuarios.Any(u=>u.Usuario.Dni == estadisticaDTO.DNIUsuario) &&
                    a.FechaBaja==null).
                    Select(a => a.Id).ToList();

                    foreach (var item in estadisticasIds)
                    {
                        est.Add(GetEstadisticaById(item));
                    }
                }
                return est;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Estadisticas> GetEstadisticasByUsuarioLogin()
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                if (currentUser == null)
                {
                    throw new Exception("CurrentUser es null");
                }

                List<Estadisticas> est = new List<Estadisticas>();
               
                    List<int> asist = _db.AsistenciaLeccion.Where(a =>
                    a.Usuario.Id == currentUser.Id &&                    
                    a.FechaBaja == null).
                    Select(a => a.Id).ToList();

                    foreach (var item in asist)
                    {
                        est.Add(_db.Estadisticas.
                        Include(p => p.TipoAccionPartido).
                        Where(a => a.AsistenciaLeccionId == item).ToList());
                    }                
                
                    List<int> estadisticasIds = _db.Estadisticas.
                    Where(a => a.Equipo != null &&                   
                    a.Equipo.EquipoUsuarios.Any(u => u.Usuario.Id == currentUser.Id) &&
                    a.FechaBaja == null).
                    Select(a => a.Id).ToList();

                    foreach (var item in estadisticasIds)
                    {
                        est.Add(GetEstadisticaById(item));
                    }
                
                return est;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Estadisticas> GetEstadisticasByUsuarioId(int dniUsuario)
        {
            try
            {
                List<Estadisticas> est = new List<Estadisticas>();
                
                    List<int> asist = _db.AsistenciaLeccion.Where(a =>
                    a.Usuario.Dni == dniUsuario &&                    
                    a.FechaBaja == null).
                    Select(a => a.Id).ToList();

                    foreach (var item in asist)
                    {
                        est.Add(_db.Estadisticas.
                        Include(p => p.TipoAccionPartido).
                        Where(a => a.AsistenciaLeccionId == item).ToList());
                    }
              
                    List<int> estadisticasIds = _db.Estadisticas.
                    Where(a => a.Equipo != null &&                    
                    a.Equipo.EquipoUsuarios.Any(u => u.Usuario.Dni == dniUsuario) &&
                    a.FechaBaja == null).
                    Select(a => a.Id).ToList();

                    foreach (var item in estadisticasIds)
                    {
                        est.Add(GetEstadisticaById(item));
                    }
                
                return est;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Estadisticas> GetEstadisticasByEquipo(EstadisticaDTO estadisticaDTO)//listo
        {
            try
            {
                List<Estadisticas> est = new List<Estadisticas>();

                List<int> estadisticasIds = _db.Estadisticas.
                    Where(a => a.Equipo.Id == estadisticaDTO.IdEquipo &&
                    a.Partido.Disciplina.Id == estadisticaDTO.IdDisciplina &&
                    a.FechaCreacion < estadisticaDTO.FechaHasta &&
                    a.FechaCreacion > estadisticaDTO.FechaDesde &&
                    a.FechaBaja == null).
                    Select(a => a.Id).ToList();

                foreach (var item in estadisticasIds)
                {
                    est.Add(GetEstadisticaById(item));
                }

                return est;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Estadisticas> GetEstadisticasByPartidoUsu(EstadisticaDTO estadisticaDTO)//listo
        {
            try
            {
                List<Estadisticas> est = new List<Estadisticas>();

                List<int> ids = _db.Estadisticas.
                    Where(a => a.Partido.Id == estadisticaDTO.IdPartido &&
                    a.NroJugador==estadisticaDTO.NroJugador && //Aca lo busca por ID EquipoUsuario, Nro jugador guarda ese id
                    //a.Equipo.EquipoUsuarios.Any(u => u.Usuario.Dni == estadisticaDTO.DNIUsuario) &&
                    a.FechaBaja == null).
                    Select(a => a.Id).ToList();

                foreach (var item in ids)
                {
                    est.Add(GetEstadisticaById(item));
                }

                return est;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Estadisticas> GetEstadisticasByPartidoEquip(EstadisticaDTO estadisticaDTO)//listo
        {
            try
            {
                List<Estadisticas> est = new List<Estadisticas>();

                List<int> ids = _db.Estadisticas.
                    Where(a => a.Partido.Id == estadisticaDTO.IdPartido &&
                    a.Equipo.Id == estadisticaDTO.IdEquipo &&
                    a.FechaBaja == null).
                    Select(a => a.Id).ToList();

                foreach (var item in ids)
                {
                    est.Add(GetEstadisticaById(item));
                }

                return est;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        //listos para futbol
        public AccionPartidoDTO AltaAccionPartido(AccionPartidoDTO accion)//LISTO
        {
            try
            {
                if (EsArbitro() == true)
                {
                    Partido part = GetPartidoById(accion.IdPartido);
                    var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");
                    HistorialEvento? ultimoHistorial = part.HistorialEventoList.Where(ih => ih.FechaFin == null).FirstOrDefault();

                    if (ultimoHistorial.EstadoEvento.Id == 4 || ultimoHistorial.EstadoEvento.Id == 6)
                    {
                        using (var transaction = _db.Database.BeginTransaction())
                        {
                            TipoAccionPartido tipAcc = _tipoAccionPartidoServices.GetTipoAccionPartidoById(accion.IdTipoAccion);
                            int jugBanca;
                            if(accion.IdJugadorEnBanca == 0)
                            {
                                jugBanca = 0;
                            }
                            else
                            {
                                jugBanca = _db.EquipoUsuario.Where(p => p.Id == accion.IdJugadorEnBanca).FirstOrDefault().NumCamiseta;
                            }
                                                     

                            AccionPartido accionPartido = new AccionPartido()
                            {
                                NroJugador = _db.EquipoUsuario.Where(p => p.Id == accion.IdJugador).FirstOrDefault().NumCamiseta,
                                Minuto = accion.Minuto,
                                Descripcion = tipAcc.NombreTipoAccion,
                                FechaCreacion = DateTime.Now,
                                UsuarioEditor = currentUser.Id,
                                Periodo = part.Periodo,
                                TipoAccionPartido = tipAcc,
                                EquipoLocal = accion.EquipoLocal,
                                Partido = part,
                                NroJugadorCambio = jugBanca
                            };

                            if (tipAcc.NombreTipoAccion == "Gol" || tipAcc.NombreTipoAccion == "Punto" || tipAcc.NombreTipoAccion == "Tanto" || tipAcc.NombreTipoAccion == "Canasta")
                            {
                                if (accion.EquipoLocal == true)
                                {
                                    part.ResultadoLocal = part.ResultadoLocal + 1;
                                }
                                else
                                {
                                    part.ResultadoVisitante = part.ResultadoVisitante + 1;
                                }
                            }

                            if (tipAcc.NombreTipoAccion == "Cambio Jugador")
                            {
                                part = CambioJugador(part, accion, false);
                            }

                            if (tipAcc.ModificaTarjetasAdvertencia == true)
                            {

                                List<AccionPartido> acciones = _db.AccionPartido.Include(p => p.TipoAccionPartido).Where(a => a.Partido.Id == part.Id && a.TipoAccionPartido.NombreTipoAccion == "Tarjeta Amarilla" && a.FechaBaja == null && a.NroJugador == accionPartido.NroJugador).ToList();
                                if (acciones.Count+1 >= part.Disciplina.TarjetasAdvertencia)

                                {
                                    accion.TotalTarjetas = true;
                                    part = ExpulsionJugador(part, accion);
                                    
                                    // creo una accion de tarjeta roja 
                                    AccionPartido expulsion = new AccionPartido()
                                    {
                                        NroJugador = accionPartido.NroJugador,
                                        Minuto = accionPartido.Minuto,
                                        Descripcion = _tipoAccionPartidoServices.GetTipoAccionPartidoById(4).NombreTipoAccion,
                                        FechaCreacion = accionPartido.FechaCreacion,
                                        UsuarioEditor = accionPartido.UsuarioEditor,
                                        Periodo = accionPartido.Periodo,
                                        TipoAccionPartido = _tipoAccionPartidoServices.GetTipoAccionPartidoById(4), // tarjeta roja
                                        EquipoLocal = accionPartido.EquipoLocal, 
                                        Partido = part, 
                                        NroJugadorCambio = accionPartido.NroJugadorCambio
                                    };

                                        _db.AccionPartido.Add(expulsion);
                                }

                               
                            }

                            if (tipAcc.ModificaTarjetasExpulsion == true)
                            {

                                List<AccionPartido> acciones = _db.AccionPartido.Include(p => p.TipoAccionPartido).Where(a => a.Partido.Id == part.Id && a.TipoAccionPartido.NombreTipoAccion == "Tarjeta Roja" && a.NroJugador == accion.IdJugador).ToList();
                                if (acciones.Count+1 == part.Disciplina.TarjetasExpulsion)

                                {
                                    accion.TotalTarjetas = true;
                                    part = ExpulsionJugador(part, accion);
                                }
                            }

                            _db.AccionPartido.Add(accionPartido);
                            _db.Partido.Update(part);
                            _db.SaveChanges();
                            transaction.Commit();

                            return accion;
                        }
                    }
                    else
                    {
                        throw new Exception("El partido no se encuentra en estado iniciado o en entretiempo");
                    }
                }
                else
                {
                    throw new Exception("Usuario no es árbitro");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void BajaAccionPartido(AccionPartidoDTO accion)//LISTO
        {
            try
            {
                if (EsArbitro() == true)
                {
                    var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                    using (var transaction = _db.Database.BeginTransaction())
                    {

                        AccionPartido? accionPartido = _db.AccionPartido.Include(p => p.TipoAccionPartido).Where(a => a.Id == accion.Id).FirstOrDefault();

                        if (accionPartido == null)
                        {
                            throw new Exception("No se encontro la accion que desea eliminar");
                        }

                        Partido part = GetPartidoById(accion.IdPartido);
                        accionPartido.FechaBaja = DateTime.Now;
                        accionPartido.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                        if (accionPartido.TipoAccionPartido.NombreTipoAccion == "Gol")
                        {
                            if (accionPartido.EquipoLocal == true)
                            {
                                part.ResultadoLocal = part.ResultadoLocal - 1;
                            }
                            else
                            {
                                part.ResultadoVisitante = part.ResultadoVisitante - 1;
                            }
                        }

                        if (accionPartido.TipoAccionPartido.NombreTipoAccion == "Cambio Jugador")
                        {
                            AccionPartidoDTO accionPartidoDTO = new AccionPartidoDTO();
                            accionPartidoDTO.EquipoLocal = accionPartido.EquipoLocal;
                            accionPartidoDTO.IdJugador = accionPartido.NroJugadorCambio;
                            accionPartidoDTO.IdJugadorEnBanca = accionPartido.NroJugador;
                            part = CambioJugador(part, accionPartidoDTO,true);
                        }

                        if (accionPartido.TipoAccionPartido.ModificaTarjetasAdvertencia == true)
                        {
                            List<AccionPartido> acciones = _db.AccionPartido.Include(p => p.TipoAccionPartido).Where(a => a.Partido.Id == part.Id && a.TipoAccionPartido.ModificaTarjetasAdvertencia == true && a.FechaBaja==null).ToList();
                            if (acciones.Count == part.Disciplina.TarjetasAdvertencia)
                            {
                                part = IncorporarJugador(part, accionPartido.NroJugador.ToString(), accionPartido.EquipoLocal);                               
                            }
                        }

                        if (accionPartido.TipoAccionPartido.ModificaTarjetasExpulsion == true)
                        {
                            List<AccionPartido> acciones = _db.AccionPartido.Include(p => p.TipoAccionPartido).Where(a => a.Partido.Id == part.Id && a.TipoAccionPartido.ModificaTarjetasExpulsion == true && a.FechaBaja == null).ToList();
                            if (acciones.Count == part.Disciplina.TarjetasExpulsion)
                            {
                                part = IncorporarJugador(part, accionPartido.NroJugador.ToString(), accionPartido.EquipoLocal);
                            }
                        }

                        _db.AccionPartido.Update(accionPartido);
                        _db.Partido.Update(part);
                        _db.SaveChanges();
                        transaction.Commit();
                    }
                }
                else
                {
                    throw new Exception("Usuario no es árbitro");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Partido CambioJugador(Partido part, AccionPartidoDTO accion, bool baja)//LISTO
        {
            string jugador;
            string jugadorBanca;
            if (baja == false)
            {
                jugador = _db.EquipoUsuario.Where(p => p.Id == accion.IdJugador).FirstOrDefault().NumCamiseta.ToString();
                jugadorBanca = _db.EquipoUsuario.Where(p => p.Id == accion.IdJugadorEnBanca).FirstOrDefault().NumCamiseta.ToString();
            }
            else
            {
                jugador = accion.IdJugador.ToString();
                jugadorBanca = accion.IdJugadorEnBanca.ToString();
            }
            if (accion.EquipoLocal == true)
            {
                part.Local.JugadoresEnCancha.Add(jugadorBanca);
                part.Local.JugadoresEnBanca.Remove(jugadorBanca);
                part.Local.JugadoresEnBanca.Add(jugador);
                part.Local.JugadoresEnCancha.Remove(jugador);
            }
            else
            {
                part.Visitante.JugadoresEnCancha.Add(jugadorBanca);
                part.Visitante.JugadoresEnBanca.Remove(jugadorBanca);
                part.Visitante.JugadoresEnBanca.Add(jugador);
                part.Visitante.JugadoresEnCancha.Remove(jugador);
            }
            
            return part;
        }

        public Partido ExpulsionJugador(Partido part, AccionPartidoDTO accion)//listo
        {
            string jugador = _db.EquipoUsuario.Where(p => p.Id == accion.IdJugador).FirstOrDefault().NumCamiseta.ToString();

            if (accion.EquipoLocal == true)
            {
                part.Local.JugadoresEnBanca.Remove(jugador);
                part.Local.JugadoresEnCancha.Remove(jugador);
            }
            else
            {
                part.Visitante.JugadoresEnBanca.Remove(jugador);
                part.Visitante.JugadoresEnCancha.Remove(jugador);
            }

            return part;
        }

        public Partido IncorporarJugador(Partido part, string jugador, bool local)//listo
        {
            if (local == true)
            {
                part.Local.JugadoresEnCancha.Add(jugador);
            }
            else
            {
                part.Visitante.JugadoresEnCancha.Add(jugador);
            }

            return part;
        }

        public void IniciarTiempo(int partidoId)//listo
        {
            try
            {
                if (EsArbitro() == true)
                {
                    Partido part = GetPartidoById(partidoId);
                    var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                    //Cambio estado
                    HistorialEvento? ultimoHistorial = part.HistorialEventoList.Where(ih => ih.FechaFin == null).FirstOrDefault();
                    if (ultimoHistorial.EstadoEvento.Id == 6)
                    {
                        if (ultimoHistorial != null)
                        {
                            ultimoHistorial.FechaFin = DateTime.Now;
                            _db.HistorialEvento.Update(ultimoHistorial);
                        }
                        else
                        {
                            part.HistorialEventoList = new List<HistorialEvento>();
                        }

                        // creo nuevo historial y lo asigno
                        HistorialEvento nuevoHistorial = new HistorialEvento
                        {
                            FechaInicio = DateTime.Now,
                            DetalleCambioEstado = "Se inició partido",
                            UsuarioEditor = currentUser?.Id,
                            EstadoEvento = _eventoEstadoServices.GetEventoEstadoById(4) // asigno estado Iniciado
                        };

                        part.Periodo = part.Periodo + 1;
                        part.HistorialEventoList.Add(nuevoHistorial);

                        _db.HistorialEvento.Add(nuevoHistorial);
                        _db.Partido.Update(part);
                        _db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("El partido no se encuentra en estado entretiempo");
                    }
                }
                else
                {
                    throw new Exception("Usuario no es árbitro");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void FinalizarTiempo(int partidoId)//LISTO
        {
            try
            {
                if (EsArbitro() == true)
                {
                    Partido part = GetPartidoById(partidoId);
                    var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                    //Cambio estado
                    HistorialEvento? ultimoHistorial = part.HistorialEventoList.Where(ih => ih.FechaFin == null).FirstOrDefault();

                    if (ultimoHistorial.EstadoEvento.Id == 4)
                    {
                        if (ultimoHistorial != null)
                        {
                            ultimoHistorial.FechaFin = DateTime.Now;
                            _db.HistorialEvento.Update(ultimoHistorial);
                        }
                        else
                        {
                            part.HistorialEventoList = new List<HistorialEvento>();
                        }

                        // creo nuevo historial y lo asigno
                        HistorialEvento nuevoHistorial = new HistorialEvento
                        {
                            FechaInicio = DateTime.Now,
                            DetalleCambioEstado = "El partido está en entretiempo",
                            UsuarioEditor = currentUser?.Id,
                            EstadoEvento = _eventoEstadoServices.GetEventoEstadoById(6) // asigno estado Entretiempo
                        };

                        part.HistorialEventoList.Add(nuevoHistorial);

                        // Sumo el set ganado
                        if (part.Disciplina.Nombre == "Voley")
                        {
                            List<AccionPartido> puntos = _db.AccionPartido.Where(a => a.Partido.Id == partidoId && a.Periodo == part.Periodo && a.Descripcion == "Punto").ToList();

                            int puntosLocal = puntos.Count(a => a.EquipoLocal == true);
                            int puntosVisitante = puntos.Count(a => a.EquipoLocal == false);

                            // Comparar los puntos entre los equipos
                            if (puntosLocal > puntosVisitante)
                            {
                                part.ResultadoLocal = part.ResultadoLocal + 1;
                            }
                            else
                            {
                                part.ResultadoVisitante = part.ResultadoVisitante + 1;
                            }

                        }
                        part.HistorialEventoList.Add(nuevoHistorial);

                        _db.HistorialEvento.Add(nuevoHistorial);
                        _db.Partido.Update(part);
                        _db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("El partido no se encuentra en estado iniciado");
                    }
                }
                else
                {
                    throw new Exception("Usuario no es árbitro");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void FinalizarPartido(int partidoId)//LISTO
        {
            try
            {
                if (EsArbitro() == true)
                {
                    Partido part = GetPartidoById(partidoId);
                    var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                    //Cambio estado
                    HistorialEvento? ultimoHistorial = part.HistorialEventoList.Where(ih => ih.FechaFin == null).FirstOrDefault();
                    if (ultimoHistorial!= null && ultimoHistorial.EstadoEvento.Id == 4)
                    {
                        if (ultimoHistorial != null)
                        {
                            ultimoHistorial.FechaFin = DateTime.Now;
                            _db.HistorialEvento.Update(ultimoHistorial);
                        }
                        else
                        {
                            part.HistorialEventoList = new List<HistorialEvento>();
                        }

                        // creo nuevo historial y lo asigno
                        HistorialEvento nuevoHistorial = new HistorialEvento
                        {
                            FechaInicio = DateTime.Now,
                            DetalleCambioEstado = "Se finalizó el partido",
                            UsuarioEditor = currentUser?.Id,
                            EstadoEvento = _eventoEstadoServices.GetEventoEstadoById(3) // asigno estado Finalizado
                        };

                        part.HistorialEventoList.Add(nuevoHistorial);

                        //part.FechaFin = DateTime.Now;

                        if (part.Disciplina.Nombre == "Voley")
                        {
                            List<AccionPartido> puntos = _db.AccionPartido.Where(a => a.Partido.Id == partidoId && a.Periodo == part.Periodo && a.Descripcion == "Punto").ToList();

                            int puntosLocal = puntos.Count(a => a.EquipoLocal == true);
                            int puntosVisitante = puntos.Count(a => a.EquipoLocal == false);

                            // Comparar los puntos entre los equipos
                            if (puntosLocal > puntosVisitante)
                            {
                                part.ResultadoLocal = part.ResultadoLocal + 1;
                            }
                            else
                            {
                                part.ResultadoVisitante = part.ResultadoVisitante + 1;
                            }

                        }

                        //guardo ganador

                        if (part.ResultadoVisitante > part.ResultadoLocal)
                        {
                            part.Ganador = part.Visitante;
                        }
                        else if (part.ResultadoVisitante < part.ResultadoLocal)
                        {
                            part.Ganador = part.Local;
                        }
                        else { part.Ganador = null; }

                        part.FechaFin = DateTime.Now;

                        // verificar si partido pertenece a un torneo
                        if (EsDeTorneo(part.Titulo) && part.Ganador != null)
                        {
                            // Buscar el PartidoFase al que pertenece y el torneo
                            PartidoFase partidoFase = _db.PartidoFase
                                .Include(pf => pf.Partidos)
                                .Include(t=>t.Torneo)
                                .FirstOrDefault(pf => pf.Partidos.Any(p => p.Titulo == part.Titulo))!;

                            int idTorneo = partidoFase.Torneo.Id;

                            // buscar la proxima fase del torneo
                            PartidoFase? partidoFase2 = _db.PartidoFase
                                .Include(p=>p.Partidos).ThenInclude(a=>a.Local)
                                .Include(p => p.Partidos).ThenInclude(a => a.Visitante)
                                .Where(t => t.Torneo.Id == idTorneo && t.FasePartido == partidoFase.FasePartido + 1).FirstOrDefault();

                            Torneo torneoPartido = partidoFase.Torneo;

                            // verificar si el partido es la final
                            if (partidoFase2 != null)
                            {
                                // buscar partido de fase siguiente libre y asignar el equipo ganador
                                foreach (var item in partidoFase2.Partidos)
                                {
                                    if (item.Local == null)
                                    {
                                        EquipoPartido equipoPartido = new EquipoPartido
                                        {
                                            FechaCreacion = DateTime.Now,
                                            Equipo = part.Ganador.Equipo,
                                            JugadoresEnBanca = new List<string>(),
                                            JugadoresEnCancha = new List<string>()
                                        };
                                        item.Local = equipoPartido;

                                        _db.EquipoPartido.Add(equipoPartido);
                                        _db.Partido.Update(item);
                                        break;
                                    }
                                    if (item.Visitante == null)
                                    {
                                        EquipoPartido equipoPartido = new EquipoPartido
                                        {
                                            FechaCreacion = DateTime.Now,
                                            Equipo = part.Ganador.Equipo,
                                            JugadoresEnBanca = new List<string>(),
                                            JugadoresEnCancha = new List<string>()
                                        };
                                        item.Visitante = equipoPartido;

                                        _db.EquipoPartido.Add(equipoPartido);
                                        _db.Partido.Update(item);
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // si entro aca es porque es la final y asigno estado finalizado al torneo
                                TorneoHistorial? ultimoHistorialTorneo = torneoPartido.TorneoHistoriales.Where(f => f.FechaFin == null).FirstOrDefault();
                                if (ultimoHistorialTorneo != null)
                                {
                                    ultimoHistorialTorneo.FechaFin = DateTime.Now;
                                    _db.TorneoHistorial.Update(ultimoHistorialTorneo);
                                }
                                TorneoHistorial nuevoHistorialTorneo = new TorneoHistorial
                                {
                                    FechaInicio = DateTime.Now,
                                    DetalleCambioEstado = "Se finaliza torneo",
                                    UsuarioEditor = currentUser?.Id,
                                    TorneoEstado = _torneoEstadoServices.GetTorneoEstadoById(2) // asigno estado finalizado
                                };

                                torneoPartido.TorneoHistoriales.Add(nuevoHistorialTorneo);
                                _db.Torneo.Update(torneoPartido);
                            }
                        }

                        _db.HistorialEvento.Add(nuevoHistorial);
                        _db.Partido.Update(part);
                        _db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("El partido no se encuentra en estado iniciado");
                    }
                }
                else
                {
                    throw new Exception("Usuario no es árbitro");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool EsDeTorneo(string partido)
        {
            return _db.PartidoFase
                .Any(p => p.Partidos.Any(i => i.Titulo == partido));
        }

        public List<AccionPartido> GetAccionPartidoByPartido(int IdPartido)//listo
        {
            try
            {
                return _db.AccionPartido.Include(p => p.Partido).Include(p => p.TipoAccionPartido).Where(a => a.Partido.Id == IdPartido).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<AccionPartido> GetAccionPartidoByPartidoTipoAccion(AccionPartidoDTO accion)//listo
        {
            try
            {
                if (accion.EquipoLocal == true)
                {
                    return _db.AccionPartido.
                        Include(p => p.Partido).
                        ThenInclude(l => l.Local).
                        ThenInclude(e => e.Equipo).
                        ThenInclude(eq => eq.EquipoUsuarios).
                        Include(p => p.TipoAccionPartido).
                        Where(a => a.Partido.Id == accion.IdPartido && a.TipoAccionPartido.Id == accion.IdTipoAccion).ToList();
                }
                else
                {
                    return _db.AccionPartido.
                        Include(p => p.Partido).
                        ThenInclude(v => v.Visitante).
                        ThenInclude(e => e.Equipo).
                        ThenInclude(eq => eq.EquipoUsuarios).
                        Include(p => p.TipoAccionPartido).
                        Where(a => a.Partido.Id == accion.IdPartido && a.TipoAccionPartido.Id == accion.IdTipoAccion).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        } 

        public Partido GetPartidoById(int Id)//LISTO
        {
            try
            {
                Evento evento = _eventoServices.GetEventoById(Id);

                Partido? part = _db.Partido.Include(h => h.HistorialEventoList).
                    ThenInclude(ie => ie.EstadoEvento).
                    Include(l => l.Local).
                    ThenInclude(e => e.Equipo).
                    ThenInclude(eq => eq.EquipoUsuarios).
                    ThenInclude(u => u.Usuario).
                    Include(v => v.Visitante).
                    ThenInclude(e => e.Equipo).
                    ThenInclude(eq => eq.EquipoUsuarios).
                    ThenInclude(u => u.Usuario).
                    Include(d => d.Disciplina).
                    Include(c => c.Categoria).
                    Include(u => u.Usuarios).
                    Where(i => i.Id == Id).FirstOrDefault();

                part.Id = ((Evento)part).Id;
                part.Disciplina = evento.Disciplina;
                part.Categoria = evento.Categoria;
                part.TipoEvento = evento.TipoEvento;
                part.Instalacion = evento.Instalacion;
                
                List<HistorialEvento> EventoHistorial = new List<HistorialEvento>()
                { evento.HistorialEventoList.Where(f => f.FechaFin == null).FirstOrDefault()};

                part.HistorialEventoList = EventoHistorial;

                return part;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<UsuarioDTO> GetArbitroPlanilleroPartido(int idPartido)
        {
            Partido partido = GetPartidoById(idPartido);

            // obtener planillero y arbitro
            UsuarioDTO? arbitro = partido.idArbitro != null ? _usuarioServices.GetPerfilUsuario((int)partido.idArbitro) : null;
            UsuarioDTO? planillero = partido.idPlanillero != null ? _usuarioServices.GetPerfilUsuario((int)partido.idPlanillero) : null;

            List<UsuarioDTO> usuarios = new List<UsuarioDTO>();

            if (arbitro != null)
            {
                usuarios.Add(arbitro);
            }

            if (planillero!=null)
            {
                usuarios.Add(planillero);
            }

            return usuarios;
          
        }

        public AccionPartido GetAccionPartidoById(int Id)//listo
        {
            try
            {
                AccionPartido acc = _db.AccionPartido.Include(l => l.TipoAccionPartido).Include(l => l.Partido).Where(i => i.Id == Id).FirstOrDefault();

                return acc;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Partido> GetPartidos()//LISTO
        {
            try
            {

                List<Evento> eventos=_db.Evento.Include(p => p.HistorialEventoList).ThenInclude(ie => ie.EstadoEvento).Where(f => f.TipoEvento.NombreTipoEvento == "Partido").ToList();
                List<Partido> partidos = new List<Partido>();

                foreach (var item in eventos)
                {
                    Partido part = GetPartidoById(item.Id);
                    partidos.Add(part);
                }

                return partidos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool EsArbitro()//LISTO
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                if (currentUser == null)
                {
                    throw new Exception("Current user es null");
                }

                PerfilUsuario? arbitro = _db.PerfilUsuario.Where(pu => pu.FechaBaja == null && pu.Usuario.Id == currentUser.Id && (pu.Perfil.Id == 6 || pu.Perfil.Id == 1)).FirstOrDefault();

                if (arbitro != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public AsignacionDTO AsignacionPartido(AsignacionDTO asignacion)//LISTO
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                if (currentUser == null) 
                {
                    throw new Exception("CurrentUser es null");
                }

                Partido partido = GetPartidoById(asignacion.PartidoId);
                bool seEncuentra = partido.idArbitro == currentUser.Id || partido.idPlanillero == currentUser.Id ? true : false;

                PerfilUsuario? usuario = _db.PerfilUsuario.Include(l => l.Perfil).Where(a => a.Usuario.Id == currentUser.Id && a.FechaBaja == null).FirstOrDefault();

                if (seEncuentra && usuario != null)
                {
                    if (usuario.Perfil.Id == 1)//admin
                    {
                        asignacion.Planillero = true;
                        asignacion.Arbitro = true;
                    }
                    else if (usuario.Perfil.Id == 6)//arbitro
                    {
                        asignacion.Planillero = false;
                        asignacion.Arbitro = true;
                    }
                    else if (usuario.Perfil.Id == 7)//planillero
                    {
                        asignacion.Planillero = true;
                        asignacion.Arbitro = false;
                    }
                    else//ninguno de los anteriores
                    {
                        asignacion.Planillero = false;
                        asignacion.Arbitro = false;
                    }
                }
                else
                {
                    throw new Exception("No se encuentra el usuario asignado de ninguna forma al partido");
                }
                
                return asignacion;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Partido> GetPartidosAsignados()//LISTO
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                if (currentUser == null)
                {
                    throw new Exception("CurrentUser es null");
                }

                if (EsArbitro() == true){
                    List<Partido> partidos = GetPartidos();

                    List<Partido> partidosActivos = partidos.Where(p => p.idArbitro == currentUser.Id).ToList();

                    return partidosActivos;
                }
                else
                {
                    throw new Exception("Usuario no es árbitro");
                }
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<EquipoUsuario> GetEquipoLocal(int partidoId)//LISTO
        {
            try
            {
                Partido part = GetPartidoById(partidoId);
                return part.Local.Equipo.EquipoUsuarios.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<EquipoUsuario> GetEquipoVisitante(int partidoId)//LISTO
        {
            try
            {
                Partido part = GetPartidoById(partidoId);
                return part.Visitante.Equipo.EquipoUsuarios.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void IniciarPartido(PartidoDTO partidoDTO)//LISTO
        {
            try
            {
                if (EsArbitro() == true)
                {
                    Partido part = GetPartidoById(partidoDTO.Id);
                    var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                    //Cambio estado
                    HistorialEvento? ultimoHistorial = part.HistorialEventoList.Where(ih => ih.FechaFin == null).FirstOrDefault();

                    if (ultimoHistorial != null)
                    {
                        ultimoHistorial.FechaFin = DateTime.Now;
                        _db.HistorialEvento.Update(ultimoHistorial);
                    }
                    else
                    {
                        part.HistorialEventoList = new List<HistorialEvento>();
                    }

                    // creo nuevo historial y lo asigno
                    HistorialEvento nuevoHistorial = new HistorialEvento
                    {
                        FechaInicio = DateTime.Now,
                        DetalleCambioEstado = "Se inició partido",
                        UsuarioEditor = currentUser?.Id,
                        EstadoEvento = _eventoEstadoServices.GetEventoEstadoById(4) // asigno estado Iniciado
                    };

                    part.HistorialEventoList.Add(nuevoHistorial);

                    //Guardo lista de jugadores

                    List<EquipoUsuario> local = part.Local.Equipo.EquipoUsuarios.ToList();
                    List<EquipoUsuario> visit = part.Visitante.Equipo.EquipoUsuarios.ToList();

                    foreach (var idJug in local)
                    {
                        if (partidoDTO.jugadoresCanchaEquipLoc.Contains(idJug.Id))
                        {
                            part.Local.JugadoresEnCancha.Add(idJug.NumCamiseta.ToString()); // Suponiendo que Usuario tiene Nombre
                        }
                        else
                        {
                            part.Local.JugadoresEnBanca.Add(idJug.NumCamiseta.ToString());
                        }
                    }

                    foreach (var idJug in visit)
                    {
                        if (partidoDTO.jugadoresCanchaEquipVis.Contains(idJug.Id))
                        {
                            part.Visitante.JugadoresEnCancha.Add(idJug.NumCamiseta.ToString());
                        }
                        else
                        {
                            part.Visitante.JugadoresEnBanca.Add(idJug.NumCamiseta.ToString());
                        }
                    }

                    //Comienzo periodo
                    part.Periodo = 1;
                    part.ResultadoLocal = 0;
                    part.ResultadoVisitante = 0;
                    part.HistorialEventoList.Add(nuevoHistorial);

                    // verificar si partido pertenece a torneo
                    bool perteneceATorneo = EsDeTorneo(part.Titulo);

                    if (perteneceATorneo)
                    {
                        // obtener torneo al que pertenece y verificar estado de torneo
                        PartidoFase partidoFase = _db.PartidoFase.Include(t=>t.Torneo).ThenInclude(h=>h.TorneoHistoriales).ThenInclude(e=>e.TorneoEstado).FirstOrDefault(p => p.Partidos.Any(i => i.Titulo == part.Titulo))!;
                        Torneo torneoPartido = partidoFase.Torneo;

                        string estadoTorneo = "";

                        TorneoHistorial? ultimoHistorialTorneo = torneoPartido.TorneoHistoriales.Where(f => f.FechaFin == null).FirstOrDefault();
                        if (ultimoHistorialTorneo != null)
                        {
                            estadoTorneo = ultimoHistorialTorneo.TorneoEstado.NombreEstado;

                            // si el torneo no esta en curso lo inicio
                            if (estadoTorneo != Enums.EstadoTorneo.EnCurso.ToString())
                            {
                                TorneoHistorial nuevoHistorialTorneo = new TorneoHistorial
                                {
                                    FechaInicio = DateTime.Now,
                                    DetalleCambioEstado = "Se inicia torneo",
                                    UsuarioEditor = currentUser?.Id,
                                    TorneoEstado = _torneoEstadoServices.GetTorneoEstadoById(4) // asigno estado en curso
                                };

                                torneoPartido.TorneoHistoriales.Add(nuevoHistorialTorneo);
                                _db.TorneoHistorial.Add(nuevoHistorialTorneo);
                                _db.Torneo.Update(torneoPartido);
                            }
                        }                        
                        
                    }

                    _db.HistorialEvento.Add(nuevoHistorial);
                    _db.EquipoPartido.Update(part.Local);
                    _db.EquipoPartido.Update(part.Visitante);
                    _db.Partido.Update(part);
                    _db.SaveChanges();
                }
                else
                {
                    throw new Exception("Usuario no es árbitro");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void SuspenderPartido(PartidoDTO partidoDTO)//LISTO
        {
            try
            {
                if (EsArbitro() == true)
                {
                    Partido part = GetPartidoById(partidoDTO.Id);
                    var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                    //Cambio estado
                    HistorialEvento? ultimoHistorial = part.HistorialEventoList.Where(ih => ih.FechaFin == null).FirstOrDefault();
                    if (ultimoHistorial.EstadoEvento.Id == 1 || ultimoHistorial.EstadoEvento.Id == 4 || ultimoHistorial.EstadoEvento.Id == 6)
                    {
                        if (ultimoHistorial != null)
                        {
                            ultimoHistorial.FechaFin = DateTime.Now;
                            _db.HistorialEvento.Update(ultimoHistorial);
                        }
                        else
                        {
                            part.HistorialEventoList = new List<HistorialEvento>();
                        }

                        // creo nuevo historial y lo asigno
                        HistorialEvento nuevoHistorial = new HistorialEvento
                        {
                            FechaInicio = DateTime.Now,
                            DetalleCambioEstado = "Se suspende el partido por: " + partidoDTO.Motivo,
                            UsuarioEditor = currentUser?.Id,
                            EstadoEvento = _eventoEstadoServices.GetEventoEstadoById(5) // asigno estado Suspendido
                        };

                        part.HistorialEventoList.Add(nuevoHistorial);


                        _db.HistorialEvento.Add(nuevoHistorial);
                        _db.Partido.Update(part);
                        _db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("El partido se encuentra en estado cancelado o finalizado");
                    }
                }
                else
                {
                    throw new Exception("Usuario no es árbitro");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

    }
}

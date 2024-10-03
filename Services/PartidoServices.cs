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

namespace ApiNet8.Services
{
    public class PartidoServices : IPartidoServices
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUsuarioServices _usuarioServices;
        private readonly IEventoEstadoService _eventoEstadoServices;
        private readonly ITipoAccionPartidoServices _tipoAccionPartidoServices;

        public PartidoServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor, IUsuarioServices usuarioServices, IEventoEstadoService eventoEstadoServices, ITipoAccionPartidoServices tipoAccionPartidoServices)
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _usuarioServices = usuarioServices;
            _eventoEstadoServices = eventoEstadoServices;
            _tipoAccionPartidoServices = tipoAccionPartidoServices;
        }

        public void ActualizarEstadisticaPartido()
        {
            throw new NotImplementedException();
        }

        public void AltaAccionPartido(AccionPartidoDTO accion)
        {
            try
            {
                Partido part = GetPartidoById(accion.IdPartido);
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                using (var transaction = _db.Database.BeginTransaction())
                {
                    TipoAccionPartido tipAcc = _tipoAccionPartidoServices.GetTipoAccionPartidoById(accion.IdTipoAccion);

                    AccionPartido accionPartido = new AccionPartido()
                    {
                        NroJugador = accion.NroJugador,
                        Minuto = accion.Minuto,
                        Descripcion = tipAcc.NombreTipoAccion,
                        FechaCreacion = DateTime.Now,
                        UsuarioEditor = currentUser.Id,
                        Periodo = part.Periodo,
                        TipoAccionPartido = tipAcc,
                        EquipoLocal = accion.EquipoLocal
                    };

                    if (tipAcc.NombreTipoAccion == "Gol")
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

                    _db.AccionPartido.Add(accionPartido);
                    _db.Partido.Update(part);
                    _db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void IniciarTiempo(int partidoId)
        {
            try
            {
                Partido part = GetPartidoById(partidoId);
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

                part.Periodo = part.Periodo + 1;

                _db.HistorialEvento.Add(nuevoHistorial);
                _db.Partido.Update(part);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        public void FinalizarTiempo(int partidoId)
        {
            try
            {
                Partido part = GetPartidoById(partidoId);
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
                    DetalleCambioEstado = "El partido está en entretiempo",
                    UsuarioEditor = currentUser?.Id,
                    EstadoEvento = _eventoEstadoServices.GetEventoEstadoById(6) // asigno estado Entretiempo
                };

                part.HistorialEventoList.Add(nuevoHistorial);

                // Sumo el set ganado
                if (part.Disciplinas.FirstOrDefault().Nombre == "Voley")
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

                _db.HistorialEvento.Add(nuevoHistorial);
                _db.Partido.Update(part);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Estadistica AltaEstadisticaPartido()
        {
            throw new NotImplementedException();
        }

        public void BajaEstadisticaPartido()
        {
            throw new NotImplementedException();
        }

        public bool ExistePartido(string nombre)
        {
            throw new NotImplementedException();
        }

        public void FinalizarPartido(int partidoId)
        {
            try
            {
                Partido part = GetPartidoById(partidoId);
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
                    DetalleCambioEstado = "Se finalizó el partido",
                    UsuarioEditor = currentUser?.Id,
                    EstadoEvento = _eventoEstadoServices.GetEventoEstadoById(3) // asigno estado Finalizado
                };

                part.HistorialEventoList.Add(nuevoHistorial);

                //part.FechaFin = DateTime.Now;

                if (part.Disciplinas.FirstOrDefault().Nombre == "Voley")
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


                _db.HistorialEvento.Add(nuevoHistorial);
                _db.Partido.Update(part);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<AccionPartido> GetAccionPartidoByPartido(int IdPartido)
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

        public List<Estadistica> GetEstadisticasPartidos(int Id)
        {
            throw new NotImplementedException();
        }

        public Partido GetPartidoById(int Id)
        {
            try
            {
                Partido part = _db.Partido.Include(h => h.HistorialEventoList).
                    ThenInclude(ie => ie.EstadoEvento).
                    Include(l => l.Local).
                    ThenInclude(e => e.Equipo).
                    ThenInclude(eq => eq.EquipoUsuarios).
                    Include(v => v.Visitante).
                    ThenInclude(e => e.Equipo).
                    ThenInclude(eq => eq.EquipoUsuarios).
                    Include(d => d.Disciplinas).
                    Include(c => c.Categoria).
                    Where(i => i.Id == Id).FirstOrDefault();

                return part;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<Partido> GetPartidos()
        {
            try
            {
               return _db.Partido.Include(p => p.HistorialEventoList).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            //throw new NotImplementedException();
        }

        public List<Partido> GetPartidosAsignados()
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Usuario usuario = _usuarioServices.GetUsuarioById(currentUser.Id);

                List<Partido> partidos = GetPartidos();

                List<Partido> partidosActivos = partidos.Where(i => i.Usuarios.Contains(usuario)).ToList();

                return partidosActivos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<EquipoUsuario> GetEquipoLocal(int partidoId)
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

        public List<EquipoUsuario> GetEquipoVisitante(int partidoId)
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

        public void IniciarPartido(PartidoDTO partidoDTO)
        {
            try
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

                List<EquipoUsuario> local = GetEquipoLocal(partidoDTO.Id);
                List<EquipoUsuario> visit = GetEquipoVisitante(partidoDTO.Id);

                foreach (var idJug in local)
                {
                    if (partidoDTO.jugadoresCanchaEquipLoc.Contains(idJug.Id))
                    {
                        part.Local.JugadoresEnCancha.Add(idJug.Usuario.Nombre + idJug.Usuario.Apellido); // Suponiendo que Usuario tiene Nombre
                    }
                    else
                    {
                        part.Local.JugadoresEnBanca.Add(idJug.Usuario.Nombre + idJug.Usuario.Apellido);
                    }
                }

                foreach (var idJug in visit)
                {
                    if (partidoDTO.jugadoresCanchaEquipVis.Contains(idJug.Id))
                    {
                        part.Visitante.JugadoresEnCancha.Add(idJug.Usuario.Nombre + idJug.Usuario.Apellido);
                    }
                    else
                    {
                        part.Visitante.JugadoresEnBanca.Add(idJug.Usuario.Nombre + idJug.Usuario.Apellido);
                    }
                }

                //Comienzo periodo
                part.Periodo = 1;
                part.ResultadoLocal = 0;
                part.ResultadoVisitante = 0;

                _db.HistorialEvento.Add(nuevoHistorial);
                _db.EquipoPartido.Update(part.Local);
                _db.EquipoPartido.Update(part.Visitante);
                _db.Partido.Update(part);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        public void SuspenderPartido(PartidoDTO partidoDTO)
        {
            try
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
                    DetalleCambioEstado = "Se suspende el partido por: " + partidoDTO.Motivo,
                    UsuarioEditor = currentUser?.Id,
                    EstadoEvento = _eventoEstadoServices.GetEventoEstadoById(5) // asigno estado Suspendido
                };

                part.HistorialEventoList.Add(nuevoHistorial);


                _db.HistorialEvento.Add(nuevoHistorial);
                _db.Partido.Update(part);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

    }
}

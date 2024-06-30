using ApiNet8.Models.Eventos;
using ApiNet8.Models.Club;
using ApiNet8.Models.Partidos;
using Microsoft.EntityFrameworkCore;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.NoticiasYNotificaciones;
using ApiNet8.Models.Reservas;
using ApiNet8.Models.Torneos;
using ApiNet8.Models.TYC;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        // agregar clases a la base de datos
        public DbSet<ClubHistorial> ClubHistorial { get; set; }
        public DbSet<ParametrosClub> ParametrosClub { get; set; }
        public DbSet<PerfilClub> PerfilClub { get; set; }

        public DbSet<Asistencia> Asistencia { get; set; }
        public DbSet<EstadoEvento> EstadoEvento { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<HistorialEvento> HistorialEvento { get; set; }
        public DbSet<Inscripcion> Inscripcion { get; set; }
        public DbSet<TipoEvento> TipoEvento { get; set; }

        public DbSet<AsistenciaLeccion> AsistenciaLeccion { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<InscripcionUsuario> InscripcionUsuario { get; set; }
        public DbSet<Leccion> Leccion { get; set; }
        public DbSet<LeccionEstado> LeccionEstado { get; set; }
        public DbSet<LeccionHistorial> LeccionHistorial { get; set; }

        public DbSet<Noticias> Noticias { get; set; }
        public DbSet<Notificacion> Notificacion { get; set; }
        public DbSet<UsuarioNotificacion> UsuarioNotificacion { get; set; }

        public DbSet<AccionPartido> AccionPartido { get; set; }
        public DbSet<Equipo> Equipo { get; set; }
        public DbSet<EquipoEstado> EquipoEstado { get; set; }
        public DbSet<EquipoHistorial> EquipoHistorial { get; set; }
        public DbSet<EquipoPartido> EquipoPartido { get; set; }
        public DbSet<EquipoUsuario> EquipoUsuario { get; set; }
        public DbSet<Estadistica> Estadistica { get; set; }
        public DbSet<Partido> Partido { get; set; }
        public DbSet<TipoAccionEstado> TipoAccionEstado { get; set; }
        public DbSet<TipoAccionHistorial> TipoAccionHistorial { get; set; }
        public DbSet<TipoAccionPartido> TipoAccionPartido { get; set; }

        public DbSet<Instalacion> Instalacion { get; set; }
        public DbSet<InstalacionEstado> InstalacionEstado { get; set; }
        public DbSet<InstalacionHistorial> InstalacionHistorial { get; set; }
        public DbSet<Reserva> Reserva { get; set; }

        public DbSet<PartidoFase> PartidoFase { get; set; }
        public DbSet<Torneo> Torneo { get; set; }
        public DbSet<TorneoEstado> TorneoEstado { get; set; }
        public DbSet<TorneoHistorial> TorneoHistorial { get; set; }

        public DbSet<HistorialTerminosYCondiciones> HistorialTerminosYCondiciones { get; set; }
        public DbSet<TerminosYCondiciones> TerminosYCondiciones { get; set; }

        public DbSet<CodigoVerificacion> CodigoVerificacion { get; set; }
        public DbSet<EstadoSolicitudAsociacion> EstadoSolicitudAsociacion { get; set; }
        public DbSet<GrupoFamiliar> GrupoFamiliar { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuario { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<SolicitudAsociacion> SolicitudAsociacion { get; set; }
        public DbSet<SolicitudAsociacionHistorial> SolicitudAsociacionHistorial { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioEstado> UsuarioEstado { get; set; }
        public DbSet<UsuarioHistorial> UsuarioHistorial { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // aquí se pueden modificar nombres de tablas y columnas, cargar data inicial(estados iniciales)

            // data seeding
            //modelBuilder.Entity<Partidos>().HasData(
            //    new Partidos { Id = 1, EquipoA="Independiente", EquipoB="Boca", Name="Fecha 1 copa de la liga", Resultado="2-0"});
        }
    }
}

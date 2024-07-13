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
        public DbSet<PerfilPermiso> PerfilPermiso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // aquí se pueden modificar nombres de tablas y columnas

            // Se desactiva la eliminacion en cascada para evitar ciclos de eliminacion
            modelBuilder.Entity<Estadistica>()
                 .HasOne(e => e.Partido)
                 .WithMany()
                 .HasForeignKey(e => e.Id)
                 .OnDelete(DeleteBehavior.Restrict); // Desactivar eliminación en cascada

            modelBuilder.Entity<Estadistica>()
                .HasOne(e => e.TipoAccionPartido)
                .WithMany()
                .HasForeignKey(e => e.Id)
                .OnDelete(DeleteBehavior.Restrict); // Desactivar eliminación en cascada

            modelBuilder.Entity<Estadistica>()
                .HasOne(e => e.AsistenciaLeccion)
                .WithMany()
                .HasForeignKey(e => e.Id)
                .OnDelete(DeleteBehavior.Restrict); // Desactivar eliminación en cascada

            modelBuilder.Entity<Estadistica>()
                .HasOne(e => e.Equipo)
                .WithMany()
                .HasForeignKey(e => e.Id)
                .OnDelete(DeleteBehavior.Restrict); // Desactivar eliminación en cascada

            modelBuilder.Entity<InscripcionUsuario>()
               .HasOne(e => e.Usuario)
               .WithMany()
               .HasForeignKey(e => e.Id)
               .OnDelete(DeleteBehavior.Restrict); // Desactivar eliminación en cascada


            // cargar data inicial
            //modelBuilder.Entity<Partidos>().HasData(
            //    new Partidos { Id = 1, EquipoA = "Independiente", EquipoB = "Boca", Name = "Fecha 1 copa de la liga", Resultado = "2-0" });

            modelBuilder.Entity<UsuarioEstado>().HasData(
                new UsuarioEstado { Id = 1, DescripcionEstado = "Usuario activo en el club", NombreEstado = "Activo", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
                new UsuarioEstado { Id = 2, DescripcionEstado = "Usuario bloqueado", NombreEstado = "Bloqueado", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
                new UsuarioEstado { Id = 3, DescripcionEstado = "Usuario desactivado", NombreEstado = "Desactivado", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 });

            modelBuilder.Entity<EstadoEvento>().HasData(
                new EstadoEvento { Id = 1, DescripcionEstado = "Evento creado", NombreEstado = "Creado", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
                new EstadoEvento { Id = 2, DescripcionEstado = "Evento cancelado", NombreEstado = "Cancelado", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
                new EstadoEvento { Id = 3, DescripcionEstado = "Evento finalizado", NombreEstado = "Finalizado", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
                new EstadoEvento { Id = 4, DescripcionEstado = "Evento iniciado", NombreEstado = "Iniciado", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
                new EstadoEvento { Id = 5, DescripcionEstado = "Evento suspendido", NombreEstado = "Suspendido", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
                new EstadoEvento { Id = 6, DescripcionEstado = "Evento en entretiempo", NombreEstado = "Entretiempo", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 });

            modelBuilder.Entity<EquipoEstado>().HasData(
                new EquipoEstado { Id = 1, DescripcionEstado = "Equipo activo", NombreEstado = "Activo", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
                new EquipoEstado { Id = 2, DescripcionEstado = "Equipo inactivo", NombreEstado = "Inactivo", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
                new EquipoEstado { Id = 3, DescripcionEstado = "Equipo suspendido", NombreEstado = "Suspendido", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 });

        }
    }
}

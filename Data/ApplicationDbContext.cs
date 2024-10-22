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
using ApiNet8.Services.IServices;

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

            modelBuilder.Entity<Disciplina>().HasData(
                new Disciplina { Id = 1, Nombre = "Futbol", Descripcion = "Juego entre dos equipos de once jugadores cada uno, cuyo objetivo es hacer entrar en la portería contraria un balón que no puede ser tocado con las manos ni con los brazos, salvo por el portero en su área de meta.", CantJugadores = 11, PeriodosMax = 2, TarjetasAdvertencia = 2, TarjetasExpulsion = 1, CantJugadoresEnBanca = 11, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
                new Disciplina { Id = 2, Nombre = "Voleyball", Descripcion = "Es un deporte donde dos equipos se enfrentan sobre un terreno de juego liso separados por una red central, tratando de pasar el balón por encima de la red hacia el suelo del campo contrario.", CantJugadores = 7, PeriodosMax = 5, TarjetasAdvertencia = 2, TarjetasExpulsion = 1, CantJugadoresEnBanca = 7, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 });

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

            modelBuilder.Entity<TipoEvento>().HasData(
               new TipoEvento { Id = 1, NombreTipoEvento = "Partido", Descripcion = "Partido de un deporte", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
               new TipoEvento { Id = 6, NombreTipoEvento = "Recital", Descripcion = "Recital en el club", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
               new TipoEvento { Id = 3, NombreTipoEvento = "Taller", Descripcion = "Taller de enseñanza", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
               new TipoEvento { Id = 4, NombreTipoEvento = "Curso", Descripcion = "Curso", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
               new TipoEvento { Id = 5, NombreTipoEvento = "Feria", Descripcion = "Feria", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 });

            modelBuilder.Entity<EquipoEstado>().HasData(
                new EquipoEstado { Id = 1, DescripcionEstado = "Equipo activo", NombreEstado = "Activo", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
                new EquipoEstado { Id = 2, DescripcionEstado = "Equipo inactivo", NombreEstado = "Inactivo", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
                new EquipoEstado { Id = 3, DescripcionEstado = "Equipo suspendido", NombreEstado = "Suspendido", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 });

            modelBuilder.Entity<EstadoSolicitudAsociacion>().HasData(
              new EstadoSolicitudAsociacion { Id = 1, DescripcionEstado = "Solicitud pendiente", NombreEstado = "Pendiente", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
              new EstadoSolicitudAsociacion { Id = 2, DescripcionEstado = "Solicitud aprobada", NombreEstado = "Aprobada", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
              new EstadoSolicitudAsociacion { Id = 3, DescripcionEstado = "Solicitud rechazada", NombreEstado = "Rechazada", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 });

            modelBuilder.Entity<Perfil>().HasData(
              new Perfil { Id = 1, NombrePerfil = "Admin", DescripcionPerfil = "Administrador general del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
              new Perfil { Id = 2, NombrePerfil = "Administrativo", DescripcionPerfil = "Administrativo perteneciente al club", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
              new Perfil { Id = 3, NombrePerfil = "Simpatizante", DescripcionPerfil = "Usuario publico", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
              new Perfil { Id = 4, NombrePerfil = "Socio", DescripcionPerfil = "Usuario privado socio del club", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
              new Perfil { Id = 5, NombrePerfil = "Profesor", DescripcionPerfil = "Usuario privado profesor perteneciente al club", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
              new Perfil { Id = 6, NombrePerfil = "Arbitro", DescripcionPerfil = "Usuario privado arbitro oficial para partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 },
              new Perfil { Id = 7, NombrePerfil = "Planillero", DescripcionPerfil = "Usuario privado ayudante de profesor en partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1 });

            modelBuilder.Entity<Permiso>().HasData(
               new Permiso { Id = 1, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "ABM usuario" },
               new Permiso { Id = 2, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Solicitudes", Funcionalidades = "ABM solicitud" },
               new Permiso { Id = 3, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Perfiles", Funcionalidades = "ABM perfil" },
               new Permiso { Id = 4, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Configuraciones generales", Funcionalidades = "ABM configuración del sistema" },
               new Permiso { Id = 5, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Disciplina", Funcionalidades = "ABM disciplina" },
               new Permiso { Id = 6, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Categoria", Funcionalidades = "ABM categoria" },

               new Permiso { Id = 7, NombrePermiso = "Disciplina", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Disciplina", Funcionalidades = "Ver disciplinas" },

               new Permiso { Id = 8, NombrePermiso = "Instalaciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Ver instalaciones" },
               new Permiso { Id = 9, NombrePermiso = "Instalaciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "ABM instalación" },

               new Permiso { Id = 10, NombrePermiso = "Noticias", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Noticias", Funcionalidades = "Ver / Compartir noticias" },
               new Permiso { Id = 11, NombrePermiso = "Noticias", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Noticias", Funcionalidades = "ABM noticia" },
               new Permiso { Id = 12, NombrePermiso = "Noticias", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Notificaciones", Funcionalidades = "ABM notificación" },

               new Permiso { Id = 13, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Ver partidos" },
               new Permiso { Id = 14, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Gestionar partido" },
               new Permiso { Id = 15, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Gestionar estadisticas partido" },

               new Permiso { Id = 16, NombrePermiso = "Mi perfil", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Mi perfil", Funcionalidades = "Ver mi perfil" },
               new Permiso { Id = 17, NombrePermiso = "Mi perfil", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Mi perfil", Funcionalidades = "Generar QR" },

               new Permiso { Id = 18, NombrePermiso = "Reservas", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Reservas", Funcionalidades = "ABM reserva" },

               new Permiso { Id = 19, NombrePermiso = "Lecciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Lecciones", Funcionalidades = "Ver lección" },
               new Permiso { Id = 20, NombrePermiso = "Lecciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Lecciones", Funcionalidades = "Gestionar lección" },

               new Permiso { Id = 21, NombrePermiso = "Eventos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Eventos", Funcionalidades = "Gestionar evento" },
               new Permiso { Id = 22, NombrePermiso = "Eventos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Eventos", Funcionalidades = "Asistencia evento" },

               new Permiso { Id = 23, NombrePermiso = "Estadisticas", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Estadisticas", Funcionalidades = "Ver estadisticas de lección y partidos" },

               new Permiso { Id = 24, NombrePermiso = "Torneos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Torneos", Funcionalidades = "ABM torneo" },
               new Permiso { Id = 25, NombrePermiso = "Torneos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Torneos", Funcionalidades = "Inscripción torneo" },
               new Permiso { Id = 26, NombrePermiso = "Torneos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Equipos", Funcionalidades = "Gestionar equipo" },

               new Permiso { Id = 27, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Equipo", Funcionalidades = "ABM estado equipo" },
               new Permiso { Id = 28, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Evento", Funcionalidades = "ABM estado evento" },
               new Permiso { Id = 29, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "ABM estado usuario" },
               new Permiso { Id = 30, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Lección", Funcionalidades = "ABM estado lección" },
               new Permiso { Id = 31, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Instalación", Funcionalidades = "ABM estado instalación" },
               new Permiso { Id = 32, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Torneo", Funcionalidades = "ABM estado torneo" },

               new Permiso { Id = 33, NombrePermiso = "Tipos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Evento", Funcionalidades = "ABM tipo evento" },
               new Permiso { Id = 34, NombrePermiso = "Tipos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Accion", Funcionalidades = "ABM tipo accion" },

               new Permiso { Id = 35, NombrePermiso = "Backup", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Backup", Funcionalidades = "Modificar backup" },
               new Permiso { Id = 36, NombrePermiso = "Backup", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Backup", Funcionalidades = "Visualizar Backup" },

   new Permiso { Id = 37, NombrePermiso = "Reportes", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Reservas", Funcionalidades = "Descargar PDF/Excel" },
   new Permiso { Id = 38, NombrePermiso = "Reportes", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Asistencia lecciones", Funcionalidades = "Descargar PDF/Excel" },
   new Permiso { Id = 39, NombrePermiso = "Reportes", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Asistencias eventos", Funcionalidades = "Descargar PDF/Excel" },
   new Permiso { Id = 40, NombrePermiso = "Reportes", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Estadisticas", Funcionalidades = "Descargar PDF/Excel" }
   );
          
        }
    }
}

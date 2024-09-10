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
              new Permiso { Id = 1, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Alta usuario" },
              new Permiso { Id = 2, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Modificación usuario" },
              new Permiso { Id = 3, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Baja usuario" },
              new Permiso { Id = 4, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Blanquear contraseña usuario" },
              new Permiso { Id = 5, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Ver información usuario" },
              new Permiso { Id = 6, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Bloquear usuario" },
              new Permiso { Id = 7, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Desbloquear usuario" },
              new Permiso { Id = 8, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Alta grupo familiar" },
              new Permiso { Id = 9, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Modificación grupo familiar" },
              new Permiso { Id = 10, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Baja grupo familiar" },

              new Permiso { Id = 11, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Solicitudes", Funcionalidades = "Aceptar solicitud" },
              new Permiso { Id = 12, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Solicitudes", Funcionalidades = "Rechazar solicitud" },

              new Permiso { Id = 13, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Perfiles", Funcionalidades = "Alta perfil" },
              new Permiso { Id = 14, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Perfiles", Funcionalidades = "Modificación perfil" },
              new Permiso { Id = 15, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Perfiles", Funcionalidades = "Baja perfil" },

              new Permiso { Id = 16, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Configuraciones generales", Funcionalidades = "Alta configuracion del sistema" },
              new Permiso { Id = 17, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Configuraciones generales", Funcionalidades = "Modificación configuracion del sistema" },
              new Permiso { Id = 18, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Configuraciones generales", Funcionalidades = "Baja configuracion del sistema" },
              new Permiso { Id = 19, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Configuraciones generales", Funcionalidades = "Activar configuracion del sistema" },
              new Permiso { Id = 20, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Configuraciones generales", Funcionalidades = "Alta terminos y condiciones" },
              new Permiso { Id = 21, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Configuraciones generales", Funcionalidades = "Baja terminos y condiciones" },

              new Permiso { Id = 22, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Disciplina", Funcionalidades = "Alta disciplina" },
              new Permiso { Id = 23, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Disciplina", Funcionalidades = "Modificación disciplina" },
              new Permiso { Id = 24, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Disciplina", Funcionalidades = "Baja disciplina" },

              new Permiso { Id = 25, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Categoria", Funcionalidades = "Alta categoria" },
              new Permiso { Id = 26, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Categoria", Funcionalidades = "Modificación categoria" },
              new Permiso { Id = 27, NombrePermiso = "Configuracion del sistema", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Categoria", Funcionalidades = "Baja categoria" },

              new Permiso { Id = 28, NombrePermiso = "Disciplina", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Disciplina", Funcionalidades = "Ver disciplinas" },

              new Permiso { Id = 29, NombrePermiso = "Instalaciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Instalaciones", Funcionalidades = "Ver instalaciones" },
              new Permiso { Id = 30, NombrePermiso = "Instalaciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Instalaciones", Funcionalidades = "Alta instalacion" },
              new Permiso { Id = 31, NombrePermiso = "Instalaciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Instalaciones", Funcionalidades = "Modificación instalacion" },
              new Permiso { Id = 32, NombrePermiso = "Instalaciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Instalaciones", Funcionalidades = "Baja instalacion" },

              new Permiso { Id = 33, NombrePermiso = "Noticias", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Noticias", Funcionalidades = "Ver noticias" },
              new Permiso { Id = 34, NombrePermiso = "Noticias", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Noticias", Funcionalidades = "Alta noticia" },
              new Permiso { Id = 35, NombrePermiso = "Noticias", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Noticias", Funcionalidades = "Modificación noticia" },
              new Permiso { Id = 36, NombrePermiso = "Noticias", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Noticias", Funcionalidades = "Baja noticia" },
              new Permiso { Id = 37, NombrePermiso = "Noticias", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Noticias", Funcionalidades = "Compartir noticia" },
              new Permiso { Id = 38, NombrePermiso = "Noticias", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Notificaciones", Funcionalidades = "Alta notificacion" },
              new Permiso { Id = 39, NombrePermiso = "Noticias", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Notificaciones", Funcionalidades = "Baja notificacion" },

              new Permiso { Id = 40, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Ver partidos" },
              new Permiso { Id = 41, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Visualizar partidos en tiempo real" },
              new Permiso { Id = 42, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Iniciar partido" },
              new Permiso { Id = 43, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Suspender partido" },
              new Permiso { Id = 44, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Preparar partido" },
              new Permiso { Id = 45, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Finalizar partido" },
              new Permiso { Id = 46, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Alta accion de partido" },
              new Permiso { Id = 47, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Alta estadistica " },
              new Permiso { Id = 48, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Modificación estadistica" },
              new Permiso { Id = 49, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Baja estadistica" },
              new Permiso { Id = 50, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Ver estadistica" },
              new Permiso { Id = 51, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Iniciar tiempo" },
              new Permiso { Id = 52, NombrePermiso = "Partidos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Partidos", Funcionalidades = "Finalizar tiempo" },

              new Permiso { Id = 53, NombrePermiso = "Mi perfil", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Mi perfil", Funcionalidades = "Asociarse" },
              new Permiso { Id = 54, NombrePermiso = "Mi perfil", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Mi perfil", Funcionalidades = "Darse de baja" },
              new Permiso { Id = 55, NombrePermiso = "Mi perfil", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Mi perfil", Funcionalidades = "Modificación mi perfil" },
              new Permiso { Id = 56, NombrePermiso = "Mi perfil", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Mi perfil", Funcionalidades = "Generar qr" },
              new Permiso { Id = 57, NombrePermiso = "Mi perfil", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Mi perfil", Funcionalidades = "Ver mi perfil" },

              new Permiso { Id = 58, NombrePermiso = "Quienes somos?", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Quienes somos?", Funcionalidades = "Ver quienes somos" },

              new Permiso { Id = 59, NombrePermiso = "Reservas", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Reservas", Funcionalidades = "Alta reserva" },
              new Permiso { Id = 60, NombrePermiso = "Reservas", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Reservas", Funcionalidades = "Modificación reserva" },
              new Permiso { Id = 61, NombrePermiso = "Reservas", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Reservas", Funcionalidades = "Baja reserva" },

              new Permiso { Id = 62, NombrePermiso = "Lecciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Lecciones", Funcionalidades = "Inscribirse a leccion" },
              new Permiso { Id = 63, NombrePermiso = "Lecciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Lecciones", Funcionalidades = "Desinscribirse a leccion" },
              new Permiso { Id = 64, NombrePermiso = "Lecciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Lecciones", Funcionalidades = "Comenzar leccion" },
              new Permiso { Id = 65, NombrePermiso = "Lecciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Lecciones", Funcionalidades = "Ver estadisticas de leccion" },
              new Permiso { Id = 66, NombrePermiso = "Lecciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Lecciones", Funcionalidades = "Registrar asistencia" },
              new Permiso { Id = 67, NombrePermiso = "Lecciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Lecciones", Funcionalidades = "Modificación estadistica" },
              new Permiso { Id = 68, NombrePermiso = "Lecciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Lecciones", Funcionalidades = "Baja estadistica" },
              new Permiso { Id = 69, NombrePermiso = "Lecciones", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Lecciones", Funcionalidades = "Finalizar leccion" },

              new Permiso { Id = 70, NombrePermiso = "Eventos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Eventos", Funcionalidades = "Alta evento" },
              new Permiso { Id = 71, NombrePermiso = "Eventos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Eventos", Funcionalidades = "Modificación evento" },
              new Permiso { Id = 72, NombrePermiso = "Eventos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Eventos", Funcionalidades = "Baja evento" },
              new Permiso { Id = 73, NombrePermiso = "Eventos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Eventos", Funcionalidades = "Tomar asistencia a evento" },
              new Permiso { Id = 74, NombrePermiso = "Eventos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Eventos", Funcionalidades = "Inscribirse a evento" },
              new Permiso { Id = 75, NombrePermiso = "Eventos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Eventos", Funcionalidades = "Desinscribirse a evento" },

              new Permiso { Id = 76, NombrePermiso = "Estadisticas", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Estadisticas", Funcionalidades = "Ver estadisticas de leccion y partidos" },

              new Permiso { Id = 77, NombrePermiso = "Torneos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Torneos", Funcionalidades = "Alta torneo" },
              new Permiso { Id = 78, NombrePermiso = "Torneos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Torneos", Funcionalidades = "Modificación torneo" },
              new Permiso { Id = 79, NombrePermiso = "Torneos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Torneos", Funcionalidades = "Baja torneo" },
              new Permiso { Id = 80, NombrePermiso = "Torneos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Torneos", Funcionalidades = "Inscribirse a torneo" },
              new Permiso { Id = 81, NombrePermiso = "Torneos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Torneos", Funcionalidades = "Desinscribirse a torneo" },
              new Permiso { Id = 82, NombrePermiso = "Torneos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Equipos", Funcionalidades = "Alta equipo" },
              new Permiso { Id = 83, NombrePermiso = "Torneos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Equipos", Funcionalidades = "Modificación equipo" },
              new Permiso { Id = 84, NombrePermiso = "Torneos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Equipos", Funcionalidades = "Baja equipo" },

              new Permiso { Id = 85, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Equipo", Funcionalidades = "Alta estado equipo" },
              new Permiso { Id = 86, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Equipo", Funcionalidades = "Modificación estado equipo" },
              new Permiso { Id = 87, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Equipo", Funcionalidades = "Baja estado equipo" },
              new Permiso { Id = 88, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Evento", Funcionalidades = "Alta estado evento" },
              new Permiso { Id = 89, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Evento", Funcionalidades = "Modificación estado evento" },
              new Permiso { Id = 90, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Evento", Funcionalidades = "Baja estado evento" },
              new Permiso { Id = 91, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Alta estado usuario" },
              new Permiso { Id = 92, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Modificación estado usuario" },
              new Permiso { Id = 93, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Usuario", Funcionalidades = "Baja estado usuario" },
              new Permiso { Id = 94, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Leccion", Funcionalidades = "Alta estado leccion" },
              new Permiso { Id = 95, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Leccion", Funcionalidades = "Modificación estado leccion" },
              new Permiso { Id = 96, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Leccion", Funcionalidades = "Baja estado leccion" },
              new Permiso { Id = 97, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Instalacion", Funcionalidades = "Alta estado instalacion" },
              new Permiso { Id = 98, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Instalacion", Funcionalidades = "Modificación  estado instalacion" },
              new Permiso { Id = 99, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Instalacion", Funcionalidades = "Baja estado instalacion" },
              new Permiso { Id = 100, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Torneo", Funcionalidades = "Alta estado torneo" },
              new Permiso { Id = 101, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Torneo", Funcionalidades = "Modificación estado torneo" },
              new Permiso { Id = 102, NombrePermiso = "Estados", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Torneo", Funcionalidades = "Baja estado torneo" },

              new Permiso { Id = 103, NombrePermiso = "Tipos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Evento", Funcionalidades = "Alta tipo evento" },
              new Permiso { Id = 104, NombrePermiso = "Tipos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Evento", Funcionalidades = "Modificación tipo evento" },
              new Permiso { Id = 105, NombrePermiso = "Tipos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Evento", Funcionalidades = "Baja tipo evento" },
              new Permiso { Id = 106, NombrePermiso = "Tipos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Accion", Funcionalidades = "Alta tipo accion" },
              new Permiso { Id = 107, NombrePermiso = "Tipos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Accion", Funcionalidades = "Modificación tipo accion" },
              new Permiso { Id = 108, NombrePermiso = "Tipos", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Accion", Funcionalidades = "Baja tipo accion" },

              new Permiso { Id = 109, NombrePermiso = "Backup", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Backup", Funcionalidades = "Descargar guia para generar backup" },
              new Permiso { Id = 110, NombrePermiso = "Backup", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Backup", Funcionalidades = "Descargar guia para restaurar backup" },
              new Permiso { Id = 111, NombrePermiso = "Backup", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Backup", Funcionalidades = "Actualizar archivos" },

              new Permiso { Id = 112, NombrePermiso = "Reportes", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Reservas", Funcionalidades = "Descargar Excel" },
              new Permiso { Id = 113, NombrePermiso = "Reportes", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Reservas", Funcionalidades = "Descargar PDF" },
              new Permiso { Id = 114, NombrePermiso = "Reportes", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Asistencia lecciones", Funcionalidades = "Descargar Excel" },
              new Permiso { Id = 115, NombrePermiso = "Reportes", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Asistencia lecciones", Funcionalidades = "Descargar PDF" },
              new Permiso { Id = 116, NombrePermiso = "Reportes", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Asistencias eventos", Funcionalidades = "Descargar Excel" },
              new Permiso { Id = 117, NombrePermiso = "Reportes", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Asistencias eventos", Funcionalidades = "Descargar PDF" },
              new Permiso { Id = 118, NombrePermiso = "Reportes", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Estadisticas", Funcionalidades = "Descargar Excel" },
              new Permiso { Id = 119, NombrePermiso = "Reportes", FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, Modulo = "Estadisticas", Funcionalidades = "Descargar PDF" }
            );

            modelBuilder.Entity<PerfilPermiso>().HasData(
                new PerfilPermiso { Id = 1, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 1 },
                new PerfilPermiso { Id = 2, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 2 },
                new PerfilPermiso { Id = 3, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 3 },
                new PerfilPermiso { Id = 4, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 4 },
                new PerfilPermiso { Id = 5, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 5 },
                new PerfilPermiso { Id = 6, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 6 },
                new PerfilPermiso { Id = 7, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 7 },
                new PerfilPermiso { Id = 8, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 8 },
                new PerfilPermiso { Id = 9, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 9 },
                new PerfilPermiso { Id = 10, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 10 },
                new PerfilPermiso { Id = 11, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 11 },
                new PerfilPermiso { Id = 12, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 12 },
                new PerfilPermiso { Id = 13, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 13 },
                new PerfilPermiso { Id = 14, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 14 },
                new PerfilPermiso { Id = 15, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 15 },
                new PerfilPermiso { Id = 16, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 16 },
                new PerfilPermiso { Id = 17, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 17 },
                new PerfilPermiso { Id = 18, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 18 },
                new PerfilPermiso { Id = 19, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 19 },
                new PerfilPermiso { Id = 20, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 20 },
                new PerfilPermiso { Id = 21, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 21 },
                new PerfilPermiso { Id = 22, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 22 },
                new PerfilPermiso { Id = 23, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 23 },
                new PerfilPermiso { Id = 24, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 24 },
                new PerfilPermiso { Id = 25, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 25 },
                new PerfilPermiso { Id = 26, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 26 },
                new PerfilPermiso { Id = 27, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 27 },
                new PerfilPermiso { Id = 28, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 3, PermisoId = 28 },
                new PerfilPermiso { Id = 29, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 28 },
                new PerfilPermiso { Id = 30, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 29 },
                new PerfilPermiso { Id = 31, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 3, PermisoId = 29 },
                new PerfilPermiso { Id = 32, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 29 },
                new PerfilPermiso { Id = 33, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 30 },
                new PerfilPermiso { Id = 34, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 31 },
                new PerfilPermiso { Id = 35, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 32 },
                new PerfilPermiso { Id = 36, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 33 },
                new PerfilPermiso { Id = 37, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 3, PermisoId = 33 },
                new PerfilPermiso { Id = 38, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 33 },
                new PerfilPermiso { Id = 39, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 34 },
                new PerfilPermiso { Id = 40, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 35 },
                new PerfilPermiso { Id = 41, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 36 },
                new PerfilPermiso { Id = 42, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 37 },
                new PerfilPermiso { Id = 43, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 3, PermisoId = 37 },
                new PerfilPermiso { Id = 44, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 37 },
                new PerfilPermiso { Id = 45, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 38 },
                new PerfilPermiso { Id = 46, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 39 },
                new PerfilPermiso { Id = 47, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 3, PermisoId = 40 },
                new PerfilPermiso { Id = 48, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 40 },
                new PerfilPermiso { Id = 49, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 3, PermisoId = 41 },
                new PerfilPermiso { Id = 50, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 41 },
                new PerfilPermiso { Id = 51, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 6, PermisoId = 42 },
                new PerfilPermiso { Id = 52, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 6, PermisoId = 43 },
                new PerfilPermiso { Id = 53, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 6, PermisoId = 44 },
                new PerfilPermiso { Id = 54, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 6, PermisoId = 45 },
                new PerfilPermiso { Id = 55, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 6, PermisoId = 46 },
                new PerfilPermiso { Id = 56, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 7, PermisoId = 47 },
                new PerfilPermiso { Id = 57, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 7, PermisoId = 48 },
                new PerfilPermiso { Id = 58, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 7, PermisoId = 49 },
                new PerfilPermiso { Id = 59, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 7, PermisoId = 50 },
                new PerfilPermiso { Id = 60, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 6, PermisoId = 51 },
                new PerfilPermiso { Id = 61, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 6, PermisoId = 52 },
                new PerfilPermiso { Id = 62, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 3, PermisoId = 53 },
                new PerfilPermiso { Id = 63, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 3, PermisoId = 54 },
                new PerfilPermiso { Id = 64, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 54 },
                new PerfilPermiso { Id = 65, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 3, PermisoId = 55 },
                new PerfilPermiso { Id = 66, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 55 },
                new PerfilPermiso { Id = 67, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 56 },
                new PerfilPermiso { Id = 68, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 3, PermisoId = 57 },
                new PerfilPermiso { Id = 69, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 57 },
                new PerfilPermiso { Id = 70, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 3, PermisoId = 58 },
                new PerfilPermiso { Id = 71, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 59 },
                new PerfilPermiso { Id = 72, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 59 },
                new PerfilPermiso { Id = 73, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 60 },
                new PerfilPermiso { Id = 74, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 60 },
                new PerfilPermiso { Id = 75, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 61 },
                new PerfilPermiso { Id = 76, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 61 },
                new PerfilPermiso { Id = 77, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 62 },
                new PerfilPermiso { Id = 78, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 63 },
                new PerfilPermiso { Id = 79, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 5, PermisoId = 64 },
                new PerfilPermiso { Id = 80, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 5, PermisoId = 65 },
                new PerfilPermiso { Id = 81, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 5, PermisoId = 66 },
                new PerfilPermiso { Id = 82, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 5, PermisoId = 67 },
                new PerfilPermiso { Id = 83, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 5, PermisoId = 68 },
                new PerfilPermiso { Id = 84, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 5, PermisoId = 69 },
                new PerfilPermiso { Id = 85, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 70 },
                new PerfilPermiso { Id = 86, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 71 },
                new PerfilPermiso { Id = 87, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 72 },
                new PerfilPermiso { Id = 88, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 73 },
                new PerfilPermiso { Id = 89, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 74 },
                new PerfilPermiso { Id = 90, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 75 },
                new PerfilPermiso { Id = 91, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 76 },
                new PerfilPermiso { Id = 92, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 5, PermisoId = 76 },
                new PerfilPermiso { Id = 93, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 77 },
                new PerfilPermiso { Id = 94, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 78 },
                new PerfilPermiso { Id = 95, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 79 },
                new PerfilPermiso { Id = 96, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 80 },
                new PerfilPermiso { Id = 97, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 81 },
                new PerfilPermiso { Id = 98, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 82 },
                new PerfilPermiso { Id = 99, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 82 },
                new PerfilPermiso { Id = 100, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 83 },
                new PerfilPermiso { Id = 101, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 83 },
                new PerfilPermiso { Id = 102, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 84 },
                new PerfilPermiso { Id = 103, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 4, PermisoId = 84 },
                new PerfilPermiso { Id = 104, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 85 },
                new PerfilPermiso { Id = 105, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 86 },
                new PerfilPermiso { Id = 106, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 87 },
                new PerfilPermiso { Id = 107, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 88 },
                new PerfilPermiso { Id = 108, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 89 },
                new PerfilPermiso { Id = 109, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 90 },
                new PerfilPermiso { Id = 110, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 91 },
                new PerfilPermiso { Id = 111, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 92 },
                new PerfilPermiso { Id = 112, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 93 },
                new PerfilPermiso { Id = 113, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 94 },
                new PerfilPermiso { Id = 114, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 95 },
                new PerfilPermiso { Id = 115, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 96 },
                new PerfilPermiso { Id = 116, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 97 },
                new PerfilPermiso { Id = 117, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 98 },
                new PerfilPermiso { Id = 118, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 99 },
                new PerfilPermiso { Id = 119, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 100 },
                new PerfilPermiso { Id = 120, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 101 },
                new PerfilPermiso { Id = 121, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 102 },
                new PerfilPermiso { Id = 122, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 103 },
                new PerfilPermiso { Id = 123, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 104 },
                new PerfilPermiso { Id = 124, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 105 },
                new PerfilPermiso { Id = 125, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 106 },
                new PerfilPermiso { Id = 126, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 107 },
                new PerfilPermiso { Id = 127, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 108 },
                new PerfilPermiso { Id = 128, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 109 },
                new PerfilPermiso { Id = 129, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 110 },
                new PerfilPermiso { Id = 130, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 1, PermisoId = 111 },
                new PerfilPermiso { Id = 131, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 112 },
                new PerfilPermiso { Id = 132, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 113 },
                new PerfilPermiso { Id = 133, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 114 },
                new PerfilPermiso { Id = 134, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 115 },
                new PerfilPermiso { Id = 135, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 116 },
                new PerfilPermiso { Id = 136, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 117 },
                new PerfilPermiso { Id = 137, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 118 },
                new PerfilPermiso { Id = 138, FechaCreacion = DateTime.Now, FechaModificacion = null, FechaBaja = null, UsuarioEditor = 1, PerfilId = 2, PermisoId = 119 }
            );
        }
    }
}

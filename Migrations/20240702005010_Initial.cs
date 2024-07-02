using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EdadMinima = table.Column<int>(type: "int", nullable: false),
                    EdadMaxima = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipoEstado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoEstado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoEvento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoEvento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoSolicitudAsociacion",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DescripcionEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoSolicitudAsociacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instalacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    Condiciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraInicio = table.Column<TimeOnly>(type: "time", nullable: false),
                    HoraCierre = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instalacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstalacionEstado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstalacionEstado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeccionEstado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeccionEstado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Noticias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adjunto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaExpiracion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerfilClub",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePerfilClub = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilClub", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TerminosYCondiciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminosYCondiciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoAccionEstado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAccionEstado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoEvento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoEvento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEvento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TorneoEstado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TorneoEstado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioEstado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioEstado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstalacionHistorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleCambioEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: true),
                    InstalacionEstadoId = table.Column<int>(type: "int", nullable: false),
                    InstalacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstalacionHistorial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstalacionHistorial_InstalacionEstado_InstalacionEstadoId",
                        column: x => x.InstalacionEstadoId,
                        principalTable: "InstalacionEstado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstalacionHistorial_Instalacion_InstalacionId",
                        column: x => x.InstalacionId,
                        principalTable: "Instalacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ParametrosClub",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorSecundario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoPequenio = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LogoGrande = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IconoPlataforma = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TextoBannerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextoFooterEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorBannerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextoEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuienesSomos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerfilClubId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametrosClub", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParametrosClub_PerfilClub_PerfilClubId",
                        column: x => x.PerfilClubId,
                        principalTable: "PerfilClub",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HistorialTerminosYCondiciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaInicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFinVigencia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false),
                    TerminosYCondicionesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialTerminosYCondiciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialTerminosYCondiciones_TerminosYCondiciones_TerminosYCondicionesId",
                        column: x => x.TerminosYCondicionesId,
                        principalTable: "TerminosYCondiciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClubHistorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false),
                    ParametrosClubId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubHistorial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClubHistorial_ParametrosClub_ParametrosClubId",
                        column: x => x.ParametrosClubId,
                        principalTable: "ParametrosClub",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AccionPartido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NroJugador = table.Column<int>(type: "int", nullable: false),
                    Minuto = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false),
                    TipoAccionPartidoId = table.Column<int>(type: "int", nullable: false),
                    PartidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccionPartido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asistencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsistenciaLeccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsistioAlumno = table.Column<bool>(type: "bit", nullable: false),
                    ClaseCompleta = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeccionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsistenciaLeccion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CodigoVerificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaExpiracion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodigoVerificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disciplina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantJugadores = table.Column<int>(type: "int", nullable: false),
                    PeriodosMax = table.Column<int>(type: "int", nullable: false),
                    TarjetasAdvertencia = table.Column<int>(type: "int", nullable: false),
                    TarjetasExpulsion = table.Column<int>(type: "int", nullable: false),
                    CantJugadoresEnBanca = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false),
                    EventoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplina", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Local = table.Column<bool>(type: "bit", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DisciplinaId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipo_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipo_Disciplina_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoAccionPartido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoAccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificaTarjetasAdvertencia = table.Column<bool>(type: "bit", nullable: false),
                    ModificaTarjetasExpulsion = table.Column<bool>(type: "bit", nullable: false),
                    secuencial = table.Column<bool>(type: "bit", nullable: false),
                    DisciplinaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAccionPartido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoAccionPartido_Disciplina_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Torneo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantEquipos = table.Column<int>(type: "int", nullable: false),
                    Banner = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Condiciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisciplinaId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Torneo_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Torneo_Disciplina_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipoHistorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleCambioEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: true),
                    EquipoEstadoId = table.Column<int>(type: "int", nullable: false),
                    EquipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoHistorial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipoHistorial_EquipoEstado_EquipoEstadoId",
                        column: x => x.EquipoEstadoId,
                        principalTable: "EquipoEstado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipoHistorial_Equipo_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EquipoPartido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JugadoresEnCancha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JugadoresEnBanca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoPartido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipoPartido_Equipo_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estadistica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    MarcaEstadistica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PuntajeTipoAccion = table.Column<int>(type: "int", nullable: false),
                    RazonBaja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadistica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estadistica_AsistenciaLeccion_Id",
                        column: x => x.Id,
                        principalTable: "AsistenciaLeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estadistica_Equipo_Id",
                        column: x => x.Id,
                        principalTable: "Equipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estadistica_TipoAccionPartido_Id",
                        column: x => x.Id,
                        principalTable: "TipoAccionPartido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoAccionHistorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleCambioEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: true),
                    TipoAccionEstadoId = table.Column<int>(type: "int", nullable: false),
                    TipoAccionPartidoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAccionHistorial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoAccionHistorial_TipoAccionEstado_TipoAccionEstadoId",
                        column: x => x.TipoAccionEstadoId,
                        principalTable: "TipoAccionEstado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TipoAccionHistorial_TipoAccionPartido_TipoAccionPartidoId",
                        column: x => x.TipoAccionPartidoId,
                        principalTable: "TipoAccionPartido",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PartidoFase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FasePartido = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false),
                    TorneoId = table.Column<int>(type: "int", nullable: false),
                    PartidoFaseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartidoFase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartidoFase_PartidoFase_PartidoFaseId",
                        column: x => x.PartidoFaseId,
                        principalTable: "PartidoFase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartidoFase_Torneo_TorneoId",
                        column: x => x.TorneoId,
                        principalTable: "Torneo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TorneoHistorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleCambioEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: true),
                    TorneoEstadoId = table.Column<int>(type: "int", nullable: false),
                    TorneoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TorneoHistorial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TorneoHistorial_TorneoEstado_TorneoEstadoId",
                        column: x => x.TorneoEstadoId,
                        principalTable: "TorneoEstado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TorneoHistorial_Torneo_TorneoId",
                        column: x => x.TorneoId,
                        principalTable: "Torneo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Banner = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CupoMaximo = table.Column<int>(type: "int", nullable: false),
                    EventoLleno = table.Column<bool>(type: "bit", nullable: false),
                    LinkStream = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoEventoId = table.Column<int>(type: "int", nullable: false),
                    InstalacionId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Resultado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Periodo = table.Column<int>(type: "int", nullable: true),
                    Set = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GanadorId = table.Column<int>(type: "int", nullable: true),
                    LocalId = table.Column<int>(type: "int", nullable: true),
                    VisitanteId = table.Column<int>(type: "int", nullable: true),
                    PartidoFaseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evento_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evento_EquipoPartido_GanadorId",
                        column: x => x.GanadorId,
                        principalTable: "EquipoPartido",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Evento_EquipoPartido_LocalId",
                        column: x => x.LocalId,
                        principalTable: "EquipoPartido",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Evento_EquipoPartido_VisitanteId",
                        column: x => x.VisitanteId,
                        principalTable: "EquipoPartido",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Evento_Instalacion_InstalacionId",
                        column: x => x.InstalacionId,
                        principalTable: "Instalacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evento_PartidoFase_PartidoFaseId",
                        column: x => x.PartidoFaseId,
                        principalTable: "PartidoFase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Evento_TipoEvento_TipoEventoId",
                        column: x => x.TipoEventoId,
                        principalTable: "TipoEvento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistorialEvento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleCambioEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: true),
                    EstadoEventoId = table.Column<int>(type: "int", nullable: false),
                    EventoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialEvento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialEvento_EstadoEvento_EstadoEventoId",
                        column: x => x.EstadoEventoId,
                        principalTable: "EstadoEvento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistorialEvento_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EquipoUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumCamiseta = table.Column<int>(type: "int", nullable: false),
                    Puesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    EquipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipoUsuario_Equipo_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GrupoFamiliar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreGrupoFamiliar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    duenioGrupoFamiliar = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentosGrupoFamiliar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuenioGrupoFamiliarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoFamiliar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodPostal = table.Column<int>(type: "int", nullable: true),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeporteFavorito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Dni = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaAceptacionTYC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCambioContrasena = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FotoPerfil = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UltimoAcceso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GrupoFamiliarId = table.Column<int>(type: "int", nullable: true),
                    PartidoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Evento_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Evento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Usuario_GrupoFamiliar_GrupoFamiliarId",
                        column: x => x.GrupoFamiliarId,
                        principalTable: "GrupoFamiliar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inscripcion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInscripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inscripcion_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscripcion_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horarios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantMaxima = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lugar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisciplinaId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leccion_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leccion_Disciplina_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leccion_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerfilUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerfilUsuario_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false),
                    InstalacionId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reserva_Instalacion_InstalacionId",
                        column: x => x.InstalacionId,
                        principalTable: "Instalacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserva_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudAsociacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotivoRechazo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudAsociacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudAsociacion_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioHistorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleCambioEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: true),
                    UsuarioEstadoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioHistorial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioHistorial_UsuarioEstado_UsuarioEstadoId",
                        column: x => x.UsuarioEstadoId,
                        principalTable: "UsuarioEstado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioHistorial_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UsuarioNotificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    NotificacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioNotificacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioNotificacion_Notificacion_NotificacionId",
                        column: x => x.NotificacionId,
                        principalTable: "Notificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioNotificacion_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InscripcionUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeccionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscripcionUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InscripcionUsuario_Leccion_LeccionId",
                        column: x => x.LeccionId,
                        principalTable: "Leccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InscripcionUsuario_Usuario_Id",
                        column: x => x.Id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeccionHistorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleCambioEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: true),
                    LeccionEstadoId = table.Column<int>(type: "int", nullable: false),
                    LeccionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeccionHistorial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeccionHistorial_LeccionEstado_LeccionEstadoId",
                        column: x => x.LeccionEstadoId,
                        principalTable: "LeccionEstado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeccionHistorial_Leccion_LeccionId",
                        column: x => x.LeccionId,
                        principalTable: "Leccion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePerfil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionPerfil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false),
                    PerfilUsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perfil_PerfilUsuario_PerfilUsuarioId",
                        column: x => x.PerfilUsuarioId,
                        principalTable: "PerfilUsuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SolicitudAsociacionHistorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleCambioEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: true),
                    EstadoSolicitudAsociacionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SolicitudAsociacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudAsociacionHistorial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudAsociacionHistorial_EstadoSolicitudAsociacion_EstadoSolicitudAsociacionId",
                        column: x => x.EstadoSolicitudAsociacionId,
                        principalTable: "EstadoSolicitudAsociacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitudAsociacionHistorial_SolicitudAsociacion_SolicitudAsociacionId",
                        column: x => x.SolicitudAsociacionId,
                        principalTable: "SolicitudAsociacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePermiso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Funcionalidades = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerfilId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permiso_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccionPartido_PartidoId",
                table: "AccionPartido",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_AccionPartido_TipoAccionPartidoId",
                table: "AccionPartido",
                column: "TipoAccionPartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_EventoId",
                table: "Asistencia",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_UsuarioId",
                table: "Asistencia",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AsistenciaLeccion_LeccionId",
                table: "AsistenciaLeccion",
                column: "LeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubHistorial_ParametrosClubId",
                table: "ClubHistorial",
                column: "ParametrosClubId");

            migrationBuilder.CreateIndex(
                name: "IX_CodigoVerificacion_UsuarioId",
                table: "CodigoVerificacion",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplina_EventoId",
                table: "Disciplina",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_CategoriaId",
                table: "Equipo",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_DisciplinaId",
                table: "Equipo",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoHistorial_EquipoEstadoId",
                table: "EquipoHistorial",
                column: "EquipoEstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoHistorial_EquipoId",
                table: "EquipoHistorial",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoPartido_EquipoId",
                table: "EquipoPartido",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoUsuario_EquipoId",
                table: "EquipoUsuario",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoUsuario_UsuarioId",
                table: "EquipoUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_CategoriaId",
                table: "Evento",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_GanadorId",
                table: "Evento",
                column: "GanadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_InstalacionId",
                table: "Evento",
                column: "InstalacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_LocalId",
                table: "Evento",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_PartidoFaseId",
                table: "Evento",
                column: "PartidoFaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_TipoEventoId",
                table: "Evento",
                column: "TipoEventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_VisitanteId",
                table: "Evento",
                column: "VisitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_GrupoFamiliar_DuenioGrupoFamiliarId",
                table: "GrupoFamiliar",
                column: "DuenioGrupoFamiliarId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialEvento_EstadoEventoId",
                table: "HistorialEvento",
                column: "EstadoEventoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialEvento_EventoId",
                table: "HistorialEvento",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialTerminosYCondiciones_TerminosYCondicionesId",
                table: "HistorialTerminosYCondiciones",
                column: "TerminosYCondicionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_EventoId",
                table: "Inscripcion",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_UsuarioId",
                table: "Inscripcion",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InscripcionUsuario_LeccionId",
                table: "InscripcionUsuario",
                column: "LeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstalacionHistorial_InstalacionEstadoId",
                table: "InstalacionHistorial",
                column: "InstalacionEstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_InstalacionHistorial_InstalacionId",
                table: "InstalacionHistorial",
                column: "InstalacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Leccion_CategoriaId",
                table: "Leccion",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Leccion_DisciplinaId",
                table: "Leccion",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Leccion_UsuarioId",
                table: "Leccion",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_LeccionHistorial_LeccionEstadoId",
                table: "LeccionHistorial",
                column: "LeccionEstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_LeccionHistorial_LeccionId",
                table: "LeccionHistorial",
                column: "LeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametrosClub_PerfilClubId",
                table: "ParametrosClub",
                column: "PerfilClubId");

            migrationBuilder.CreateIndex(
                name: "IX_PartidoFase_PartidoFaseId",
                table: "PartidoFase",
                column: "PartidoFaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PartidoFase_TorneoId",
                table: "PartidoFase",
                column: "TorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_PerfilUsuarioId",
                table: "Perfil",
                column: "PerfilUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilUsuario_UsuarioId",
                table: "PerfilUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_PerfilId",
                table: "Permiso",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_InstalacionId",
                table: "Reserva",
                column: "InstalacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_UsuarioId",
                table: "Reserva",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudAsociacion_UsuarioId",
                table: "SolicitudAsociacion",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudAsociacionHistorial_EstadoSolicitudAsociacionId",
                table: "SolicitudAsociacionHistorial",
                column: "EstadoSolicitudAsociacionId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudAsociacionHistorial_SolicitudAsociacionId",
                table: "SolicitudAsociacionHistorial",
                column: "SolicitudAsociacionId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoAccionHistorial_TipoAccionEstadoId",
                table: "TipoAccionHistorial",
                column: "TipoAccionEstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoAccionHistorial_TipoAccionPartidoId",
                table: "TipoAccionHistorial",
                column: "TipoAccionPartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoAccionPartido_DisciplinaId",
                table: "TipoAccionPartido",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Torneo_CategoriaId",
                table: "Torneo",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Torneo_DisciplinaId",
                table: "Torneo",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_TorneoHistorial_TorneoEstadoId",
                table: "TorneoHistorial",
                column: "TorneoEstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_TorneoHistorial_TorneoId",
                table: "TorneoHistorial",
                column: "TorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_GrupoFamiliarId",
                table: "Usuario",
                column: "GrupoFamiliarId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PartidoId",
                table: "Usuario",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioHistorial_UsuarioEstadoId",
                table: "UsuarioHistorial",
                column: "UsuarioEstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioHistorial_UsuarioId",
                table: "UsuarioHistorial",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioNotificacion_NotificacionId",
                table: "UsuarioNotificacion",
                column: "NotificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioNotificacion_UsuarioId",
                table: "UsuarioNotificacion",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccionPartido_Evento_PartidoId",
                table: "AccionPartido",
                column: "PartidoId",
                principalTable: "Evento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccionPartido_TipoAccionPartido_TipoAccionPartidoId",
                table: "AccionPartido",
                column: "TipoAccionPartidoId",
                principalTable: "TipoAccionPartido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencia_Evento_EventoId",
                table: "Asistencia",
                column: "EventoId",
                principalTable: "Evento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencia_Usuario_UsuarioId",
                table: "Asistencia",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AsistenciaLeccion_Leccion_LeccionId",
                table: "AsistenciaLeccion",
                column: "LeccionId",
                principalTable: "Leccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CodigoVerificacion_Usuario_UsuarioId",
                table: "CodigoVerificacion",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplina_Evento_EventoId",
                table: "Disciplina",
                column: "EventoId",
                principalTable: "Evento",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoUsuario_Usuario_UsuarioId",
                table: "EquipoUsuario",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GrupoFamiliar_Usuario_DuenioGrupoFamiliarId",
                table: "GrupoFamiliar",
                column: "DuenioGrupoFamiliarId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplina_Evento_EventoId",
                table: "Disciplina");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Evento_PartidoId",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_GrupoFamiliar_Usuario_DuenioGrupoFamiliarId",
                table: "GrupoFamiliar");

            migrationBuilder.DropTable(
                name: "AccionPartido");

            migrationBuilder.DropTable(
                name: "Asistencia");

            migrationBuilder.DropTable(
                name: "ClubHistorial");

            migrationBuilder.DropTable(
                name: "CodigoVerificacion");

            migrationBuilder.DropTable(
                name: "EquipoHistorial");

            migrationBuilder.DropTable(
                name: "EquipoUsuario");

            migrationBuilder.DropTable(
                name: "Estadistica");

            migrationBuilder.DropTable(
                name: "HistorialEvento");

            migrationBuilder.DropTable(
                name: "HistorialTerminosYCondiciones");

            migrationBuilder.DropTable(
                name: "Inscripcion");

            migrationBuilder.DropTable(
                name: "InscripcionUsuario");

            migrationBuilder.DropTable(
                name: "InstalacionHistorial");

            migrationBuilder.DropTable(
                name: "LeccionHistorial");

            migrationBuilder.DropTable(
                name: "Noticias");

            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "SolicitudAsociacionHistorial");

            migrationBuilder.DropTable(
                name: "TipoAccionHistorial");

            migrationBuilder.DropTable(
                name: "TorneoHistorial");

            migrationBuilder.DropTable(
                name: "UsuarioHistorial");

            migrationBuilder.DropTable(
                name: "UsuarioNotificacion");

            migrationBuilder.DropTable(
                name: "ParametrosClub");

            migrationBuilder.DropTable(
                name: "EquipoEstado");

            migrationBuilder.DropTable(
                name: "AsistenciaLeccion");

            migrationBuilder.DropTable(
                name: "EstadoEvento");

            migrationBuilder.DropTable(
                name: "TerminosYCondiciones");

            migrationBuilder.DropTable(
                name: "InstalacionEstado");

            migrationBuilder.DropTable(
                name: "LeccionEstado");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "EstadoSolicitudAsociacion");

            migrationBuilder.DropTable(
                name: "SolicitudAsociacion");

            migrationBuilder.DropTable(
                name: "TipoAccionEstado");

            migrationBuilder.DropTable(
                name: "TipoAccionPartido");

            migrationBuilder.DropTable(
                name: "TorneoEstado");

            migrationBuilder.DropTable(
                name: "UsuarioEstado");

            migrationBuilder.DropTable(
                name: "Notificacion");

            migrationBuilder.DropTable(
                name: "PerfilClub");

            migrationBuilder.DropTable(
                name: "Leccion");

            migrationBuilder.DropTable(
                name: "PerfilUsuario");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "EquipoPartido");

            migrationBuilder.DropTable(
                name: "Instalacion");

            migrationBuilder.DropTable(
                name: "PartidoFase");

            migrationBuilder.DropTable(
                name: "TipoEvento");

            migrationBuilder.DropTable(
                name: "Equipo");

            migrationBuilder.DropTable(
                name: "Torneo");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Disciplina");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "GrupoFamiliar");
        }
    }
}

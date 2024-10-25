using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class Estadisticas4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estadisticas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarcaEstadistica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PuntajeTipoAccion = table.Column<int>(type: "int", nullable: false),
                    RazonBaja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false),
                    TipoAccionPartidoId = table.Column<int>(type: "int", nullable: true),
                    PartidoId = table.Column<int>(type: "int", nullable: true),
                    AsistenciaLeccionId = table.Column<int>(type: "int", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadisticas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estadisticas_Equipo_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Estadisticas_Evento_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Evento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Estadisticas_TipoAccionPartido_TipoAccionPartidoId",
                        column: x => x.TipoAccionPartidoId,
                        principalTable: "TipoAccionPartido",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 53, 14, 630, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.CreateIndex(
                name: "IX_Estadisticas_EquipoId",
                table: "Estadisticas",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadisticas_PartidoId",
                table: "Estadisticas",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadisticas_TipoAccionPartidoId",
                table: "Estadisticas",
                column: "TipoAccionPartidoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estadisticas");

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 23, 22, 27, 26, 805, DateTimeKind.Local).AddTicks(3810));
        }
    }
}

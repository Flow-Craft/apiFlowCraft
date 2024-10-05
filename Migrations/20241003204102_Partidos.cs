using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class Partidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resultado",
                table: "Evento");

            migrationBuilder.AddColumn<int>(
                name: "ResultadoLocal",
                table: "Evento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResultadoVisitante",
                table: "Evento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EquipoLocal",
                table: "AccionPartido",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Periodo",
                table: "AccionPartido",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 17, 41, 0, 133, DateTimeKind.Local).AddTicks(7473));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResultadoLocal",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ResultadoVisitante",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "EquipoLocal",
                table: "AccionPartido");

            migrationBuilder.DropColumn(
                name: "Periodo",
                table: "AccionPartido");

            migrationBuilder.AddColumn<string>(
                name: "Resultado",
                table: "Evento",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 1, 19, 19, 29, 271, DateTimeKind.Local).AddTicks(1599));
        }
    }
}

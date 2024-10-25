using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class EstadisticasNroJugador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NroJugador",
                table: "Estadisticas",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 24, 13, 8, 4, 709, DateTimeKind.Local).AddTicks(1103));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NroJugador",
                table: "Estadisticas");

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
        }
    }
}

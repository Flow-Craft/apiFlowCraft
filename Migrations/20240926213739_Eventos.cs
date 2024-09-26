using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class Eventos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstalacionHistorial_Instalacion_InstalacionId",
                table: "InstalacionHistorial");

            migrationBuilder.AlterColumn<int>(
                name: "InstalacionId",
                table: "InstalacionHistorial",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaFinEvento",
                table: "Evento",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 71,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 75,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 76,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 77,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 78,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 79,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 103,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 26, 18, 37, 38, 581, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.AddForeignKey(
                name: "FK_InstalacionHistorial_Instalacion_InstalacionId",
                table: "InstalacionHistorial",
                column: "InstalacionId",
                principalTable: "Instalacion",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstalacionHistorial_Instalacion_InstalacionId",
                table: "InstalacionHistorial");

            migrationBuilder.DropColumn(
                name: "FechaFinEvento",
                table: "Evento");

            migrationBuilder.AlterColumn<int>(
                name: "InstalacionId",
                table: "InstalacionHistorial",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 71,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 75,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 76,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 77,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 78,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 79,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 103,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 577, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 24, 17, 5, 32, 576, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.AddForeignKey(
                name: "FK_InstalacionHistorial_Instalacion_InstalacionId",
                table: "InstalacionHistorial",
                column: "InstalacionId",
                principalTable: "Instalacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

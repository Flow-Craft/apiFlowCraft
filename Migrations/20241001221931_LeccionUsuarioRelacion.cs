using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class LeccionUsuarioRelacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leccion_Usuario_UsuarioId",
                table: "Leccion");

            migrationBuilder.DropIndex(
                name: "IX_Leccion_UsuarioId",
                table: "Leccion");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Leccion");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Leccion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 29, 11, 48, 17, 626, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.CreateIndex(
                name: "IX_Leccion_UsuarioId",
                table: "Leccion",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leccion_Usuario_UsuarioId",
                table: "Leccion",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

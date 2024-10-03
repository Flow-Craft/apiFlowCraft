using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class InscripcionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaBaja",
                table: "Inscripcion",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaBaja",
                table: "Inscripcion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 28, 12, 45, 38, 55, DateTimeKind.Local).AddTicks(2281));
        }
    }
}

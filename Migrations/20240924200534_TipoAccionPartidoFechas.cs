using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class TipoAccionPartidoFechas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBaja",
                table: "TipoAccionPartido",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "TipoAccionPartido",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "TipoAccionPartido",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioEditor",
                table: "TipoAccionPartido",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaBaja",
                table: "TipoAccionPartido");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "TipoAccionPartido");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "TipoAccionPartido");

            migrationBuilder.DropColumn(
                name: "UsuarioEditor",
                table: "TipoAccionPartido");

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 71,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 75,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 76,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 77,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 78,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 79,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 103,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 18, 19, 34, 59, 229, DateTimeKind.Local).AddTicks(2003));
        }
    }
}

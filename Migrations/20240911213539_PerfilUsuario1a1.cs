using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class PerfilUsuario1a1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfil_PerfilUsuario_PerfilUsuarioId",
                table: "Perfil");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_PerfilUsuario_PerfilUsuarioId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PerfilUsuarioId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Perfil_PerfilUsuarioId",
                table: "Perfil");

            migrationBuilder.DropColumn(
                name: "PerfilUsuarioId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "PerfilUsuarioId",
                table: "Perfil");

            migrationBuilder.AddColumn<int>(
                name: "PerfilId",
                table: "PerfilUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "PerfilUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 71,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 75,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 76,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 77,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 78,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 79,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 103,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 123,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 124,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 125,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 126,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 127,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 128,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 129,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 130,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 131,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 132,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 133,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 134,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 135,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 136,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 137,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 138,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 71,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 75,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 76,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 77,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 78,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 79,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 103,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 35, 38, 733, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.CreateIndex(
                name: "IX_PerfilUsuario_PerfilId",
                table: "PerfilUsuario",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilUsuario_UsuarioId",
                table: "PerfilUsuario",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_Perfil_PerfilId",
                table: "PerfilUsuario",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_Usuario_UsuarioId",
                table: "PerfilUsuario",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_Perfil_PerfilId",
                table: "PerfilUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_Usuario_UsuarioId",
                table: "PerfilUsuario");

            migrationBuilder.DropIndex(
                name: "IX_PerfilUsuario_PerfilId",
                table: "PerfilUsuario");

            migrationBuilder.DropIndex(
                name: "IX_PerfilUsuario_UsuarioId",
                table: "PerfilUsuario");

            migrationBuilder.DropColumn(
                name: "PerfilId",
                table: "PerfilUsuario");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "PerfilUsuario");

            migrationBuilder.AddColumn<int>(
                name: "PerfilUsuarioId",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerfilUsuarioId",
                table: "Perfil",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "PerfilUsuarioId" },
                values: new object[] { new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4431), null });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "PerfilUsuarioId" },
                values: new object[] { new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4433), null });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaCreacion", "PerfilUsuarioId" },
                values: new object[] { new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4435), null });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "PerfilUsuarioId" },
                values: new object[] { new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4438), null });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "PerfilUsuarioId" },
                values: new object[] { new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4440), null });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FechaCreacion", "PerfilUsuarioId" },
                values: new object[] { new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4441), null });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FechaCreacion", "PerfilUsuarioId" },
                values: new object[] { new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4443), null });

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 71,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 75,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 76,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 77,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 78,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 79,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 103,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 123,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 124,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 125,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 126,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 127,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 128,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 129,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 130,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 131,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 132,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 133,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 134,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 135,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 136,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 137,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 138,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 71,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 75,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 76,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 77,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 78,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 79,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 103,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfilUsuarioId",
                table: "Usuario",
                column: "PerfilUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_PerfilUsuarioId",
                table: "Perfil",
                column: "PerfilUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfil_PerfilUsuario_PerfilUsuarioId",
                table: "Perfil",
                column: "PerfilUsuarioId",
                principalTable: "PerfilUsuario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_PerfilUsuario_PerfilUsuarioId",
                table: "Usuario",
                column: "PerfilUsuarioId",
                principalTable: "PerfilUsuario",
                principalColumn: "Id");
        }
    }
}

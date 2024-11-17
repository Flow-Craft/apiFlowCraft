using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class MarioMatiReContraHinchaCOCO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EsPartido",
                table: "TipoAccionPartido",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 41, 5, 704, DateTimeKind.Local).AddTicks(4117));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "EsPartido",
                table: "TipoAccionPartido",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 12, 36, 37, 81, DateTimeKind.Local).AddTicks(368));
        }
    }
}

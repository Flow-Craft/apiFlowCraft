using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class ProfesorLeccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idProfesor",
                table: "Leccion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 28, 16, 49, 31, 385, DateTimeKind.Local).AddTicks(3766));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idProfesor",
                table: "Leccion");

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
    }
}

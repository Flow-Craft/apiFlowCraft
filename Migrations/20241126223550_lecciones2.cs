using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class lecciones2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InscripcionUsuario_Usuario_Id",
                table: "InscripcionUsuario");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    table: "InscripcionUsuario",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.DropColumn(
    name: "Id",
    table: "InscripcionUsuario");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "InscripcionUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");


            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 35, 50, 176, DateTimeKind.Local).AddTicks(3405));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "InscripcionUsuario",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 26, 19, 24, 30, 566, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.AddForeignKey(
                name: "FK_InscripcionUsuario_Usuario_Id",
                table: "InscripcionUsuario",
                column: "Id",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

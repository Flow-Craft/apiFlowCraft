using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class Backup2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Version",
                table: "Backup",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Backup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 59, 57, 749, DateTimeKind.Local).AddTicks(7078));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Backup");

            migrationBuilder.AlterColumn<string>(
                name: "Version",
                table: "Backup",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 19, 51, 10, 433, DateTimeKind.Local).AddTicks(4587));
        }
    }
}

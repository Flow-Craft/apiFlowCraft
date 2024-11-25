using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class Backup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Backup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pdf = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backup", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Backup");

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
    }
}

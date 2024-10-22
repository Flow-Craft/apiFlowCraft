using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class estadisticaId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoAccionPartidoId",
                table: "Estadistica",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 22, 18, 51, 58, 803, DateTimeKind.Local).AddTicks(4862));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoAccionPartidoId",
                table: "Estadistica");

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(250));
        }
    }
}

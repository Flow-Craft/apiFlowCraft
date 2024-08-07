using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class QuienesSomos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuienesSomos",
                table: "ParametrosClub",
                newName: "TituloQuienesSomos");

            migrationBuilder.AddColumn<string>(
                name: "DescripcionQuienesSomos",
                table: "ParametrosClub",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 20, 50, 38, 346, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 20, 50, 38, 346, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 20, 50, 38, 346, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 20, 50, 38, 346, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 20, 50, 38, 346, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 20, 50, 38, 346, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 20, 50, 38, 346, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 20, 50, 38, 346, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 20, 50, 38, 346, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 20, 50, 38, 346, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 20, 50, 38, 346, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 20, 50, 38, 346, DateTimeKind.Local).AddTicks(5564));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescripcionQuienesSomos",
                table: "ParametrosClub");

            migrationBuilder.RenameColumn(
                name: "TituloQuienesSomos",
                table: "ParametrosClub",
                newName: "QuienesSomos");

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 30, 20, 16, 36, 915, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 30, 20, 16, 36, 915, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 30, 20, 16, 36, 915, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 30, 20, 16, 36, 915, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 30, 20, 16, 36, 915, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 30, 20, 16, 36, 915, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 30, 20, 16, 36, 915, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 30, 20, 16, 36, 915, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 30, 20, 16, 36, 915, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 30, 20, 16, 36, 915, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 30, 20, 16, 36, 915, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 30, 20, 16, 36, 915, DateTimeKind.Local).AddTicks(7550));
        }
    }
}

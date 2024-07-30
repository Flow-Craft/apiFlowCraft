using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class TipoDatoTelefono : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistorialTerminosYCondiciones_TerminosYCondiciones_TerminosYCondicionesId",
                table: "HistorialTerminosYCondiciones");

            migrationBuilder.DropIndex(
                name: "IX_HistorialTerminosYCondiciones_TerminosYCondicionesId",
                table: "HistorialTerminosYCondiciones");

            migrationBuilder.DropColumn(
                name: "TerminosYCondicionesId",
                table: "HistorialTerminosYCondiciones");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "HistorialTerminosYCondicionesId",
                table: "TerminosYCondiciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_TerminosYCondiciones_HistorialTerminosYCondicionesId",
                table: "TerminosYCondiciones",
                column: "HistorialTerminosYCondicionesId");

            migrationBuilder.AddForeignKey(
                name: "FK_TerminosYCondiciones_HistorialTerminosYCondiciones_HistorialTerminosYCondicionesId",
                table: "TerminosYCondiciones",
                column: "HistorialTerminosYCondicionesId",
                principalTable: "HistorialTerminosYCondiciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TerminosYCondiciones_HistorialTerminosYCondiciones_HistorialTerminosYCondicionesId",
                table: "TerminosYCondiciones");

            migrationBuilder.DropIndex(
                name: "IX_TerminosYCondiciones_HistorialTerminosYCondicionesId",
                table: "TerminosYCondiciones");

            migrationBuilder.DropColumn(
                name: "HistorialTerminosYCondicionesId",
                table: "TerminosYCondiciones");

            migrationBuilder.AlterColumn<int>(
                name: "Telefono",
                table: "Usuario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "TerminosYCondicionesId",
                table: "HistorialTerminosYCondiciones",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 20, 14, 3, 40, 696, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 20, 14, 3, 40, 696, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 20, 14, 3, 40, 696, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 20, 14, 3, 40, 696, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 20, 14, 3, 40, 696, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 20, 14, 3, 40, 696, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 20, 14, 3, 40, 696, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 20, 14, 3, 40, 696, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 20, 14, 3, 40, 696, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 20, 14, 3, 40, 696, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 20, 14, 3, 40, 696, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 20, 14, 3, 40, 696, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.CreateIndex(
                name: "IX_HistorialTerminosYCondiciones_TerminosYCondicionesId",
                table: "HistorialTerminosYCondiciones",
                column: "TerminosYCondicionesId");

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialTerminosYCondiciones_TerminosYCondiciones_TerminosYCondicionesId",
                table: "HistorialTerminosYCondiciones",
                column: "TerminosYCondicionesId",
                principalTable: "TerminosYCondiciones",
                principalColumn: "Id");
        }
    }
}

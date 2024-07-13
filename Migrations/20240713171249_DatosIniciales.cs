using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class DatosIniciales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EquipoEstado",
                columns: new[] { "Id", "DescripcionEstado", "FechaBaja", "FechaCreacion", "FechaModificacion", "NombreEstado", "UsuarioEditor" },
                values: new object[,]
                {
                    { 1, "Equipo activo", null, new DateTime(2024, 7, 13, 14, 12, 47, 667, DateTimeKind.Local).AddTicks(9382), null, "Activo", 1 },
                    { 2, "Equipo inactivo", null, new DateTime(2024, 7, 13, 14, 12, 47, 667, DateTimeKind.Local).AddTicks(9385), null, "Inactivo", 1 },
                    { 3, "Equipo suspendido", null, new DateTime(2024, 7, 13, 14, 12, 47, 667, DateTimeKind.Local).AddTicks(9387), null, "Suspendido", 1 }
                });

            migrationBuilder.InsertData(
                table: "EstadoEvento",
                columns: new[] { "Id", "DescripcionEstado", "FechaBaja", "FechaCreacion", "FechaModificacion", "NombreEstado", "UsuarioEditor" },
                values: new object[,]
                {
                    { 1, "Evento creado", null, new DateTime(2024, 7, 13, 14, 12, 47, 667, DateTimeKind.Local).AddTicks(9345), null, "Creado", 1 },
                    { 2, "Evento cancelado", null, new DateTime(2024, 7, 13, 14, 12, 47, 667, DateTimeKind.Local).AddTicks(9347), null, "Cancelado", 1 },
                    { 3, "Evento finalizado", null, new DateTime(2024, 7, 13, 14, 12, 47, 667, DateTimeKind.Local).AddTicks(9349), null, "Finalizado", 1 },
                    { 4, "Evento iniciado", null, new DateTime(2024, 7, 13, 14, 12, 47, 667, DateTimeKind.Local).AddTicks(9350), null, "Iniciado", 1 },
                    { 5, "Evento suspendido", null, new DateTime(2024, 7, 13, 14, 12, 47, 667, DateTimeKind.Local).AddTicks(9352), null, "Suspendido", 1 },
                    { 6, "Evento en entretiempo", null, new DateTime(2024, 7, 13, 14, 12, 47, 667, DateTimeKind.Local).AddTicks(9353), null, "Entretiempo", 1 }
                });

            migrationBuilder.InsertData(
                table: "UsuarioEstado",
                columns: new[] { "Id", "DescripcionEstado", "FechaBaja", "FechaCreacion", "FechaModificacion", "NombreEstado", "UsuarioEditor" },
                values: new object[,]
                {
                    { 1, "Usuario activo en el club", null, new DateTime(2024, 7, 13, 14, 12, 47, 667, DateTimeKind.Local).AddTicks(9103), null, "Activo", 1 },
                    { 2, "Usuario bloqueado", null, new DateTime(2024, 7, 13, 14, 12, 47, 667, DateTimeKind.Local).AddTicks(9118), null, "Bloqueado", 1 },
                    { 3, "Usuario desactivado", null, new DateTime(2024, 7, 13, 14, 12, 47, 667, DateTimeKind.Local).AddTicks(9120), null, "Desactivado", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

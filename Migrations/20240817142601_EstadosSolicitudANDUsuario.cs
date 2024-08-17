using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class EstadosSolicitudANDUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Eliminar claves foráneas que dependen de la columna Id
            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudAsociacionHistorial_EstadoSolicitudAsociacion_EstadoSolicitudAsociacionId",
                table: "SolicitudAsociacionHistorial");

            // Eliminar la clave primaria de la tabla EstadoSolicitudAsociacion
            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadoSolicitudAsociacion",
                table: "EstadoSolicitudAsociacion");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoSolicitudAsociacionId",
                table: "SolicitudAsociacionHistorial",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            // Eliminar la columna Id
            migrationBuilder.DropColumn(
                name: "Id",
                table: "EstadoSolicitudAsociacion");

            // Crear la columna Id como int con la propiedad IDENTITY
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EstadoSolicitudAsociacion",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"); // Esto agrega la propiedad IDENTITY

            // Establecer la nueva clave primaria con la columna Id
            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadoSolicitudAsociacion",
                table: "EstadoSolicitudAsociacion",
                column: "Id");

            // Restaurar la clave foránea con la nueva columna Id
            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudAsociacionHistorial_EstadoSolicitudAsociacion_EstadoSolicitudAsociacionId",
                table: "SolicitudAsociacionHistorial",
                column: "EstadoSolicitudAsociacionId",
                principalTable: "EstadoSolicitudAsociacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    table: "EstadoSolicitudAsociacion",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)")
            //    .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.InsertData(
                table: "EstadoSolicitudAsociacion",
                columns: new[] { "Id", "DescripcionEstado", "FechaBaja", "FechaCreacion", "FechaModificacion", "NombreEstado", "UsuarioEditor" },
                values: new object[,]
                {
                    { 1, "Solicitud pendiente", null, new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5531), null, "Pendiente", 1 },
                    { 2, "Solicitud aprobada", null, new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5533), null, "Aprobada", 1 },
                    { 3, "Solicitud rechazada", null, new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5535), null, "Rechazada", 1 }
                });

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5195));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Revertir los cambios si es necesario (esto depende de la lógica de tu aplicación)

            // Eliminar la clave foránea
            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudAsociacionHistorial_EstadoSolicitudAsociacion_EstadoSolicitudAsociacionId",
                table: "SolicitudAsociacionHistorial");

            // Eliminar la clave primaria
            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadoSolicitudAsociacion",
                table: "EstadoSolicitudAsociacion");

            // Eliminar la columna Id
            migrationBuilder.DropColumn(
                name: "Id",
                table: "EstadoSolicitudAsociacion");

            // Volver a crear la columna Id como estaba originalmente (esto depende de la situación específica)
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EstadoSolicitudAsociacion",
                nullable: false,
                defaultValue: 0);

            // Restaurar la clave primaria original
            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadoSolicitudAsociacion",
                table: "EstadoSolicitudAsociacion",
                column: "Id");

            // Restaurar la clave foránea original
            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudAsociacionHistorial_EstadoSolicitudAsociacion_EstadoSolicitudAsociacionId",
                table: "SolicitudAsociacionHistorial",
                column: "EstadoSolicitudAsociacionId",
                principalTable: "EstadoSolicitudAsociacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.DeleteData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Usuario");

            migrationBuilder.AlterColumn<string>(
                name: "EstadoSolicitudAsociacionId",
                table: "SolicitudAsociacionHistorial",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "EstadoSolicitudAsociacion",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 21, 49, 23, 635, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 21, 49, 23, 635, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 21, 49, 23, 635, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 21, 49, 23, 635, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 21, 49, 23, 635, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 21, 49, 23, 635, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 21, 49, 23, 635, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 21, 49, 23, 635, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 21, 49, 23, 635, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 21, 49, 23, 635, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 21, 49, 23, 635, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 6, 21, 49, 23, 635, DateTimeKind.Local).AddTicks(5927));
        }
    }
}

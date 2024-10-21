using System;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Lecciones;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class TipoAccionPartido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "FechaBaja",
            //    table: "Evento");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "AsistenciaLeccion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NroJugadorCambio",
                table: "AccionPartido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Disciplina",
                columns: new[] { "Id", "CantJugadores", "CantJugadoresEnBanca", "Descripcion", "EventoId", "FechaBaja", "FechaCreacion", "FechaModificacion", "Nombre", "PeriodosMax", "TarjetasAdvertencia", "TarjetasExpulsion", "UsuarioEditor" },
                values: new object[,]
                {
                    { 1, 11, 11, "Juego entre dos equipos de once jugadores cada uno, cuyo objetivo es hacer entrar en la portería contraria un balón que no puede ser tocado con las manos ni con los brazos, salvo por el portero en su área de meta.", null, null, new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7333), null, "Futbol", 2, 2, 1, 1 },
                    { 2, 7, 7, "Es un deporte donde dos equipos se enfrentan sobre un terreno de juego liso separados por una red central, tratando de pasar el balón por encima de la red hacia el suelo del campo contrario.", null, null, new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7368), null, "Voleyball", 5, 2, 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(8291));

            //migrationBuilder.InsertData(
            //    table: "TipoEvento",
            //    columns: new[] { "Id", "Descripcion", "FechaBaja", "FechaCreacion", "FechaModificacion", "NombreTipoEvento", "UsuarioEditor" },
            //    values: new object[,]
            //    {
            //        { 1, "Partido de un deporte", null, new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7909), null, "Partido", 1 },
            //        { 6, "Recital en el club", null, new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7914), null, "Recital", 1 },
            //        { 3, "Taller de enseñanza", null, new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7916), null, "Taller", 1 },
            //        { 4, "Curso", null, new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7918), null, "Curso", 1 },
            //        { 5, "Feria", null, new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7920), null, "Feria", 1 }
            //    });

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 19, 18, 50, 55, 37, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.CreateIndex(
                name: "IX_AsistenciaLeccion_UsuarioId",
                table: "AsistenciaLeccion",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_AsistenciaLeccion_Usuario_UsuarioId",
                table: "AsistenciaLeccion",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.Sql(
            @"INSERT INTO TipoAccionPartido (NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES ('Gol', 'Remate que entró al arco', 0, 0, 1, 1, null, GETDATE(), null,1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Falta', 'Infracción de las reglas del juego de manera imprudente, con uso de excesiva fuerza.', 0, 0, 1, 1, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Tarjeta Amarilla', 'Advertencia al jugador por comportamiento que no está permitido dentro del campo de juego', 1, 0, 1, 1, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Tarjeta Roja', 'Sanción que indica que un jugador ha sido expulsado del partido y no puede continuar jugando', 0, 1, 1, 1, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Cambio Jugador', 'Cambio de jugador dentro de la cancha por uno en la banca', 0, 0, 1, 1, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Pase', 'Pase de pelota a otro jugador', 0, 0, 1, 1, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Asistencia', 'Pase de pelota antes de que anote un gol', 0, 0, 1, 1, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Remate a puerta', 'Remate de pelota al arco', 0, 0, 1, 1, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Remate afuera', 'Remate de pelota fuera de la cancha', 0, 0, 1, 1, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Remate en contra', 'Remate al arco propio', 0, 0, 1, 1, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Remate atajado', 'Remate atajado por arquero', 0, 0, 1, 1, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Remate recibido', 'Remate no atajado por arquero que terminó en gol', 0, 0, 1, 1, null, GETDATE(), null, 1);

            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Punto', 'Toque de la pelota en la cancha contraria', 0, 0, 0, 2, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Saque', 'Saque de pelota desde el fondo de la cancha', 0, 0, 0, 2, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Recepción', 'Recepcion de saque', 0, 0, 0, 2, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Armado', 'Armado de pelota para ataque', 0, 0, 0, 2, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Ataque', 'Golpe de pelota hacia la cancha contraria', 0, 0, 0, 2, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Bloqueo', 'Frenado de ataque contrario al lado de la red', 0, 0, 0, 2, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Tarjeta Amarilla', 'Advertencia al jugador por comportamiento que no está permitido dentro del campo de juego', 1, 0, 0, 2, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Tarjeta Roja', 'Sanción que indica que un jugador ha sido expulsado del partido y no puede continuar jugando', 0, 1, 0, 2, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Cambio Jugador', 'Cambio de jugador dentro de la cancha por uno en la banca', 0, 0, 0, 2, null, GETDATE(), null, 1);
            INSERT INTO TipoAccionPartido(NombreTipoAccion, Descripcion, ModificaTarjetasAdvertencia, ModificaTarjetasExpulsion, secuencial, DisciplinaId, FechaBaja, FechaCreacion, FechaModificacion, UsuarioEditor) VALUES('Defensa', 'Recepcion de ataque contrario', 0, 0, 0, 2, null, GETDATE(), null, 1)"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
            name: "FK_AsistenciaLeccion_Usuario_UsuarioId",
            table: "AsistenciaLeccion");
            migrationBuilder.DropIndex(
            name: "IX_AsistenciaLeccion_UsuarioId",
            table: "AsistenciaLeccion");
            migrationBuilder.DeleteData(
            table: "Disciplina",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Disciplina",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "AsistenciaLeccion");

            migrationBuilder.DropColumn(
                name: "NroJugadorCambio",
                table: "AccionPartido");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBaja",
                table: "Evento",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 3, 18, 1, 53, 7, DateTimeKind.Local).AddTicks(1501));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class Karen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Id", "CantJugadores", "CantJugadoresEnBanca", "Descripcion", "FechaBaja", "FechaCreacion", "FechaModificacion", "Nombre", "PeriodosMax", "TarjetasAdvertencia", "TarjetasExpulsion", "UsuarioEditor" },
                values: new object[,]
                {
                    { 1, 11, 11, "Juego entre dos equipos de once jugadores cada uno, cuyo objetivo es hacer entrar en la portería contraria un balón que no puede ser tocado con las manos ni con los brazos, salvo por el portero en su área de meta.", null, new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(105), null, "Futbol", 2, 2, 1, 1 },
                    { 2, 7, 7, "Es un deporte donde dos equipos se enfrentan sobre un terreno de juego liso separados por una red central, tratando de pasar el balón por encima de la red hacia el suelo del campo contrario.", null, new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(118), null, "Voleyball", 5, 2, 1, 1 }
                });

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

            migrationBuilder.InsertData(
                table: "TipoEvento",
                columns: new[] { "Id", "Descripcion", "FechaBaja", "FechaCreacion", "FechaModificacion", "NombreTipoEvento", "UsuarioEditor" },
                values: new object[,]
                {
                    { 1, "Partido de un deporte", null, new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(309), null, "Partido", 1 },
                    { 3, "Taller de enseñanza", null, new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(314), null, "Taller", 1 },
                    { 4, "Curso", null, new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(315), null, "Curso", 1 },
                    { 5, "Feria", null, new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(316), null, "Feria", 1 },
                    { 6, "Recital en el club", null, new DateTime(2024, 10, 21, 20, 37, 6, 596, DateTimeKind.Local).AddTicks(312), null, "Recital", 1 }
                });

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TipoEvento",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "AsistenciaLeccion");

            migrationBuilder.DropColumn(
                name: "NroJugadorCambio",
                table: "AccionPartido");

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 19, 6, 183, DateTimeKind.Local).AddTicks(5719));
        }
    }
}

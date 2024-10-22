using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class DisciplinaEvento3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Evento_Disciplina_DisciplinaId",
            //    table: "Evento");

            migrationBuilder.AddColumn<int>(
       name: "DisciplinaId",
       table: "Evento",
       type: "int",
       nullable: false,
       defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
    name: "FK_Evento_Disciplina_DisciplinaId",
    table: "Evento",
    column: "DisciplinaId",
    principalTable: "Disciplina",
    principalColumn: "Id",
    onDelete: ReferentialAction.Restrict);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Disciplina_DisciplinaId",
                table: "Evento");

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 10, 21, 20, 14, 30, 333, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Disciplina_DisciplinaId",
                table: "Evento",
                column: "DisciplinaId",
                principalTable: "Disciplina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

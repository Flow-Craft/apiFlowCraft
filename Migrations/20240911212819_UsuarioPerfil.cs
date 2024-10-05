using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class UsuarioPerfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstalacionHistorial_Instalacion_InstalacionId",
                table: "InstalacionHistorial");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilPermiso_Perfil_PerfilId",
                table: "PerfilPermiso");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilPermiso_Permiso_PermisoId",
                table: "PerfilPermiso");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_Usuario_UsuarioId",
                table: "PerfilUsuario");

            migrationBuilder.DropIndex(
                name: "IX_PerfilUsuario_UsuarioId",
                table: "PerfilUsuario");

            migrationBuilder.DropIndex(
                name: "IX_PerfilPermiso_PerfilId",
                table: "PerfilPermiso");

            migrationBuilder.DropIndex(
                name: "IX_PerfilPermiso_PermisoId",
                table: "PerfilPermiso");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "PerfilUsuario");

            migrationBuilder.AddColumn<int>(
                name: "PerfilUsuarioId",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstalacionId",
                table: "InstalacionHistorial",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "EquipoEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "EstadoEvento",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "Id", "DescripcionPerfil", "FechaBaja", "FechaCreacion", "FechaModificacion", "NombrePerfil", "PerfilUsuarioId", "UsuarioEditor" },
                values: new object[,]
                {
                    { 1, "Administrador general del sistema", null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4431), null, "Admin", null, 1 },
                    { 2, "Administrativo perteneciente al club", null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4433), null, "Administrativo", null, 1 },
                    { 3, "Usuario publico", null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4435), null, "Simpatizante", null, 1 },
                    { 4, "Usuario privado socio del club", null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4438), null, "Socio", null, 1 },
                    { 5, "Usuario privado profesor perteneciente al club", null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4440), null, "Profesor", null, 1 },
                    { 6, "Usuario privado arbitro oficial para partidos", null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4441), null, "Arbitro", null, 1 },
                    { 7, "Usuario privado ayudante de profesor en partidos", null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4443), null, "Planillero", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "PerfilPermiso",
                columns: new[] { "Id", "FechaBaja", "FechaCreacion", "FechaModificacion", "PerfilId", "PermisoId", "UsuarioEditor" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4873), null, 2, 1, 1 },
                    { 2, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4877), null, 2, 2, 1 },
                    { 3, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4879), null, 2, 3, 1 },
                    { 4, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4880), null, 2, 4, 1 },
                    { 5, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4882), null, 2, 5, 1 },
                    { 6, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4884), null, 2, 6, 1 },
                    { 7, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4885), null, 2, 7, 1 },
                    { 8, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4886), null, 2, 8, 1 },
                    { 9, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4888), null, 2, 9, 1 },
                    { 10, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4889), null, 2, 10, 1 },
                    { 11, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4891), null, 2, 11, 1 },
                    { 12, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4892), null, 2, 12, 1 },
                    { 13, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4894), null, 2, 13, 1 },
                    { 14, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4895), null, 2, 14, 1 },
                    { 15, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4896), null, 2, 15, 1 },
                    { 16, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4898), null, 2, 16, 1 },
                    { 17, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4899), null, 2, 17, 1 },
                    { 18, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4901), null, 2, 18, 1 },
                    { 19, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4904), null, 2, 19, 1 },
                    { 20, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4905), null, 2, 20, 1 },
                    { 21, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4907), null, 2, 21, 1 },
                    { 22, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4909), null, 2, 22, 1 },
                    { 23, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4912), null, 2, 23, 1 },
                    { 24, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4913), null, 2, 24, 1 },
                    { 25, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4915), null, 2, 25, 1 },
                    { 26, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4916), null, 2, 26, 1 },
                    { 27, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4918), null, 2, 27, 1 },
                    { 28, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4920), null, 3, 28, 1 },
                    { 29, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4921), null, 4, 28, 1 },
                    { 30, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4923), null, 2, 29, 1 },
                    { 31, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4925), null, 3, 29, 1 },
                    { 32, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4927), null, 4, 29, 1 },
                    { 33, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4929), null, 2, 30, 1 },
                    { 34, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4930), null, 2, 31, 1 },
                    { 35, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4932), null, 2, 32, 1 },
                    { 36, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4934), null, 2, 33, 1 },
                    { 37, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4935), null, 3, 33, 1 },
                    { 38, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4937), null, 4, 33, 1 },
                    { 39, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4939), null, 2, 34, 1 },
                    { 40, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4940), null, 2, 35, 1 },
                    { 41, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4942), null, 2, 36, 1 },
                    { 42, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4944), null, 2, 37, 1 },
                    { 43, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4945), null, 3, 37, 1 },
                    { 44, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4947), null, 4, 37, 1 },
                    { 45, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4948), null, 2, 38, 1 },
                    { 46, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4964), null, 2, 39, 1 },
                    { 47, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4965), null, 3, 40, 1 },
                    { 48, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4967), null, 4, 40, 1 },
                    { 49, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4969), null, 3, 41, 1 },
                    { 50, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4970), null, 4, 41, 1 },
                    { 51, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4972), null, 6, 42, 1 },
                    { 52, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4974), null, 6, 43, 1 },
                    { 53, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4975), null, 6, 44, 1 },
                    { 54, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4978), null, 6, 45, 1 },
                    { 55, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4979), null, 6, 46, 1 },
                    { 56, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4981), null, 7, 47, 1 },
                    { 57, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4983), null, 7, 48, 1 },
                    { 58, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4985), null, 7, 49, 1 },
                    { 59, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4988), null, 7, 50, 1 },
                    { 60, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4989), null, 6, 51, 1 },
                    { 61, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4991), null, 6, 52, 1 },
                    { 62, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4992), null, 3, 53, 1 },
                    { 63, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4994), null, 3, 54, 1 },
                    { 64, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4995), null, 4, 54, 1 },
                    { 65, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4997), null, 3, 55, 1 },
                    { 66, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4998), null, 4, 55, 1 },
                    { 67, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5000), null, 4, 56, 1 },
                    { 68, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5001), null, 3, 57, 1 },
                    { 69, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5003), null, 4, 57, 1 },
                    { 70, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5005), null, 3, 58, 1 },
                    { 71, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5006), null, 2, 59, 1 },
                    { 72, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5010), null, 4, 59, 1 },
                    { 73, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5011), null, 2, 60, 1 },
                    { 74, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5013), null, 4, 60, 1 },
                    { 75, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5015), null, 2, 61, 1 },
                    { 76, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5016), null, 4, 61, 1 },
                    { 77, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5018), null, 4, 62, 1 },
                    { 78, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5020), null, 4, 63, 1 },
                    { 79, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5021), null, 5, 64, 1 },
                    { 80, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5023), null, 5, 65, 1 },
                    { 81, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5025), null, 5, 66, 1 },
                    { 82, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5027), null, 5, 67, 1 },
                    { 83, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5028), null, 5, 68, 1 },
                    { 84, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5030), null, 5, 69, 1 },
                    { 85, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5033), null, 2, 70, 1 },
                    { 86, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5034), null, 2, 71, 1 },
                    { 87, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5036), null, 2, 72, 1 },
                    { 88, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5037), null, 2, 73, 1 },
                    { 89, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5039), null, 4, 74, 1 },
                    { 90, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5040), null, 4, 75, 1 },
                    { 91, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5042), null, 4, 76, 1 },
                    { 92, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5044), null, 5, 76, 1 },
                    { 93, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5045), null, 2, 77, 1 },
                    { 94, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5047), null, 2, 78, 1 },
                    { 95, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5049), null, 2, 79, 1 },
                    { 96, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5050), null, 4, 80, 1 },
                    { 97, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5052), null, 4, 81, 1 },
                    { 98, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5055), null, 2, 82, 1 },
                    { 99, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5056), null, 4, 82, 1 },
                    { 100, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5058), null, 2, 83, 1 },
                    { 101, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5060), null, 4, 83, 1 },
                    { 102, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5061), null, 2, 84, 1 },
                    { 103, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5063), null, 4, 84, 1 },
                    { 104, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5064), null, 1, 85, 1 },
                    { 105, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5066), null, 1, 86, 1 },
                    { 106, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5068), null, 1, 87, 1 },
                    { 107, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5069), null, 1, 88, 1 },
                    { 108, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5071), null, 1, 89, 1 },
                    { 109, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5072), null, 1, 90, 1 },
                    { 110, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5074), null, 1, 91, 1 },
                    { 111, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5076), null, 1, 92, 1 },
                    { 112, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5078), null, 1, 93, 1 },
                    { 113, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5079), null, 1, 94, 1 },
                    { 114, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5081), null, 1, 95, 1 },
                    { 115, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5082), null, 1, 96, 1 },
                    { 116, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5084), null, 1, 97, 1 },
                    { 117, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5085), null, 1, 98, 1 },
                    { 118, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5087), null, 1, 99, 1 },
                    { 119, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5089), null, 1, 100, 1 },
                    { 120, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5090), null, 1, 101, 1 },
                    { 121, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5092), null, 1, 102, 1 },
                    { 122, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5093), null, 1, 103, 1 },
                    { 123, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5095), null, 1, 104, 1 },
                    { 124, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5096), null, 1, 105, 1 },
                    { 125, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5099), null, 1, 106, 1 },
                    { 126, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5101), null, 1, 107, 1 },
                    { 127, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5103), null, 1, 108, 1 },
                    { 128, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5104), null, 1, 109, 1 },
                    { 129, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5106), null, 1, 110, 1 },
                    { 130, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5108), null, 1, 111, 1 },
                    { 131, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5109), null, 2, 112, 1 },
                    { 132, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5111), null, 2, 113, 1 },
                    { 133, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5113), null, 2, 114, 1 },
                    { 134, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5115), null, 2, 115, 1 },
                    { 135, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5116), null, 2, 116, 1 },
                    { 136, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5118), null, 2, 117, 1 },
                    { 137, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5119), null, 2, 118, 1 },
                    { 138, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(5122), null, 2, 119, 1 }
                });

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "Id", "FechaBaja", "FechaCreacion", "FechaModificacion", "Funcionalidades", "Modulo", "NombrePermiso" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4476), null, "Alta usuario", "Usuario", "Configuracion del sistema" },
                    { 2, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4481), null, "Modificación usuario", "Usuario", "Configuracion del sistema" },
                    { 3, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4483), null, "Baja usuario", "Usuario", "Configuracion del sistema" },
                    { 4, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4484), null, "Blanquear contraseña usuario", "Usuario", "Configuracion del sistema" },
                    { 5, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4486), null, "Ver información usuario", "Usuario", "Configuracion del sistema" },
                    { 6, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4487), null, "Bloquear usuario", "Usuario", "Configuracion del sistema" },
                    { 7, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4489), null, "Desbloquear usuario", "Usuario", "Configuracion del sistema" },
                    { 8, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4491), null, "Alta grupo familiar", "Usuario", "Configuracion del sistema" },
                    { 9, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4493), null, "Modificación grupo familiar", "Usuario", "Configuracion del sistema" },
                    { 10, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4494), null, "Baja grupo familiar", "Usuario", "Configuracion del sistema" },
                    { 11, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4496), null, "Aceptar solicitud", "Solicitudes", "Configuracion del sistema" },
                    { 12, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4497), null, "Rechazar solicitud", "Solicitudes", "Configuracion del sistema" },
                    { 13, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4499), null, "Alta perfil", "Perfiles", "Configuracion del sistema" },
                    { 14, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4501), null, "Modificación perfil", "Perfiles", "Configuracion del sistema" },
                    { 15, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4503), null, "Baja perfil", "Perfiles", "Configuracion del sistema" },
                    { 16, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4506), null, "Alta configuracion del sistema", "Configuraciones generales", "Configuracion del sistema" },
                    { 17, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4507), null, "Modificación configuracion del sistema", "Configuraciones generales", "Configuracion del sistema" },
                    { 18, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4509), null, "Baja configuracion del sistema", "Configuraciones generales", "Configuracion del sistema" },
                    { 19, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4512), null, "Activar configuracion del sistema", "Configuraciones generales", "Configuracion del sistema" },
                    { 20, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4525), null, "Alta terminos y condiciones", "Configuraciones generales", "Configuracion del sistema" },
                    { 21, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4527), null, "Baja terminos y condiciones", "Configuraciones generales", "Configuracion del sistema" },
                    { 22, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4529), null, "Alta disciplina", "Disciplina", "Configuracion del sistema" },
                    { 23, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4531), null, "Modificación disciplina", "Disciplina", "Configuracion del sistema" },
                    { 24, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4533), null, "Baja disciplina", "Disciplina", "Configuracion del sistema" },
                    { 25, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4534), null, "Alta categoria", "Categoria", "Configuracion del sistema" },
                    { 26, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4536), null, "Modificación categoria", "Categoria", "Configuracion del sistema" },
                    { 27, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4538), null, "Baja categoria", "Categoria", "Configuracion del sistema" },
                    { 28, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4540), null, "Ver disciplinas", "Disciplina", "Disciplina" },
                    { 29, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4543), null, "Ver instalaciones", "Instalaciones", "Instalaciones" },
                    { 30, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4545), null, "Alta instalacion", "Instalaciones", "Instalaciones" },
                    { 31, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4547), null, "Modificación instalacion", "Instalaciones", "Instalaciones" },
                    { 32, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4549), null, "Baja instalacion", "Instalaciones", "Instalaciones" },
                    { 33, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4550), null, "Ver noticias", "Noticias", "Noticias" },
                    { 34, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4552), null, "Alta noticia", "Noticias", "Noticias" },
                    { 35, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4554), null, "Modificación noticia", "Noticias", "Noticias" },
                    { 36, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4556), null, "Baja noticia", "Noticias", "Noticias" },
                    { 37, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4558), null, "Compartir noticia", "Noticias", "Noticias" },
                    { 38, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4560), null, "Alta notificacion", "Notificaciones", "Noticias" },
                    { 39, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4562), null, "Baja notificacion", "Notificaciones", "Noticias" },
                    { 40, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4564), null, "Ver partidos", "Partidos", "Partidos" },
                    { 41, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4565), null, "Visualizar partidos en tiempo real", "Partidos", "Partidos" },
                    { 42, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4567), null, "Iniciar partido", "Partidos", "Partidos" },
                    { 43, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4569), null, "Suspender partido", "Partidos", "Partidos" },
                    { 44, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4571), null, "Preparar partido", "Partidos", "Partidos" },
                    { 45, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4572), null, "Finalizar partido", "Partidos", "Partidos" },
                    { 46, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4574), null, "Alta accion de partido", "Partidos", "Partidos" },
                    { 47, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4576), null, "Alta estadistica ", "Partidos", "Partidos" },
                    { 48, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4578), null, "Modificación estadistica", "Partidos", "Partidos" },
                    { 49, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4579), null, "Baja estadistica", "Partidos", "Partidos" },
                    { 50, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4581), null, "Ver estadistica", "Partidos", "Partidos" },
                    { 51, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4584), null, "Iniciar tiempo", "Partidos", "Partidos" },
                    { 52, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4586), null, "Finalizar tiempo", "Partidos", "Partidos" },
                    { 53, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4587), null, "Asociarse", "Mi perfil", "Mi perfil" },
                    { 54, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4589), null, "Darse de baja", "Mi perfil", "Mi perfil" },
                    { 55, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4591), null, "Modificación mi perfil", "Mi perfil", "Mi perfil" },
                    { 56, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4593), null, "Generar qr", "Mi perfil", "Mi perfil" },
                    { 57, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4594), null, "Ver mi perfil", "Mi perfil", "Mi perfil" },
                    { 58, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4596), null, "Ver quienes somos", "Quienes somos?", "Quienes somos?" },
                    { 59, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4598), null, "Alta reserva", "Reservas", "Reservas" },
                    { 60, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4600), null, "Modificación reserva", "Reservas", "Reservas" },
                    { 61, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4603), null, "Baja reserva", "Reservas", "Reservas" },
                    { 62, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4605), null, "Inscribirse a leccion", "Lecciones", "Lecciones" },
                    { 63, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4607), null, "Desinscribirse a leccion", "Lecciones", "Lecciones" },
                    { 64, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4608), null, "Comenzar leccion", "Lecciones", "Lecciones" },
                    { 65, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4610), null, "Ver estadisticas de leccion", "Lecciones", "Lecciones" },
                    { 66, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4612), null, "Registrar asistencia", "Lecciones", "Lecciones" },
                    { 67, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4614), null, "Modificación estadistica", "Lecciones", "Lecciones" },
                    { 68, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4616), null, "Baja estadistica", "Lecciones", "Lecciones" },
                    { 69, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4618), null, "Finalizar leccion", "Lecciones", "Lecciones" },
                    { 70, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4620), null, "Alta evento", "Eventos", "Eventos" },
                    { 71, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4622), null, "Modificación evento", "Eventos", "Eventos" },
                    { 72, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4625), null, "Baja evento", "Eventos", "Eventos" },
                    { 73, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4627), null, "Tomar asistencia a evento", "Eventos", "Eventos" },
                    { 74, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4629), null, "Inscribirse a evento", "Eventos", "Eventos" },
                    { 75, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4631), null, "Desinscribirse a evento", "Eventos", "Eventos" },
                    { 76, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4632), null, "Ver estadisticas de leccion y partidos", "Estadisticas", "Estadisticas" },
                    { 77, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4634), null, "Alta torneo", "Torneos", "Torneos" },
                    { 78, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4636), null, "Modificación torneo", "Torneos", "Torneos" },
                    { 79, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4637), null, "Baja torneo", "Torneos", "Torneos" },
                    { 80, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4639), null, "Inscribirse a torneo", "Torneos", "Torneos" },
                    { 81, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4641), null, "Desinscribirse a torneo", "Torneos", "Torneos" },
                    { 82, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4644), null, "Alta equipo", "Equipos", "Torneos" },
                    { 83, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4646), null, "Modificación equipo", "Equipos", "Torneos" },
                    { 84, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4648), null, "Baja equipo", "Equipos", "Torneos" },
                    { 85, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4650), null, "Alta estado equipo", "Equipo", "Estados" },
                    { 86, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4651), null, "Modificación estado equipo", "Equipo", "Estados" },
                    { 87, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4653), null, "Baja estado equipo", "Equipo", "Estados" },
                    { 88, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4655), null, "Alta estado evento", "Evento", "Estados" },
                    { 89, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4656), null, "Modificación estado evento", "Evento", "Estados" },
                    { 90, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4658), null, "Baja estado evento", "Evento", "Estados" },
                    { 91, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4660), null, "Alta estado usuario", "Usuario", "Estados" },
                    { 92, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4661), null, "Modificación estado usuario", "Usuario", "Estados" },
                    { 93, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4664), null, "Baja estado usuario", "Usuario", "Estados" },
                    { 94, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4666), null, "Alta estado leccion", "Leccion", "Estados" },
                    { 95, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4667), null, "Modificación estado leccion", "Leccion", "Estados" },
                    { 96, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4669), null, "Baja estado leccion", "Leccion", "Estados" },
                    { 97, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4670), null, "Alta estado instalacion", "Instalacion", "Estados" },
                    { 98, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4672), null, "Modificación  estado instalacion", "Instalacion", "Estados" },
                    { 99, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4673), null, "Baja estado instalacion", "Instalacion", "Estados" },
                    { 100, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4676), null, "Alta estado torneo", "Torneo", "Estados" },
                    { 101, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4677), null, "Modificación estado torneo", "Torneo", "Estados" },
                    { 102, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4679), null, "Baja estado torneo", "Torneo", "Estados" },
                    { 103, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4681), null, "Alta tipo evento", "Evento", "Tipos" },
                    { 104, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4682), null, "Modificación tipo evento", "Evento", "Tipos" },
                    { 105, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4695), null, "Baja tipo evento", "Evento", "Tipos" },
                    { 106, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4697), null, "Alta tipo accion", "Accion", "Tipos" },
                    { 107, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4699), null, "Modificación tipo accion", "Accion", "Tipos" },
                    { 108, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4700), null, "Baja tipo accion", "Accion", "Tipos" },
                    { 109, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4702), null, "Descargar guia para generar backup", "Backup", "Backup" },
                    { 110, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4704), null, "Descargar guia para restaurar backup", "Backup", "Backup" },
                    { 111, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4706), null, "Actualizar archivos", "Backup", "Backup" },
                    { 112, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4708), null, "Descargar Excel", "Reservas", "Reportes" },
                    { 113, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4710), null, "Descargar PDF", "Reservas", "Reportes" },
                    { 114, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4714), null, "Descargar Excel", "Asistencia lecciones", "Reportes" },
                    { 115, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4716), null, "Descargar PDF", "Asistencia lecciones", "Reportes" },
                    { 116, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4717), null, "Descargar Excel", "Asistencias eventos", "Reportes" },
                    { 117, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4719), null, "Descargar PDF", "Asistencias eventos", "Reportes" },
                    { 118, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4721), null, "Descargar Excel", "Estadisticas", "Reportes" },
                    { 119, null, new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(4723), null, "Descargar PDF", "Estadisticas", "Reportes" }
                });

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "UsuarioEstado",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 9, 11, 18, 28, 17, 492, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfilUsuarioId",
                table: "Usuario",
                column: "PerfilUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_InstalacionHistorial_Instalacion_InstalacionId",
                table: "InstalacionHistorial",
                column: "InstalacionId",
                principalTable: "Instalacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_PerfilUsuario_PerfilUsuarioId",
                table: "Usuario",
                column: "PerfilUsuarioId",
                principalTable: "PerfilUsuario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstalacionHistorial_Instalacion_InstalacionId",
                table: "InstalacionHistorial");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_PerfilUsuario_PerfilUsuarioId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PerfilUsuarioId",
                table: "Usuario");

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "PerfilPermiso",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DropColumn(
                name: "PerfilUsuarioId",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "PerfilUsuario",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstalacionId",
                table: "InstalacionHistorial",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "EstadoSolicitudAsociacion",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 8, 17, 11, 25, 59, 711, DateTimeKind.Local).AddTicks(5535));

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

            migrationBuilder.CreateIndex(
                name: "IX_PerfilUsuario_UsuarioId",
                table: "PerfilUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilPermiso_PerfilId",
                table: "PerfilPermiso",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilPermiso_PermisoId",
                table: "PerfilPermiso",
                column: "PermisoId");

            migrationBuilder.AddForeignKey(
                name: "FK_InstalacionHistorial_Instalacion_InstalacionId",
                table: "InstalacionHistorial",
                column: "InstalacionId",
                principalTable: "Instalacion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilPermiso_Perfil_PerfilId",
                table: "PerfilPermiso",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilPermiso_Permiso_PermisoId",
                table: "PerfilPermiso",
                column: "PermisoId",
                principalTable: "Permiso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_Usuario_UsuarioId",
                table: "PerfilUsuario",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id");
        }
    }
}

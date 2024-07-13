using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiNet8.Migrations
{
    /// <inheritdoc />
    public partial class PerfilPermiso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permiso_Perfil_PerfilId",
                table: "Permiso");

            migrationBuilder.DropIndex(
                name: "IX_Permiso_PerfilId",
                table: "Permiso");

            migrationBuilder.DropColumn(
                name: "PerfilId",
                table: "Permiso");

            migrationBuilder.CreateTable(
                name: "PerfilPermiso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEditor = table.Column<int>(type: "int", nullable: false),
                    PerfilId = table.Column<int>(type: "int", nullable: false),
                    PermisoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilPermiso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerfilPermiso_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerfilPermiso_Permiso_PermisoId",
                        column: x => x.PermisoId,
                        principalTable: "Permiso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerfilPermiso_PerfilId",
                table: "PerfilPermiso",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilPermiso_PermisoId",
                table: "PerfilPermiso",
                column: "PermisoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerfilPermiso");

            migrationBuilder.AddColumn<int>(
                name: "PerfilId",
                table: "Permiso",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_PerfilId",
                table: "Permiso",
                column: "PerfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permiso_Perfil_PerfilId",
                table: "Permiso",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "Id");
        }
    }
}

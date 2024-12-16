using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class V1CreacionBaseDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    EspecialidadID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.EspecialidadID);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteID);
                });

            migrationBuilder.CreateTable(
                name: "HistoriaClinicas",
                columns: table => new
                {
                    HistoriaClinicaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PacienteID = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaClinicas", x => x.HistoriaClinicaID);
                    table.ForeignKey(
                        name: "FK_HistoriaClinicas_Pacientes_PacienteID",
                        column: x => x.PacienteID,
                        principalTable: "Pacientes",
                        principalColumn: "PacienteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    CitaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: true),
                    HistoriaClinicaID = table.Column<int>(type: "int", nullable: false),
                    EspecialidadID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.CitaID);
                    table.ForeignKey(
                        name: "FK_Citas_Especialidades_EspecialidadID",
                        column: x => x.EspecialidadID,
                        principalTable: "Especialidades",
                        principalColumn: "EspecialidadID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citas_HistoriaClinicas_HistoriaClinicaID",
                        column: x => x.HistoriaClinicaID,
                        principalTable: "HistoriaClinicas",
                        principalColumn: "HistoriaClinicaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_EspecialidadID",
                table: "Citas",
                column: "EspecialidadID");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_HistoriaClinicaID",
                table: "Citas",
                column: "HistoriaClinicaID");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_PacienteID",
                table: "HistoriaClinicas",
                column: "PacienteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "HistoriaClinicas");

            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eah.WorkSafety.WebApp.Back.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NearMisses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NearMissNumber = table.Column<int>(type: "int", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NearMissInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RootCauseAnalysis = table.Column<bool>(type: "bit", nullable: false),
                    LostDays = table.Column<int>(type: "int", nullable: false),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NearMisses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeNearMiss",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    NearMissId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeNearMiss", x => new { x.EmployeeId, x.NearMissId });
                    table.ForeignKey(
                        name: "FK_EmployeeNearMiss_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeNearMiss_NearMisses_NearMissId",
                        column: x => x.NearMissId,
                        principalTable: "NearMisses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeNearMiss_NearMissId",
                table: "EmployeeNearMiss",
                column: "NearMissId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeNearMiss");

            migrationBuilder.DropTable(
                name: "NearMisses");
        }
    }
}

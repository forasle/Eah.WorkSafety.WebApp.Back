using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eah.WorkSafety.WebApp.Back.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
<<<<<<<< HEAD:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221113082103_InitialCreate.cs
                name: "Missions",
========
                name: "Missons",
>>>>>>>> d3279d78fb7c7b68341c71870beb1360619811e3:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221115111320_mig_1.cs
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignerUserId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
<<<<<<<< HEAD:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221113082103_InitialCreate.cs
                    table.PrimaryKey("PK_Missions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
========
                    table.PrimaryKey("PK_Missons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
>>>>>>>> d3279d78fb7c7b68341c71870beb1360619811e3:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221115111320_mig_1.cs
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
<<<<<<<< HEAD:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221113082103_InitialCreate.cs
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
========
                    table.PrimaryKey("PK_Roles", x => x.Id);
>>>>>>>> d3279d78fb7c7b68341c71870beb1360619811e3:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221115111320_mig_1.cs
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
<<<<<<<< HEAD:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221113082103_InitialCreate.cs
                        name: "FK_Users_UserRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "UserRoles",
========
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RiskAssessment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IdentifierUserId = table.Column<int>(type: "int", nullable: false),
                    RevisionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskAssessment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskAssessment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
>>>>>>>> d3279d78fb7c7b68341c71870beb1360619811e3:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221115111320_mig_1.cs
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserMission",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMission", x => new { x.UserId, x.MissionId });
                    table.ForeignKey(
<<<<<<<< HEAD:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221113082103_InitialCreate.cs
                        name: "FK_UserMission_Missions_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Missions",
========
                        name: "FK_UserMission_Missons_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Missons",
>>>>>>>> d3279d78fb7c7b68341c71870beb1360619811e3:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221115111320_mig_1.cs
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMission_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
<<<<<<<< HEAD:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221113082103_InitialCreate.cs
========
                name: "IX_RiskAssessment_UserId",
                table: "RiskAssessment",
                column: "UserId");

            migrationBuilder.CreateIndex(
>>>>>>>> d3279d78fb7c7b68341c71870beb1360619811e3:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221115111320_mig_1.cs
                name: "IX_UserMission_MissionId",
                table: "UserMission",
                column: "MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiskAssessment");

            migrationBuilder.DropTable(
                name: "UserMission");

            migrationBuilder.DropTable(
<<<<<<<< HEAD:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221113082103_InitialCreate.cs
                name: "Missions");
========
                name: "Missons");
>>>>>>>> d3279d78fb7c7b68341c71870beb1360619811e3:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221115111320_mig_1.cs

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
<<<<<<<< HEAD:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221113082103_InitialCreate.cs
                name: "UserRoles");
========
                name: "Roles");
>>>>>>>> d3279d78fb7c7b68341c71870beb1360619811e3:Eah.WorkSafety.WebApp.Back/Persistance/Migrations/20221115111320_mig_1.cs
        }
    }
}

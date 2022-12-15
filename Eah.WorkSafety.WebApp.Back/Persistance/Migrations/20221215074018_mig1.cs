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
                name: "ChronicDiseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChronicDiseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDateOfEmployment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
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
                    table.PrimaryKey("PK_Missions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OccupationDiseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationDiseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeChronicDisease",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ChronicDiseaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeChronicDisease", x => new { x.EmployeeId, x.ChronicDiseaseId });
                    table.ForeignKey(
                        name: "FK_EmployeeChronicDisease_ChronicDiseases_ChronicDiseaseId",
                        column: x => x.ChronicDiseaseId,
                        principalTable: "ChronicDiseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeChronicDisease_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeOccupationDisease",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    OccupationDiseaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOccupationDisease", x => new { x.EmployeeId, x.OccupationDiseaseId });
                    table.ForeignKey(
                        name: "FK_EmployeeOccupationDisease_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOccupationDisease_OccupationDiseases_OccupationDiseaseId",
                        column: x => x.OccupationDiseaseId,
                        principalTable: "OccupationDiseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accidents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccidentInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RootCauseAnalysis = table.Column<bool>(type: "bit", nullable: false),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accidents_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContingencyPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanNumber = table.Column<int>(type: "int", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContingencyPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContingencyPlans_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inconsistencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RootCauseAnalysisRequirement = table.Column<bool>(type: "bit", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    RiskScore = table.Column<int>(type: "int", nullable: false),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inconsistencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inconsistencies_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    CreatorUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NearMisses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NearMisses_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreventiveActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    RootCauseAnalysis = table.Column<bool>(type: "bit", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreventiveActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreventiveActivities_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RiskAssessments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    RevisionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskAssessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskAssessments_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_UserMission_Missions_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Missions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMission_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAccident",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    AccidentId = table.Column<int>(type: "int", nullable: false),
                    LostDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAccident", x => new { x.EmployeeId, x.AccidentId });
                    table.ForeignKey(
                        name: "FK_EmployeeAccident_Accidents_AccidentId",
                        column: x => x.AccidentId,
                        principalTable: "Accidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeAccident_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeNearMiss",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    NearMissId = table.Column<int>(type: "int", nullable: false),
                    LostDays = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_Accidents_CreatorUserId",
                table: "Accidents",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ContingencyPlans_CreatorUserId",
                table: "ContingencyPlans",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAccident_AccidentId",
                table: "EmployeeAccident",
                column: "AccidentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeChronicDisease_ChronicDiseaseId",
                table: "EmployeeChronicDisease",
                column: "ChronicDiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeNearMiss_NearMissId",
                table: "EmployeeNearMiss",
                column: "NearMissId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOccupationDisease_OccupationDiseaseId",
                table: "EmployeeOccupationDisease",
                column: "OccupationDiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Inconsistencies_CreatorUserId",
                table: "Inconsistencies",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NearMisses_CreatorUserId",
                table: "NearMisses",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PreventiveActivities_CreatorUserId",
                table: "PreventiveActivities",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskAssessments_CreatorUserId",
                table: "RiskAssessments",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
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
                name: "ContingencyPlans");

            migrationBuilder.DropTable(
                name: "EmployeeAccident");

            migrationBuilder.DropTable(
                name: "EmployeeChronicDisease");

            migrationBuilder.DropTable(
                name: "EmployeeNearMiss");

            migrationBuilder.DropTable(
                name: "EmployeeOccupationDisease");

            migrationBuilder.DropTable(
                name: "Inconsistencies");

            migrationBuilder.DropTable(
                name: "PreventiveActivities");

            migrationBuilder.DropTable(
                name: "RiskAssessments");

            migrationBuilder.DropTable(
                name: "UserMission");

            migrationBuilder.DropTable(
                name: "Accidents");

            migrationBuilder.DropTable(
                name: "ChronicDiseases");

            migrationBuilder.DropTable(
                name: "NearMisses");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "OccupationDiseases");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}

﻿// <auto-generated />
using System;
using Eah.WorkSafety.WebApp.Back.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Eah.WorkSafety.WebApp.Back.Persistance.Migrations
{
    [DbContext(typeof(WorkSafetyDbContext))]
    partial class WorkSafetyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Accident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccidentInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccidentNumber")
                        .HasColumnType("int");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("LostDays")
                        .HasColumnType("int");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RootCauseAnalysis")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.ToTable("Accidents");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.ChronicDisease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChronicDiseases");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.ContingencyPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlanNumber")
                        .HasColumnType("int");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.ToTable("ContingencyPlans");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDateOfEmployment")
                        .HasColumnType("datetime2");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.EmployeeAccident", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("AccidentId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "AccidentId");

                    b.HasIndex("AccidentId");

                    b.ToTable("EmployeeAccident");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.EmployeeChronicDisease", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ChronicDiseaseId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "ChronicDiseaseId");

                    b.HasIndex("ChronicDiseaseId");

                    b.ToTable("EmployeeChronicDisease");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.EmployeeNearMiss", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("NearMissId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "NearMissId");

                    b.HasIndex("NearMissId");

                    b.ToTable("EmployeeNearMiss");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.EmployeeOccupationDisease", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("OccupationDiseaseId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "OccupationDiseaseId");

                    b.HasIndex("OccupationDiseaseId");

                    b.ToTable("EmployeeOccupationDisease");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Inconsistency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RiskScore")
                        .HasColumnType("int");

                    b.Property<bool>("RootCauseAnalysisRequirement")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.ToTable("Inconsistencies");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignerUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.NearMiss", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("LostDays")
                        .HasColumnType("int");

                    b.Property<string>("NearMissInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NearMissNumber")
                        .HasColumnType("int");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RootCauseAnalysis")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.ToTable("NearMisses");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.OccupationDisease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OccupationDiseases");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.RiskAssessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RevisionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.ToTable("RiskAssessments");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Definition")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.UserMission", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("MissionId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "MissionId");

                    b.HasIndex("MissionId");

                    b.ToTable("UserMission");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Accident", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.User", "User")
                        .WithMany("Accidents")
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.ContingencyPlan", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.User", "User")
                        .WithMany("ContingencyPlans")
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.EmployeeAccident", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.Accident", "Accident")
                        .WithMany("Employees")
                        .HasForeignKey("AccidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.Employee", "Employee")
                        .WithMany("Accidents")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accident");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.EmployeeChronicDisease", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.ChronicDisease", "ChronicDisease")
                        .WithMany("Employees")
                        .HasForeignKey("ChronicDiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.Employee", "Employee")
                        .WithMany("ChronicDiseases")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChronicDisease");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.EmployeeNearMiss", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.Employee", "Employee")
                        .WithMany("NearMisses")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.NearMiss", "NearMiss")
                        .WithMany("Employees")
                        .HasForeignKey("NearMissId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("NearMiss");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.EmployeeOccupationDisease", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.Employee", "Employee")
                        .WithMany("OccupationDiseases")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.OccupationDisease", "OccupationDisease")
                        .WithMany("Employees")
                        .HasForeignKey("OccupationDiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("OccupationDisease");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Inconsistency", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.User", "User")
                        .WithMany("Inconsistencies")
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.NearMiss", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.User", "User")
                        .WithMany("NearMisses")
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.RiskAssessment", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.User", "User")
                        .WithMany("RiskAssessments")
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.User", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.UserMission", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.Mission", "Mission")
                        .WithMany("Users")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.User", "User")
                        .WithMany("Missions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Accident", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.ChronicDisease", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Employee", b =>
                {
                    b.Navigation("Accidents");

                    b.Navigation("ChronicDiseases");

                    b.Navigation("NearMisses");

                    b.Navigation("OccupationDiseases");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Mission", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.NearMiss", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.OccupationDisease", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.User", b =>
                {
                    b.Navigation("Accidents");

                    b.Navigation("ContingencyPlans");

                    b.Navigation("Inconsistencies");

                    b.Navigation("Missions");

                    b.Navigation("NearMisses");

                    b.Navigation("RiskAssessments");
                });
#pragma warning restore 612, 618
        }
    }
}

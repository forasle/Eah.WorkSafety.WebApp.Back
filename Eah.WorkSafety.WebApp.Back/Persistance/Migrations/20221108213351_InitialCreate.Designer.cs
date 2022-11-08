﻿// <auto-generated />
using System;
using Eah.WorkSafety.WebApp.Back.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Eah.WorkSafety.WebApp.Back.Persistance.Migrations
{
    [DbContext(typeof(WorkSafetyContext))]
    [Migration("20221108213351_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.AccidentAndNearMiss", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AccidentNearMissInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccidentNearMissNumber")
                        .HasColumnType("int");

                    b.Property<int>("AccidentOrNearMissTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdentifierUserId")
                        .HasColumnType("int");

                    b.Property<int>("LostDays")
                        .HasColumnType("int");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RootCauseAnalysis")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AccidentOrNearMissTypeId");

                    b.HasIndex("IdentifierUserId");

                    b.ToTable("AccidentAndNearMisses");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.AccidentAndNearMissTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Definition")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccidentAndNearMissTypes");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.ContingencyPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdentifierUserId")
                        .HasColumnType("int");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlanNumber")
                        .HasColumnType("int");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentifierUserId");

                    b.ToTable("ContingencyPlans");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Inconsistency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdentifierUserId")
                        .HasColumnType("int");

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

                    b.HasIndex("IdentifierUserId");

                    b.ToTable("Inconsistencies");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssignedUserId")
                        .HasColumnType("int");

                    b.Property<int>("AssignerUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deadline")
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

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.OccupationAndChronicDisease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OccupationAndChronicDiseaseTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OccupationAndChronicDiseaseTypeId");

                    b.ToTable("OccupationAndChronicDisease");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.OccupationAndChronicDiseaseTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Definition")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OccupationAndChronicDiseaseTypes");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.PersonAccidentAndNearMiss", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccidentAndNearMissId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccidentAndNearMissId");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonAccidentAndNearMisses");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.PersonOccupationAndChronicDisease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DiagnosisDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OccupationAndChronicDiseaseId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OccupationAndChronicDiseaseId");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonOccupationAndChronicDiseases");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.RiskAssessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdentifierUserId")
                        .HasColumnType("int");

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

                    b.HasIndex("IdentifierUserId");

                    b.ToTable("RiskAssessments");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserRoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.UserMission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MissionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MissionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMissions");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Definition")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.AccidentAndNearMiss", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.AccidentAndNearMissTypes", "AccidentAndNearMissType")
                        .WithMany("AccidentNearMisses")
                        .HasForeignKey("AccidentOrNearMissTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.User", "Identifier")
                        .WithMany("AccidentNearMisses")
                        .HasForeignKey("IdentifierUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccidentAndNearMissType");

                    b.Navigation("Identifier");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.ContingencyPlan", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.User", "Identifier")
                        .WithMany("ContingencyPlans")
                        .HasForeignKey("IdentifierUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Identifier");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Inconsistency", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.User", "Identifier")
                        .WithMany("Inconsistencies")
                        .HasForeignKey("IdentifierUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Identifier");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.OccupationAndChronicDisease", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.OccupationAndChronicDiseaseTypes", "OccupationAndChronicDiseaseType")
                        .WithMany("OccupationAndChronicDisease")
                        .HasForeignKey("OccupationAndChronicDiseaseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OccupationAndChronicDiseaseType");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.PersonAccidentAndNearMiss", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.AccidentAndNearMiss", "AccidentAndNearMiss")
                        .WithMany("PersonAccidentAndNearMisses")
                        .HasForeignKey("AccidentAndNearMissId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.Person", "Person")
                        .WithMany("PersonAccidentAndNearMisses")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccidentAndNearMiss");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.PersonOccupationAndChronicDisease", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.OccupationAndChronicDisease", "OccupationAndChronicDisease")
                        .WithMany("PersonOccupationAndChronicDiseases")
                        .HasForeignKey("OccupationAndChronicDiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.Person", "Person")
                        .WithMany("PersonOccupationAndChronicDiseases")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OccupationAndChronicDisease");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.RiskAssessment", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.User", "Identifier")
                        .WithMany("RiskAssessments")
                        .HasForeignKey("IdentifierUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Identifier");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.User", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.UserRole", "UserRole")
                        .WithMany("AppUsers")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.UserMission", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.Mission", "Mission")
                        .WithMany("UserMissions")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.User", "User")
                        .WithMany("UserMissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.AccidentAndNearMiss", b =>
                {
                    b.Navigation("PersonAccidentAndNearMisses");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.AccidentAndNearMissTypes", b =>
                {
                    b.Navigation("AccidentNearMisses");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Mission", b =>
                {
                    b.Navigation("UserMissions");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.OccupationAndChronicDisease", b =>
                {
                    b.Navigation("PersonOccupationAndChronicDiseases");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.OccupationAndChronicDiseaseTypes", b =>
                {
                    b.Navigation("OccupationAndChronicDisease");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Person", b =>
                {
                    b.Navigation("PersonAccidentAndNearMisses");

                    b.Navigation("PersonOccupationAndChronicDiseases");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.User", b =>
                {
                    b.Navigation("AccidentNearMisses");

                    b.Navigation("ContingencyPlans");

                    b.Navigation("Inconsistencies");

                    b.Navigation("RiskAssessments");

                    b.Navigation("UserMissions");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.UserRole", b =>
                {
                    b.Navigation("AppUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
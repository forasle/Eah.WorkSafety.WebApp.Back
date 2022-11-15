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
    [Migration("20221115111320_mig_1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.ToTable("Missons");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.RiskAssessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RiskAssessment");
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

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.UserRole", b =>
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

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.RiskAssessment", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.User", "User")
                        .WithMany("RiskAssessments")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.User", b =>
                {
                    b.HasOne("Eah.WorkSafety.WebApp.Back.Core.Domain.UserRole", "Role")
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

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.Mission", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.User", b =>
                {
                    b.Navigation("Missions");

                    b.Navigation("RiskAssessments");
                });

            modelBuilder.Entity("Eah.WorkSafety.WebApp.Back.Core.Domain.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}

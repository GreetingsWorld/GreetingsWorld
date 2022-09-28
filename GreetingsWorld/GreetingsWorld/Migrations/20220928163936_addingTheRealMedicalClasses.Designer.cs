﻿// <auto-generated />
using System;
using GreetingsWorld.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreetingsWorld.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220928163936_addingTheRealMedicalClasses")]
    partial class addingTheRealMedicalClasses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GreetingsWorld.Models.Animal", b =>
                {
                    b.Property<int>("animalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("animalId"), 1L, 1);

                    b.Property<string>("species")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("animalId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("GreetingsWorld.Models.Comment", b =>
                {
                    b.Property<int>("worldId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("userId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("worldId", "userId");

                    b.HasIndex("userId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("GreetingsWorld.Models.Facility", b =>
                {
                    b.Property<int>("facilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("facilityId"), 1L, 1);

                    b.Property<string>("facilityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("facilityState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("facilityId");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("GreetingsWorld.Models.FacilityPatient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("facilityId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Facility_Patient");
                });

            modelBuilder.Entity("GreetingsWorld.Models.Patient", b =>
                {
                    b.Property<int>("patientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("patientId"), 1L, 1);

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("patientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("GreetingsWorld.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("worldsLiked")
                        .HasColumnType("int");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GreetingsWorld.Models.World", b =>
                {
                    b.Property<int>("worldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("worldId"), 1L, 1);

                    b.Property<DateTime>("birthDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("celestialVariety")
                        .HasColumnType("int");

                    b.Property<string>("funFact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numberGreetings")
                        .HasColumnType("int");

                    b.HasKey("worldId");

                    b.ToTable("Worlds");
                });

            modelBuilder.Entity("GreetingsWorld.Models.Comment", b =>
                {
                    b.HasOne("GreetingsWorld.Models.User", "commenter")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GreetingsWorld.Models.World", "world")
                        .WithMany("comments")
                        .HasForeignKey("worldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("commenter");

                    b.Navigation("world");
                });

            modelBuilder.Entity("GreetingsWorld.Models.World", b =>
                {
                    b.Navigation("comments");
                });
#pragma warning restore 612, 618
        }
    }
}

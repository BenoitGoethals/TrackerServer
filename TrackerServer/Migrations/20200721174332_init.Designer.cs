﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackerServer;
using TrackerServer.DAL;

namespace TrackerServer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200721174332_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TrackerServer.model.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressOfPersonId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Nr")
                        .IsRequired()
                        .HasColumnName("Nr")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnName("Street")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnName("ZipCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("AddressOfPersonId")
                        .IsUnique();

                    b.HasIndex("CountryId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("TrackerServer.model.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("TrackerServer.model.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentPersonId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ForName")
                        .IsRequired()
                        .HasColumnName("forName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Job")
                        .HasColumnName("Job")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NationalNbr")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("PublicEventId")
                        .HasColumnType("int");

                    b.Property<int?>("PublicEventId1")
                        .HasColumnType("int");

                    b.Property<int>("Relation")
                        .HasColumnName("Relation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("CurrentPersonId");

                    b.HasIndex("PublicEventId");

                    b.HasIndex("PublicEventId1");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("TrackerServer.model.PublicEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTimeEvent")
                        .HasColumnName("DateTimeEvent")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NameEvent")
                        .IsRequired()
                        .HasColumnName("NameEvent")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Peoples")
                        .HasColumnName("Peoples")
                        .HasColumnType("int");

                    b.Property<bool>("PossibleGroundZeroBySubject")
                        .HasColumnName("PossibleGroundZeroBySubject")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId1")
                        .HasColumnType("int");

                    b.Property<int>("TypeEvent")
                        .HasColumnName("TypeEvent")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("SubjectId1");

                    b.ToTable("PublicEvents");
                });

            modelBuilder.Entity("TrackerServer.model.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CoronaTest")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CoronaTest")
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2020, 7, 21, 19, 43, 32, 135, DateTimeKind.Local).AddTicks(306));

                    b.Property<bool>("CoronatestPositive")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CoronatestPositive")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("DossierNr")
                        .IsRequired()
                        .HasColumnName("DossierNr")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ExtraInformation")
                        .IsRequired()
                        .HasColumnName("ExtraInformation")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("FirstSigns")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FirstSigns")
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2020, 7, 21, 19, 43, 32, 138, DateTimeKind.Local).AddTicks(1387));

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("StatusSubject")
                        .HasColumnName("StatusSubject")
                        .HasColumnType("int");

                    b.Property<int?>("SymtomsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("SymtomsId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("TrackerServer.model.Symptoms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("AdryCough")
                        .HasColumnName("AdryCough")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ExtraInfo")
                        .HasColumnName("ExtraInfo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Fatigue")
                        .HasColumnName("Fatigue")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Fever")
                        .HasColumnName("Fever")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LossOfAppetite")
                        .HasColumnName("LossOfAppetite")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Mucus")
                        .HasColumnName("Mucus")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ShortnessOfBreath")
                        .HasColumnName("ShortnessOfBreath")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Symptoms");
                });

            modelBuilder.Entity("TrackerServer.model.Address", b =>
                {
                    b.HasOne("TrackerServer.model.Person", "Person")
                        .WithOne("Address")
                        .HasForeignKey("TrackerServer.model.Address", "AddressOfPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackerServer.model.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("TrackerServer.model.Person", b =>
                {
                    b.HasOne("TrackerServer.model.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("TrackerServer.model.Person", "CurrentPerson")
                        .WithMany("Family")
                        .HasForeignKey("CurrentPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackerServer.model.PublicEvent", null)
                        .WithMany("KnownPerson")
                        .HasForeignKey("PublicEventId");

                    b.HasOne("TrackerServer.model.PublicEvent", null)
                        .WithMany()
                        .HasForeignKey("PublicEventId1");
                });

            modelBuilder.Entity("TrackerServer.model.PublicEvent", b =>
                {
                    b.HasOne("TrackerServer.model.Subject", null)
                        .WithMany("PublicEvents")
                        .HasForeignKey("SubjectId");

                    b.HasOne("TrackerServer.model.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectId1");
                });

            modelBuilder.Entity("TrackerServer.model.Subject", b =>
                {
                    b.HasOne("TrackerServer.model.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("TrackerServer.model.Symptoms", "Symtoms")
                        .WithMany()
                        .HasForeignKey("SymtomsId");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using Academy2018_.NET_Homework5.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Academy2018_.NET_Homework5.Infrastructure.Migrations
{
    [DbContext(typeof(AirportContext))]
    [Migration("20180715021723_AddedMoreDataAttributes")]
    partial class AddedMoreDataAttributes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.Airplane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<TimeSpan>("ExploitationTerm");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Airplanes");
                });

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.AirplaneType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AirplaneModel")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("CarryingCapacity");

                    b.Property<int>("SeatsCount");

                    b.HasKey("Id");

                    b.ToTable("AirplaneTypes");
                });

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.Crew", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PilotId");

                    b.HasKey("Id");

                    b.HasIndex("PilotId");

                    b.ToTable("Crews");
                });

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.Departure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AirplaneId");

                    b.Property<int>("CrewId");

                    b.Property<DateTime>("DepartureTime");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("AirplaneId");

                    b.HasIndex("CrewId");

                    b.ToTable("Departures");
                });

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.Flight", b =>
                {
                    b.Property<string>("Number")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ArrivalTime");

                    b.Property<string>("DeparturePoint")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("DestinationPoint")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Number");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthdate");

                    b.Property<int>("Experience");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Pilots");
                });

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.Stewardesse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthdate");

                    b.Property<int?>("CrewId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("CrewId");

                    b.ToTable("Stewardesses");
                });

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FlightNumber");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("FlightNumber");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.Airplane", b =>
                {
                    b.HasOne("Academy2018_.NET_Homework5.Infrastructure.Models.AirplaneType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.Crew", b =>
                {
                    b.HasOne("Academy2018_.NET_Homework5.Infrastructure.Models.Pilot", "Pilot")
                        .WithMany()
                        .HasForeignKey("PilotId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.Departure", b =>
                {
                    b.HasOne("Academy2018_.NET_Homework5.Infrastructure.Models.Airplane", "Airplane")
                        .WithMany()
                        .HasForeignKey("AirplaneId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Academy2018_.NET_Homework5.Infrastructure.Models.Crew", "Crew")
                        .WithMany()
                        .HasForeignKey("CrewId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.Stewardesse", b =>
                {
                    b.HasOne("Academy2018_.NET_Homework5.Infrastructure.Models.Crew")
                        .WithMany("Stewardesses")
                        .HasForeignKey("CrewId");
                });

            modelBuilder.Entity("Academy2018_.NET_Homework5.Infrastructure.Models.Ticket", b =>
                {
                    b.HasOne("Academy2018_.NET_Homework5.Infrastructure.Models.Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightNumber");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(GarageContext))]
    partial class GarageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Data.Entities.Parking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Cost")
                        .HasColumnType("REAL");

                    b.Property<string>("EntryTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EntryUserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ExitTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExitUserId")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ParkingSpotId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ParkingSpotId");

                    b.ToTable("Parkings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 20.0,
                            EntryTime = "2023-10-01T08:00:00",
                            EntryUserId = "1",
                            ExitTime = "2023-10-01T10:00:00",
                            ExitUserId = "1",
                            IsDeleted = false,
                            LicensePlate = "ABC123",
                            ParkingSpotId = 1
                        },
                        new
                        {
                            Id = 2,
                            Cost = 20.0,
                            EntryTime = "2023-10-01T09:00:00",
                            EntryUserId = "1",
                            ExitTime = "2023-10-01T11:00:00",
                            ExitUserId = "1",
                            IsDeleted = false,
                            LicensePlate = "DEF456",
                            ParkingSpotId = 2
                        },
                        new
                        {
                            Id = 3,
                            EntryTime = "2024-10-01T09:00:00",
                            EntryUserId = "1",
                            IsDeleted = false,
                            LicensePlate = "GHY456",
                            ParkingSpotId = 1
                        },
                        new
                        {
                            Id = 4,
                            EntryTime = "2022-11-01T09:00:00",
                            EntryUserId = "1",
                            IsDeleted = false,
                            LicensePlate = "AGR405",
                            ParkingSpotId = 2
                        });
                });

            modelBuilder.Entity("Data.Entities.ParkingSpot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Disabled")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ParkingSpots");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = 0,
                            Description = "1A",
                            Disabled = 0
                        },
                        new
                        {
                            Id = 2,
                            Deleted = 0,
                            Description = "1B",
                            Disabled = 0
                        },
                        new
                        {
                            Id = 3,
                            Deleted = 0,
                            Description = "1C",
                            Disabled = 0
                        },
                        new
                        {
                            Id = 4,
                            Deleted = 0,
                            Description = "2A",
                            Disabled = 0
                        });
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<int>("State")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            Name = "Luis",
                            Password = "lamismadesiempre",
                            Phone = "+543323333",
                            Role = 2,
                            State = 0,
                            UserName = "luismitoto@gmail.com"
                        });
                });

            modelBuilder.Entity("Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Rates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Auto",
                            Value = 10.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Moto",
                            Value = 5.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "Camión",
                            Value = 20.0
                        },
                        new
                        {
                            Id = 4,
                            Description = "Bicicleta",
                            Value = 2.0
                        },
                        new
                        {
                            Id = 5,
                            Description = "Colectivo",
                            Value = 15.0
                        });
                });

            modelBuilder.Entity("Data.Entities.Parking", b =>
                {
                    b.HasOne("Data.Entities.ParkingSpot", "ParkingSpot")
                        .WithMany()
                        .HasForeignKey("ParkingSpotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParkingSpot");
                });
#pragma warning restore 612, 618
        }
    }
}

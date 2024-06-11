﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentACarProject.DAL;

#nullable disable

namespace RentACarProject.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240611102045_mig5")]
    partial class mig5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RentACarProject.DAL.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"), 1L, 1);

                    b.Property<string>("BodyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GearType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KM")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorPower")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("RentACarProject.DAL.DeliveryLocation", b =>
                {
                    b.Property<int>("DeliveryLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeliveryLocationId"), 1L, 1);

                    b.Property<string>("DeliveryLocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeliveryLocationId");

                    b.ToTable("DeliveryLocations");
                });

            modelBuilder.Entity("RentACarProject.DAL.ReceivingLocation", b =>
                {
                    b.Property<int>("ReceivingLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceivingLocationId"), 1L, 1);

                    b.Property<string>("ReceivingLocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReceivingLocationId");

                    b.ToTable("ReceivingLocations");
                });

            modelBuilder.Entity("RentACarProject.DAL.RentACar", b =>
                {
                    b.Property<int>("RentACarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentACarId"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeliveryLocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceivingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReceivingLocationId")
                        .HasColumnType("int");

                    b.HasKey("RentACarId");

                    b.HasIndex("CarId");

                    b.HasIndex("DeliveryLocationId");

                    b.HasIndex("ReceivingLocationId");

                    b.ToTable("RentACars");
                });

            modelBuilder.Entity("RentACarProject.DAL.RentACar", b =>
                {
                    b.HasOne("RentACarProject.DAL.Car", "Car")
                        .WithMany("RentACars")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACarProject.DAL.DeliveryLocation", "DeliveryLocation")
                        .WithMany("RentACars")
                        .HasForeignKey("DeliveryLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACarProject.DAL.ReceivingLocation", "ReceivingLocation")
                        .WithMany("RentACars")
                        .HasForeignKey("ReceivingLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("DeliveryLocation");

                    b.Navigation("ReceivingLocation");
                });

            modelBuilder.Entity("RentACarProject.DAL.Car", b =>
                {
                    b.Navigation("RentACars");
                });

            modelBuilder.Entity("RentACarProject.DAL.DeliveryLocation", b =>
                {
                    b.Navigation("RentACars");
                });

            modelBuilder.Entity("RentACarProject.DAL.ReceivingLocation", b =>
                {
                    b.Navigation("RentACars");
                });
#pragma warning restore 612, 618
        }
    }
}

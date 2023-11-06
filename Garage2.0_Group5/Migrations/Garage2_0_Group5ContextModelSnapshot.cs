﻿// <auto-generated />
using System;
using Garage2._0_Group5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Garage2._0_Group5.Migrations
{
    [DbContext(typeof(Garage2_0_Group5Context))]
    partial class Garage2_0_Group5ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Garage2._0_Group5.Models.Entities.ParkedVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("NumberOfWheels")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime?>("TimeAtCheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleBrand")
                        .HasColumnType("int");

                    b.Property<string>("VehicleModel")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("VehicleType")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ParkedVehicle");
                });
#pragma warning restore 612, 618
        }
    }
}

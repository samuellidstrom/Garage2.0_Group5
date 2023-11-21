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
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Garage2._0_Group5.Models.Entities.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PersonNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("Garage2._0_Group5.Models.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("NoOfWheels")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("Garage2._0_Group5.Models.Entities.Vehicle", b =>
                {
                    b.HasOne("Garage2._0_Group5.Models.Entities.Member", null)
                        .WithMany("Vehicles")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("Garage2._0_Group5.Models.Entities.Member", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}

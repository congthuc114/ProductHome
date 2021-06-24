﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductTestHome.Entities;

namespace ProductTestHome.Migrations
{
    [DbContext(typeof(DbProductTestHome))]
    partial class DbProductTestHomeModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductTestHome.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datePro")
                        .HasColumnType("datetime2");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nhà",
                            datePro = new DateTime(2021, 6, 15, 21, 48, 19, 669, DateTimeKind.Local).AddTicks(197),
                            photo = "https://i.ibb.co/0yfVm4t/download.jpg",
                            price = "20000"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tâm Lý Học",
                            datePro = new DateTime(2021, 6, 15, 21, 48, 19, 669, DateTimeKind.Local).AddTicks(8451),
                            photo = "https://i.ibb.co/4jZTVnH/download.jpg",
                            price = "25000"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

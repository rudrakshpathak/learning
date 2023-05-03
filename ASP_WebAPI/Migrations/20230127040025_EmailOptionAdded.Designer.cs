﻿// <auto-generated />
using System;
using ASP_WebAPI.Entity_Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP_WebAPI.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230127040025_EmailOptionAdded")]
    partial class EmailOptionAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ASP_WebAPI.Entity_Framework.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTimestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            CreatedTimestamp = new DateTime(2023, 1, 27, 9, 30, 25, 873, DateTimeKind.Local).AddTicks(7581),
                            Username = "bhav"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
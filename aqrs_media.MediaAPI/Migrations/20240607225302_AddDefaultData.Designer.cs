﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aqrs_media.MediaAPI.Data;

#nullable disable

namespace aqrsmedia.RegisterAPI.Migrations
{
    [DbContext(typeof(ContextDbApplication))]
    [Migration("20240607225302_AddDefaultData")]
    partial class AddDefaultData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("aqrs_media.MediaAPI.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<DateTime?>("InactivatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("inactivated_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("t_category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c313fa89-0025-4d9d-bbd9-d83b29ad72df"),
                            CreatedDate = new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(3104),
                            Name = "Category 1"
                        });
                });

            modelBuilder.Entity("aqrs_media.MediaAPI.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<DateTime?>("InactivatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("inactivated_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("t_genre");

                    b.HasData(
                        new
                        {
                            Id = new Guid("db1d5df5-8176-4032-be18-9b3329dc16e9"),
                            CreatedDate = new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(3091),
                            Name = "Genre 1"
                        });
                });

            modelBuilder.Entity("aqrs_media.MediaAPI.Entities.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<DateTime?>("InactivatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("inactivated_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("t_media");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c427b2e1-deeb-45cd-9b84-1d66f90bcb75"),
                            CreatedDate = new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(2973),
                            Name = "Media 1"
                        });
                });

            modelBuilder.Entity("aqrs_media.MediaAPI.Entities.MediaType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<DateTime?>("InactivatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("inactivated_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("t_media_type");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ce6875b7-efcb-4da3-bd0e-7813fbd1c479"),
                            CreatedDate = new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(3114),
                            Name = "MediaType 1"
                        });
                });

            modelBuilder.Entity("aqrs_media.MediaAPI.Entities.Participant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<DateTime?>("InactivatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("inactivated_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("t_participant");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c0d8deac-b6b9-489b-b6e3-afab399ed3a5"),
                            CreatedDate = new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(3123),
                            Name = "Participant 1"
                        },
                        new
                        {
                            Id = new Guid("537f6d12-6d9e-4a82-ae1e-ce734eea6c70"),
                            CreatedDate = new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(3125),
                            Name = "Participant 2"
                        });
                });

            modelBuilder.Entity("aqrs_media.MediaAPI.Entities.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<DateTime?>("InactivatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("inactivated_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("t_rating");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fb923c80-e9f7-4098-b8d6-5ebc2dd32315"),
                            CreatedDate = new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(3135),
                            Name = "Rating 1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
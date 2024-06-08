﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aqrs_media.CatalogAPI.Data;

#nullable disable

namespace aqrsmedia.CatalogAPI.Migrations
{
    [DbContext(typeof(ContextDbApplication))]
    [Migration("20240607225734_AddDefaultData")]
    partial class AddDefaultData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("aqrs_media.CatalogAPI.Entities.Catalog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("char(36)")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("char(36)")
                        .HasColumnName("genre_id");

                    b.Property<DateTime?>("InactivatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("inactivated_date");

                    b.Property<Guid>("MediaId")
                        .HasColumnType("char(36)")
                        .HasColumnName("media_id");

                    b.Property<Guid>("MediaTypeId")
                        .HasColumnType("char(36)")
                        .HasColumnName("media_type_id");

                    b.Property<string>("MediaURL")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("media_url");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("price");

                    b.Property<Guid>("RatingId")
                        .HasColumnType("char(36)")
                        .HasColumnName("rating_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("t_catalog");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fdda6ab1-eed4-4856-9e55-b9e96eb2f163"),
                            CategoryId = new Guid("c313fa89-0025-4d9d-bbd9-d83b29ad72df"),
                            CreatedDate = new DateTime(2024, 6, 7, 19, 57, 34, 130, DateTimeKind.Local).AddTicks(9547),
                            Description = "Descrição do catalogo 1",
                            GenreId = new Guid("db1d5df5-8176-4032-be18-9b3329dc16e9"),
                            MediaId = new Guid("c427b2e1-deeb-45cd-9b84-1d66f90bcb75"),
                            MediaTypeId = new Guid("ce6875b7-efcb-4da3-bd0e-7813fbd1c479"),
                            MediaURL = "https://localhost:7001/api/Catalog/fdda6ab1-eed4-4856-9e55-b9e96eb2f163",
                            Price = 98.579999999999998,
                            RatingId = new Guid("fb923c80-e9f7-4098-b8d6-5ebc2dd32315"),
                            Status = "ACTIVE"
                        });
                });

            modelBuilder.Entity("aqrs_media.CatalogAPI.Entities.CatalogParticipant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<Guid>("CatalogId")
                        .HasColumnType("char(36)")
                        .HasColumnName("catalog_id");

                    b.Property<Guid>("ParticipantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("participant_id");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.ToTable("t_catalog_participant");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2d5d2a29-c4ed-4ee1-b8a9-d4a9f196f5a0"),
                            CatalogId = new Guid("fdda6ab1-eed4-4856-9e55-b9e96eb2f163"),
                            ParticipantId = new Guid("c0d8deac-b6b9-489b-b6e3-afab399ed3a5")
                        },
                        new
                        {
                            Id = new Guid("a567968f-64d2-419f-a838-6ae462345898"),
                            CatalogId = new Guid("fdda6ab1-eed4-4856-9e55-b9e96eb2f163"),
                            ParticipantId = new Guid("537f6d12-6d9e-4a82-ae1e-ce734eea6c70")
                        });
                });

            modelBuilder.Entity("aqrs_media.CatalogAPI.Entities.CatalogParticipant", b =>
                {
                    b.HasOne("aqrs_media.CatalogAPI.Entities.Catalog", null)
                        .WithMany("Participants")
                        .HasForeignKey("CatalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("aqrs_media.CatalogAPI.Entities.Catalog", b =>
                {
                    b.Navigation("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}

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
    [Migration("20240604003627_AddPriceColumn")]
    partial class AddPriceColumn
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
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("InactivatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("MediaId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("MediaTypeId")
                        .HasColumnType("char(36)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<Guid>("RatingId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("t_catalog");
                });

            modelBuilder.Entity("aqrs_media.CatalogAPI.Entities.CatologParticipant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<Guid>("CatalogId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ParticipantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.ToTable("t_catalog_participant");
                });

            modelBuilder.Entity("aqrs_media.CatalogAPI.Entities.CatologParticipant", b =>
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

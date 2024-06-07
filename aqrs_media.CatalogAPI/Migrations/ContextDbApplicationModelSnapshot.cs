﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aqrs_media.CatalogAPI.Data;

#nullable disable

namespace aqrsmedia.CatalogAPI.Migrations
{
    [DbContext(typeof(ContextDbApplication))]
    partial class ContextDbApplicationModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                });

            modelBuilder.Entity("aqrs_media.CatalogAPI.Entities.CatalogParticipant", b =>
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

using aqrs_media.MediaAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace aqrs_media.MediaAPI.Data
{
    public class ContextDbApplication : DbContext
    {
        public ContextDbApplication(DbContextOptions<ContextDbApplication> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Media>().HasData(
                new Media { Id = new Guid("c427b2e1-deeb-45cd-9b84-1d66f90bcb75"), Name = "Media 1", CreatedDate = DateTime.Now, InactivatedDate = null }
            );

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = new Guid("db1d5df5-8176-4032-be18-9b3329dc16e9"), Name = "Genre 1", CreatedDate = DateTime.Now, InactivatedDate = null }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = new Guid("c313fa89-0025-4d9d-bbd9-d83b29ad72df"), Name = "Category 1", CreatedDate = DateTime.Now, InactivatedDate = null }
            );

            modelBuilder.Entity<MediaType>().HasData(
                new MediaType { Id = new Guid("ce6875b7-efcb-4da3-bd0e-7813fbd1c479"), Name = "MediaType 1", CreatedDate = DateTime.Now, InactivatedDate = null }
            );

            modelBuilder.Entity<Participant>().HasData(
                new Participant { Id = new Guid("c0d8deac-b6b9-489b-b6e3-afab399ed3a5"), Name = "Participant 1", CreatedDate = DateTime.Now, InactivatedDate = null },
                new Participant { Id = new Guid("537f6d12-6d9e-4a82-ae1e-ce734eea6c70"), Name = "Participant 2", CreatedDate = DateTime.Now, InactivatedDate = null }
            );

            modelBuilder.Entity<Rating>().HasData(
                new Rating { Id = new Guid("fb923c80-e9f7-4098-b8d6-5ebc2dd32315"), Name = "Rating 1", CreatedDate = DateTime.Now, InactivatedDate = null }
            );
        }

        DbSet<Media> Medias { get; set; }
        DbSet<Genre> Genre { get; set; }
        DbSet<Category> Category { get; set; }
        DbSet<MediaType> MediaType { get; set; }
        DbSet<Participant> Participant { get; set; }
        DbSet<Rating> Rating { get; set; }
    }
}

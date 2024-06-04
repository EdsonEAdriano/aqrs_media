using aqrs_media.CatalogAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace aqrs_media.CatalogAPI.Data
{
    public class ContextDbApplication : DbContext
    {
        public ContextDbApplication(DbContextOptions<ContextDbApplication> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Catalog>()
                .Property(e => e.Status)
                .HasConversion<string>();
        }

        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<CatalogParticipant> CatalogParticipants { get; set; }
    }
}
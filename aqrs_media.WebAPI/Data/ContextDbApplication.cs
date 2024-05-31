using aqrs_media.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace aqrs_media.WebAPI.Data
{
    public class ContextDbApplication : DbContext
    {
        public ContextDbApplication(DbContextOptions<ContextDbApplication> options) : base(options)
        {
        }

        DbSet<Media> Medias { get; set; }
        DbSet<Genre> Genre { get; set; }
        DbSet<Category> Category { get; set; }
        DbSet<MediaType> MediaType { get; set; }
        DbSet<Participant> Participant { get; set; }
        DbSet<Rating> Rating { get; set; }
    }
}

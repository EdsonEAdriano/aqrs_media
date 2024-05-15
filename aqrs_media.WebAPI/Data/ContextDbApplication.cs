using Microsoft.EntityFrameworkCore;

namespace aqrs_media.WebAPI.Data
{
    public class ContextDbApplication : DbContext
    {
        public ContextDbApplication(DbContextOptions<ContextDbApplication> options) : base(options)
        {
        }
    }
}

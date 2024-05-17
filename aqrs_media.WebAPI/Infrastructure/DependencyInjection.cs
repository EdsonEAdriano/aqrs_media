using aqrs_media.WebAPI.Data;
using aqrs_media.WebAPI.Interfaces;
using aqrs_media.WebAPI.Mappings;
using aqrs_media.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace aqrs_media.WebAPI.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            var connection = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<ContextDbApplication>(options =>
                options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 23))));

            services.AddScoped<IMediaRepository, MediaRepository>();

            services.AddAutoMapper(typeof(DomainToDTOAndReverseProfile));

            return services;
        }
    }
}

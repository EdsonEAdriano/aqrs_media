using aqrs_media.MediaAPI.Data;
using aqrs_media.MediaAPI.Interfaces;
using aqrs_media.MediaAPI.Mappings;
using aqrs_media.MediaAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace aqrs_media.MediaAPI.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            var connection = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<ContextDbApplication>(options =>
                options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 23))));

            services.AddScoped<IMediaRepository, MediaRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IMediaTypeRepository, MediaTypeRepository>();
            services.AddScoped<IParticipantRepository, ParticipantRepository>();
            services.AddScoped<IRatingRepository, RatingRepository>();


            services.AddAutoMapper(typeof(DomainToDTOAndReverseProfile));

            return services;
        }

        public static IServiceCollection AddCorsConfig(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAnyOrigin",
                    builder =>
                    {
                        builder.AllowAnyOrigin();
                        builder.AllowAnyHeader();
                        builder.AllowAnyMethod();
                    });
            });


            return services;
        }
    }
}

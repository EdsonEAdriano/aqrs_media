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

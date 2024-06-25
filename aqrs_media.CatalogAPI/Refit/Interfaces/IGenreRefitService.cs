using aqrs_media.CatalogAPI.Entities;
using Refit;

namespace aqrs_media.CatalogAPI.Refit.Interfaces
{
    public interface IGenreRefitService
    {
        [Get("/api/Genre/{id}")]
        Task<ApiResponse<GenreRefit>> GetById(Guid id);
    }
}

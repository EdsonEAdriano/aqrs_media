using aqrs_media.CatalogAPI.Entities;
using Refit;

namespace aqrs_media.CatalogAPI.Refit.Interfaces
{
    public interface IMediaRefitService
    {
        [Get("/api/Media/{id}")]
        Task<MediaRefit> GetById(Guid id);
    }
}

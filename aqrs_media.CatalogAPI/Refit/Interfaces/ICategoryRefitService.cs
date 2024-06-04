using aqrs_media.CatalogAPI.Entities;
using Refit;

namespace aqrs_media.CatalogAPI.Refit.Interface
{
    public interface ICategoryRefitService
    {
        [Get("/api/Category/{id}")]
        Task<CategoryRefit> GetById(Guid id);
    }
}

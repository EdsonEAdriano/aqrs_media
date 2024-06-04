using aqrs_media.CatalogAPI.Entities;

namespace aqrs_media.CatalogAPI.Interfaces
{
    public interface ICatalogRepository
    {
        public Task<IEnumerable<Catalog>> GetAllAsync();
        public Task<Catalog> GetByIdAsync(Guid id);

        public Task<Catalog> CreateAsync(Catalog catalog);
        public Task<Catalog> UpdateAsync(Catalog catalog);
        public Task<Catalog> DeleteAsync(Catalog catalog);
    }
}

using aqrs_media.CatalogAPI.DTOs;
using aqrs_media.CatalogAPI.Entities;

namespace aqrs_media.CatalogAPI.Interfaces
{
    public interface ICatalogService
    {
        public Task<IEnumerable<CatalogDTO>> GetAllAsync();
        public Task<CatalogDTO> GetByIdAsync(Guid id);

        public Task<CatalogDTO> CreateAsync(CatalogInsDTO catalog);
        public Task<CatalogDTO> UpdateAsync(CatalogPutDTO catalog);
        public Task<CatalogDTO> DeleteAsync(Guid id);
    }
}

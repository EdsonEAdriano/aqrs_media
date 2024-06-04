using aqrs_media.CatalogAPI.DTOs;
using aqrs_media.CatalogAPI.Entities;
using aqrs_media.CatalogAPI.Interfaces;
using AutoMapper;

namespace aqrs_media.CatalogAPI.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly ICatalogRepository _repo;
        private readonly IMapper _mapper;

        public CatalogService(ICatalogRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }



        public async Task<IEnumerable<CatalogDTO>> GetAllAsync()
        {
            var catalogs = await _repo.GetAllAsync();

            return _mapper.Map<IEnumerable<CatalogDTO>>(catalogs);
        }

        public async Task<CatalogDTO> GetByIdAsync(Guid id)
        {
            var catalog = await _repo.GetByIdAsync(id);

            return _mapper.Map<CatalogDTO>(catalog);
        }


        public async Task<CatalogDTO> CreateAsync(CatalogInsDTO catalogInsDTO)
        {
            var catalog = _mapper.Map<Catalog>(catalogInsDTO);

            await _repo.CreateAsync(catalog);

            return _mapper.Map<CatalogDTO>(catalog);    
        }

        public async Task<CatalogDTO> UpdateAsync(CatalogPutDTO catalogPutDTO)
        {
            var catalog = _mapper.Map<Catalog>(catalogPutDTO);

            await _repo.UpdateAsync(catalog);

            return _mapper.Map<CatalogDTO>(catalog);
        }

        public async Task<CatalogDTO> DeleteAsync(Guid id)
        {
            var catalog = await _repo.GetByIdAsync(id);

            if (catalog == null)
                return default;

            await _repo.DeleteAsync(catalog);

            return _mapper.Map<CatalogDTO>(catalog);
        }
    }
}

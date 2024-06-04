using aqrs_media.CatalogAPI.DTOs;
using aqrs_media.CatalogAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aqrs_media.CatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogService _service;

        public CatalogController(ICatalogService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogDTO>>> Get()
        {
            var catalogs = await _service.GetAllAsync();
            return Ok(catalogs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<CatalogDTO>>> Get(Guid id)
        {
            var catalog = await _service.GetByIdAsync(id);
            return Ok(catalog);
        }

        [HttpPost]   
        public async Task<ActionResult<CatalogDTO>> Create(CatalogInsDTO catalogInsDTO)
        {
            return await _service.CreateAsync(catalogInsDTO);
        }

        [HttpPut]
        public async Task<ActionResult<CatalogDTO>> Update(CatalogPutDTO catalogPutDTO)
        {
            return await _service.UpdateAsync(catalogPutDTO);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CatalogDTO>> Delete(Guid id)
        {
            var catalog = await _service.DeleteAsync(id);
            return Ok(catalog);
        }
    }
}

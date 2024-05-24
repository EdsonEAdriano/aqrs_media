using aqrs_media.WebAPI.DTOs;
using aqrs_media.WebAPI.Entities;
using aqrs_media.WebAPI.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aqrs_media.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _repo;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            var category = await _repo.GetAllAsync();

            return Ok(category);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Get(Guid id)
        {
            var category = await _repo.GetByIdAsync(id);

            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult<Category>> Create([FromBody] CategoryInsDTO categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);

            category.CreatedDate = DateTime.Now;

            category = await _repo.Create(category);

            return Ok(category);

        }

        [HttpPut]
        public async Task<ActionResult<Category>> Update([FromBody] CategoryPutDTO categoryDTO)
        {
            var category = await _repo.GetByIdAsync(categoryDTO.id);

            category.Name = categoryDTO.name;

            category = await _repo.Update(category);

            return Ok(category);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Category>> Delete(Guid id)
        {
            var category = await _repo.GetByIdAsync(id);

            await _repo.Delete(category);

            return Ok(category);
        }
    }
}

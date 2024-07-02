using aqrs_media.MediaAPI.DTOs;
using aqrs_media.MediaAPI.Entities;
using aqrs_media.MediaAPI.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aqrs_media.MediaAPI.Controllers
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
        public async Task<ActionResult<IEnumerable<BaseDTO>>> Get()
        {
            var category = await _repo.GetAllAsync();
            var categoryDtos = _mapper.Map<IEnumerable<BaseDTO>>(category);

            return Ok(category);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BaseDTO>> Get(Guid id)
        {
            var category = await _repo.GetByIdAsync(id);
            var categoryDtos = _mapper.Map<BaseDTO>(category);

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

        [HttpPatch("{id}")]
        public async Task<ActionResult<Category>> Delete(Guid id)
        {
            var category = await _repo.GetByIdAsync(id);

            await _repo.Delete(category);

            return Ok(category);
        }
    }
}

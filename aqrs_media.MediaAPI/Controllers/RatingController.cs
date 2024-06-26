using aqrs_media.MediaAPI.DTOs;
using aqrs_media.MediaAPI.Entities;
using aqrs_media.MediaAPI.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aqrs_media.MediaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingRepository _repo;
        private readonly IMapper _mapper;

        public RatingController(IRatingRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rating>>> Get()
        {
            var rating = await _repo.GetAllAsync();

            return Ok(rating);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Rating>> Get(Guid id)
        {
            var rating = await _repo.GetByIdAsync(id);

            return Ok(rating);
        }

        [HttpPost]
        public async Task<ActionResult<Rating>> Create([FromBody] RatingInsDTO ratingDTO)
        {
            var rating = _mapper.Map<Rating> (ratingDTO);

            rating.CreatedDate = DateTime.Now;

            rating = await _repo.Create(rating);

            return Ok(rating);
        }

        [HttpPut]
        public async Task<ActionResult<Rating>> Update([FromBody] RatingPutDTO ratingDTO)
        {
            var rating = await _repo.GetByIdAsync(ratingDTO.id);

            rating.Name = ratingDTO.name;

            rating = await _repo.Update(rating);

            return Ok(rating);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<Rating>> Delete(Guid id)
        {
            var rating = await _repo.GetByIdAsync(id);

            await _repo.Delete(rating);

            return Ok(rating);
        }
    }
}

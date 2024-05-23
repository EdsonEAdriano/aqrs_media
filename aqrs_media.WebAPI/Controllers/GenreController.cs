
using aqrs_media.WebAPI.DTOs;
using aqrs_media.WebAPI.Entities;
using aqrs_media.WebAPI.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aqrs_media.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : Controller
    {
        private readonly IGenreRepository _repo;
        private readonly IMapper _mapper;

        public GenreController(IGenreRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genre>>> Get()
        {
            var genre = await _repo.GetAllAsync();

            return Ok(genre);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Genre>> Get(Guid id)
        {
            var genre = await _repo.GetByIdAsync(id);

            return Ok(genre);
        }

        [HttpPost]
        public async Task<ActionResult<Genre>> Create([FromBody] GenreInsDTO genreDTO)
        {
            var genre = _mapper.Map<Genre>(genreDTO);

            genre.CreatedDate = DateTime.Now;

            genre = await _repo.Create(genre);

            return Ok(genre);

        }

        [HttpPut]
        public async Task<ActionResult<Genre>> Update([FromBody] GenrePutDTO genreDTO)
        {
            var genre = await _repo.GetByIdAsync(genreDTO.id);

            genre.Name = genreDTO.name;

            genre = await _repo.Update(genre);

            return Ok(genre);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Genre>> Delete(Guid id)
        {
            var genre = await _repo.GetByIdAsync(id);

            await _repo.Delete(genre);

            return Ok(genre);
        }
    }
}

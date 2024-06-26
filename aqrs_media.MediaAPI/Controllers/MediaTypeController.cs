using aqrs_media.WebAPI.DTOs;
using aqrs_media.WebAPI.Entities;
using aqrs_media.WebAPI.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aqrs_media.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaTypeController : ControllerBase
    {
        private readonly IMediaTypeRepository _repo;
        private readonly IMapper _mapper;
        public MediaTypeController(IMediaTypeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<MediaType>>> Get()
        {
            var mediaType = await _repo.GetAllAsync();

            return Ok(mediaType);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MediaType>> Get(Guid id)
        {
            var mediaType = await _repo.GetByIdAsync(id);

            return Ok(mediaType);
        }

        [HttpPost]
        public async Task<ActionResult<MediaType>> Create([FromBody] MediaTypeInsDTO mediaTypeDTO)
        {
            var mediaType = _mapper.Map<MediaType>(mediaTypeDTO);

            mediaType.CreatedDate = DateTime.Now;

            mediaType = await _repo.Create(mediaType);

            return Ok(mediaType);

        }

        [HttpPut]
        public async Task<ActionResult<MediaType>> Update([FromBody] MediaTypePutDTO mediaTypeDTO)
        {
            var mediaType = await _repo.GetByIdAsync(mediaTypeDTO.id);

            mediaType.Name = mediaTypeDTO.name;

            mediaType = await _repo.Update(mediaType);

            return Ok(mediaType);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<MediaType>> Delete(Guid id)
        {
            var mediaType = await _repo.GetByIdAsync(id);

            await _repo.Delete(mediaType);

            return Ok(mediaType);
        }
    }
}

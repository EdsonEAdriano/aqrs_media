using aqrs_media.MediaAPI.DTOs;
using aqrs_media.MediaAPI.Entities;
using aqrs_media.MediaAPI.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aqrs_media.MediaAPI.Controllers
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
        public async Task<ActionResult<IEnumerable<BaseDTO>>> Get()
        {
            var mediaType = await _repo.GetAllAsync();
            var mediaTypeDtos = _mapper.Map<IEnumerable<BaseDTO>>(mediaType);

            return Ok(mediaTypeDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BaseDTO>> Get(Guid id)
        {
            var mediaType = await _repo.GetByIdAsync(id);
            var mediaTypeDtos = _mapper?.Map<BaseDTO>(mediaType);

            return Ok(mediaTypeDtos);
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

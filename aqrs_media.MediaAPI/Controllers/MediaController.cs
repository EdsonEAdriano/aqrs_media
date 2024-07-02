using aqrs_media.MediaAPI.DTOs;
using aqrs_media.MediaAPI.Entities;
using aqrs_media.MediaAPI.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aqrs_media.MediaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IMediaRepository _repo;
        private readonly IMapper _mapper;

        public MediaController(IMediaRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<BaseDTO>>> Get()
        {
            var mediaList = await _repo.GetAllAsync();
            var mediaDtos = _mapper.Map<IEnumerable<BaseDTO>>(mediaList);

            return Ok(mediaDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BaseDTO>> Get(Guid id)
        {
            var media = await _repo.GetByIdAsync(id);
            var mediaDtos = _mapper.Map<BaseDTO>(media);

            return Ok(media);
        }

        [HttpPost]
        public async Task<ActionResult<Media>> Create([FromBody] MediaInsDTO mediaDTO)
        {
            var media = _mapper.Map<Media>(mediaDTO);

            media.CreatedDate = DateTime.Now;
            
            media = await _repo.Create(media);

            return Ok(media);
        }

        [HttpPut]
        public async Task<ActionResult<Media>> Update([FromBody] MediaPutDTO mediaDTO)
        { 
            var media = await _repo.GetByIdAsync(mediaDTO.id);

            media.Name = mediaDTO.name;

            media = await _repo.Update(media);

            return Ok(media);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<Media>> Delete(Guid id)
        {
            var media = await _repo.GetByIdAsync(id);
                
            await _repo.Delete(media);

            return Ok(media);
        }
    }
}

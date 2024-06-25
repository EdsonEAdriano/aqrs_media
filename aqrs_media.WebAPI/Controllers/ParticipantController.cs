using aqrs_media.WebAPI.DTOs;
using aqrs_media.WebAPI.Entities;
using aqrs_media.WebAPI.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aqrs_media.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantController : ControllerBase
    {
        private readonly IParticipantRepository _repo;
        private readonly IMapper _mapper;
        public ParticipantController(IParticipantRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Participant>>> Get()
        {
            var participant = await _repo.GetAllAsync();

            return Ok(participant);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Participant>> Get(Guid id)
        {
            var participant = await _repo.GetByIdAsync(id);

            return Ok(participant);
        }

        [HttpPost]
        public async Task<ActionResult<Participant>> Create([FromBody] ParticipantInsDTO participantDTO)
        {
            var participant = _mapper.Map<Participant>(participantDTO);

            participant.CreatedDate = DateTime.Now;

            participant = await _repo.Create(participant);

            return Ok(participant);

        }

        [HttpPut]
        public async Task<ActionResult<Participant>> Update([FromBody] ParticipantPutDTO participantDTO)
        {
            var participant = await _repo.GetByIdAsync(participantDTO.id);

            participant.Name = participantDTO.name;

            participant = await _repo.Update(participant);

            return Ok(participant);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<Participant>> Delete(Guid id)
        {
            var participant = await _repo.GetByIdAsync(id);

            await _repo.Delete(participant);

            return Ok(participant);
        }
    }
}

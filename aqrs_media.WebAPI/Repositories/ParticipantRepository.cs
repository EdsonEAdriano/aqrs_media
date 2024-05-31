using aqrs_media.WebAPI.Data;
using aqrs_media.WebAPI.Entities;
using aqrs_media.WebAPI.Interfaces;

namespace aqrs_media.WebAPI.Repositories
{
    public class ParticipantRepository : BaseRepository<Participant>, IParticipantRepository
    {
        public ParticipantRepository(ContextDbApplication context) : base(context)
        { 
        }
    }
}

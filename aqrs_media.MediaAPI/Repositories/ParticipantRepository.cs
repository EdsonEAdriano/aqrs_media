using aqrs_media.MediaAPI.Data;
using aqrs_media.MediaAPI.Entities;
using aqrs_media.MediaAPI.Interfaces;

namespace aqrs_media.MediaAPI.Repositories
{
    public class ParticipantRepository : BaseRepository<Participant>, IParticipantRepository
    {
        public ParticipantRepository(ContextDbApplication context) : base(context)
        { 
        }
    }
}

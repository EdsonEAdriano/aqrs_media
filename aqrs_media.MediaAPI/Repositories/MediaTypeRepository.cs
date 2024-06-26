using aqrs_media.MediaAPI.Data;
using aqrs_media.MediaAPI.Entities;
using aqrs_media.MediaAPI.Interfaces;

namespace aqrs_media.MediaAPI.Repositories
{
    public class MediaTypeRepository : BaseRepository<MediaType>, IMediaTypeRepository
    {
        public MediaTypeRepository(ContextDbApplication context) : base(context)
        {
        }
    }
}

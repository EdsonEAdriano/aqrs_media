using aqrs_media.WebAPI.Data;
using aqrs_media.WebAPI.Entities;
using aqrs_media.WebAPI.Interfaces;

namespace aqrs_media.WebAPI.Repositories
{
    public class MediaTypeRepository : BaseRepository<MediaType>, IMediaTypeRepository
    {
        public MediaTypeRepository(ContextDbApplication context) : base(context)
        {
        }
    }
}

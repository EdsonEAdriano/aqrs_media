using aqrs_media.WebAPI.Data;
using aqrs_media.WebAPI.Entities;
using aqrs_media.WebAPI.Interfaces;

namespace aqrs_media.WebAPI.Repositories
{
    public class MediaRepository : BaseRepository<Media>, IMediaRepository
    {
        public MediaRepository(ContextDbApplication context) : base(context)
        { }
    }
}

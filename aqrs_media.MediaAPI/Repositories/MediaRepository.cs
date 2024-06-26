using aqrs_media.MediaAPI.Data;
using aqrs_media.MediaAPI.Entities;
using aqrs_media.MediaAPI.Interfaces;

namespace aqrs_media.MediaAPI.Repositories
{
    public class MediaRepository : BaseRepository<Media>, IMediaRepository
    {
        public MediaRepository(ContextDbApplication context) : base(context)
        { }
    }
}

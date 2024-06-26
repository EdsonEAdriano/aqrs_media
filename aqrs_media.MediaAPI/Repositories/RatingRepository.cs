using aqrs_media.MediaAPI.Data;
using aqrs_media.MediaAPI.Entities;
using aqrs_media.MediaAPI.Interfaces;

namespace aqrs_media.MediaAPI.Repositories
{
    public class RatingRepository : BaseRepository<Rating>, IRatingRepository
    {
        public RatingRepository(ContextDbApplication context) : base(context)
        { }
    }
}

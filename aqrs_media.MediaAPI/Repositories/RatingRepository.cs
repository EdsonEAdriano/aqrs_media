using aqrs_media.WebAPI.Data;
using aqrs_media.WebAPI.Entities;
using aqrs_media.WebAPI.Interfaces;

namespace aqrs_media.WebAPI.Repositories
{
    public class RatingRepository : BaseRepository<Rating>, IRatingRepository
    {
        public RatingRepository(ContextDbApplication context) : base(context)
        { }
    }
}

using aqrs_media.WebAPI.Data;
using aqrs_media.WebAPI.Entities;
using aqrs_media.WebAPI.Interfaces;

namespace aqrs_media.WebAPI.Repositories
{
    public class GenreRepository : BaseRepository<Genre>, IGenreRepository
    {
        public GenreRepository(ContextDbApplication context) : base(context)
        {
        }
    }
}

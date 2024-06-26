using aqrs_media.MediaAPI.Data;
using aqrs_media.MediaAPI.Entities;
using aqrs_media.MediaAPI.Interfaces;

namespace aqrs_media.MediaAPI.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ContextDbApplication context) : base(context)
        { }
    }
}

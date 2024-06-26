using aqrs_media.MediaAPI.Data;
using aqrs_media.MediaAPI.Entities;
using aqrs_media.MediaAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aqrs_media.MediaAPI.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ContextDbApplication _context;

        public BaseRepository(ContextDbApplication context)
        {
            _context = context;
        }


        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _context 
                            .Set<T>()
                            .Where(t => t.Id == id)
                            .SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context
                            .Set<T>()
                            .Where(t => t.InactivatedDate == null)
                            .ToListAsync();
        }


        public async Task<T> Create(T entity)
        {
            _context
                .Set<T>()
                .Add(entity);

            await _context
                    .SaveChangesAsync();

            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _context
                .Set<T>()
                .Update(entity);

            await _context
                    .SaveChangesAsync();

            return entity;
        }

        public async Task<T> Delete(T entity)
        {
            entity.InactivatedDate = DateTime.Now;

            _context.Entry(entity).Property(e => e.InactivatedDate).IsModified = true;

            await _context
                    .SaveChangesAsync();

            return entity;
        }
    }
}

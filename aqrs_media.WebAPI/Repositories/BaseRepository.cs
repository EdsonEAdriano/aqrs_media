using aqrs_media.WebAPI.Data;
using aqrs_media.WebAPI.Entities;
using aqrs_media.WebAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aqrs_media.WebAPI.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ContextDbApplication _context;

        public BaseRepository(ContextDbApplication context)
        {
            _context = context;
        }


        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _context 
                            .Set<T>()
                            .Where(t => t.Id == id)
                            .SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<T>?> GetAllAsync()
        {
            return await _context
                            .Set<T>()
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
            _context
                .Set<T>()
                .Remove(entity);

            await _context
                    .SaveChangesAsync();

            return entity;
        }
    }
}

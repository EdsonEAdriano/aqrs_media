namespace aqrs_media.MediaAPI.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(Guid id);

        public Task<T> Create(T entity);
        public Task<T> Update(T entity);
        public Task<T> Delete(T entity);
    }
}

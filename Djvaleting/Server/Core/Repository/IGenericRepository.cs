namespace Djvaleting.Server.Core.Repository
{
    public interface IGenericRepository<T>
    {
        public Task<T> CreateAsync(T _object);
        public Task UpdateAsync(T _object);
        public Task<List<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int Id);
        public Task DeleteAsync(int id);
    }
}

using MongoDB.Bson;

namespace Services.Repositories.Abstractions
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll(bool noTracking = false);
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken, bool asNoTracking = false);

        T Get(ObjectId id);
        Task<T> GetAsync(ObjectId id, CancellationToken cancellationToken);

        bool Delete(ObjectId id);
        Task<bool> DeleteAsync(ObjectId id, CancellationToken cancellationToken);

        bool Update(T entity);
        Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken);

        T Add(T entity);
        Task<T> AddAsync(T entity, CancellationToken cancellationToken);
    }
}

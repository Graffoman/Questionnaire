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
        Task<T> DeleteAsync(ObjectId id, CancellationToken cancellationToken);

        bool Update(T entity);
        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken);

        T Add(T entity);
        Task AddAsync(T entity, CancellationToken cancellationToken);
    }
}

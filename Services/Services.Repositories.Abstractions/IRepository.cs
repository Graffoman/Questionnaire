using MongoDB.Bson;

namespace Services.Repositories.Abstractions
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll(bool noTracking = false);
        Task<ICollection<T>> GetAllAsync(CancellationToken cancellationToken, bool asNoTracking = false);
        T Get(ObjectId id);
        Task<T> GetAsync(ObjectId id, CancellationToken cancellationToken);

        ObjectId Delete(ObjectId id);
        Task<ObjectId> DeleteAsync(ObjectId id, CancellationToken cancellationToken);
        T Delete(T entity);
        Task<T> DeleteAsync(T entity, CancellationToken cancellationToken);

       T Update(T entity);
        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken);

        ObjectId Add(T entity);
        Task<T> AddAsync(T entity, CancellationToken cancellationToken);
    }
}

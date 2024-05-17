using MongoDB.Bson;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public ObjectId Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> AddAsync(T entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public ObjectId Delete(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public T Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectId> DeleteAsync(ObjectId id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(T entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public T Get(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(bool noTracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> GetAllAsync(CancellationToken cancellationToken, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(ObjectId id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

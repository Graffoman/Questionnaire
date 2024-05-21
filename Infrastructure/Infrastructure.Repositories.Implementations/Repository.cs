using Domain.Entities.Interfaces;
using Infrastructure.DataAcess;
using MongoDB.Driver;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public abstract class Repository<T> : IRepository<T> where T : class, IIdentifieble
    {
        protected readonly MongoDB<T> Db;
        private readonly IMongoCollection<T> Collection;

        protected Repository(MongoDB<T> db)
        {
            Db = db;
            Collection = db.Collection;
        }

        public virtual T Add(T entity)
        {
            Collection.InsertOne(entity);
            return entity;
        }

        public virtual async Task<T> AddAsync(T entity, CancellationToken cancellationToken)
        {
            await Collection.InsertOneAsync(entity, cancellationToken);
            return entity;
        }

        public virtual bool Delete(string id)
        {
            var result = Collection.DeleteOne(e => e.Id == id);
            return result.IsAcknowledged && result.DeletedCount > 0;
        }

        public virtual async Task<bool> DeleteAsync(string id, CancellationToken cancellationToken)
        {
            var result = await Collection.DeleteOneAsync(e => e.Id == id);
            return result.IsAcknowledged && result.DeletedCount > 0;
        }

        public virtual T Get(string id)
        {
            return Collection.Find(e => e.Id == id).FirstOrDefault();
        }

        public virtual async Task<T> GetAsync(string id, CancellationToken cancellationToken)
        {
            return await Collection.Find(e => e.Id == id).FirstOrDefaultAsync();
        }

        public virtual IQueryable<T> GetAll(bool noTracking = false)
        {
            return Collection.AsQueryable();
        }

        public virtual async Task<List<T>> GetAllAsync(CancellationToken cancellationToken, bool asNoTracking = false)
        {
            var filter = Builders<T>.Filter.Empty;
            return await Collection.Find(filter).ToListAsync();
        }

        public virtual bool Update(T entity)
        {
            var filter = Builders<T>.Filter.Eq(e => e.Id, entity.Id);
            var result = Collection.ReplaceOne(filter, entity);
            return result.IsAcknowledged && result.ModifiedCount > 0;
        }

        public virtual async Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            var filter = Builders<T>.Filter.Eq(e => e.Id, entity.Id);
            var result = await Collection.ReplaceOneAsync(filter, entity);
            return result.IsAcknowledged && result.ModifiedCount > 0;
        }
    }
}

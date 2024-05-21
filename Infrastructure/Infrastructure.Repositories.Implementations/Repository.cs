using Infrastructure.DataAcess;
using MongoDB.Bson;
using MongoDB.Driver;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public abstract class Repository<T> : IRepository<T> where T : class
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

        public virtual async Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            await Collection.InsertOneAsync(entity, cancellationToken);
        }

        public virtual bool Delete(ObjectId id)
        {
            var filter = Builders<T>.Filter.Eq(e => e.GetType().GetProperty("Id").GetValue(e), id);
            var result = Collection.DeleteOne(filter);

            return result.IsAcknowledged && result.DeletedCount > 0;
        }

        public virtual T Get(ObjectId id)
        {
            var filter = Builders<T>.Filter.Eq(e => e.GetType().GetProperty("Id").GetValue(e), id);
            return Collection.Find(filter).FirstOrDefault();
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

        public virtual async Task<T> GetAsync(ObjectId id, CancellationToken cancellationToken)
        {
            var filter = Builders<T>.Filter.Eq(e => e.GetType().GetProperty("Id").GetValue(e), id);
            return await Collection.Find(filter).FirstOrDefaultAsync();
        }

        public virtual bool Update(T entity)
        {
            var filter = Builders<T>.Filter.Eq(e => e.GetType().GetProperty("Id").GetValue(e), entity.GetType().GetProperty("Id").GetValue(entity));
            var result = Collection.ReplaceOne(filter, entity);

            return result.IsAcknowledged && result.ModifiedCount > 0;
        }
    }
}

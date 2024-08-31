using Infrastructure.DataAcces;
using MongoDB.Driver;

namespace Infrastructure.DataAcess
{
    public class MongoDB<T>
    {
        public IMongoCollection<T> Collection;

        public MongoDB(MongoSettings settings)
        {
            MongoClient client = new(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);

            string collectionName = typeof(T).Name.ToLower() + "s";

            Collection = database.GetCollection<T>(collectionName);
        }
    }
}

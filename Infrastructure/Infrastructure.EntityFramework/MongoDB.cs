using MongoDB.Driver;

namespace Infrastructure.DataAcess
{
    public class MongoDB<T>
    {
        public IMongoCollection<T> Collection;

        public MongoDB()
        {
            MongoClient client = new("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("db");

            string collectionName = typeof(T).Name.ToLower() + "s";

            Collection = database.GetCollection<T>(collectionName);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Infrastructure.EntityFramework
{
    public static class EntityFrameworkInstaller
    {
        public static IServiceCollection ConfigureContext(
            this IServiceCollection services,
            string connectionString,
            string databaseName)
        {
            services.AddDbContext<DatabaseContext>(optionsBuilder
                => optionsBuilder
                    .UseMongoDB(new MongoClient(connectionString), databaseName));

            return services;
        }
    }
}

using Services.Abstractions;
using Services.Repositories.Abstractions;
using WebApi.Settings;
using Infrastructure.DataAcess;
using Infrastructure.Repositories.Implementations;
using Services.Implementations;
using Domain.Entities.BaseClasses;
using Domain.Entities;

namespace WebApi
{
    public static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            var applicationSettings = configuration.Get<ApplicationSettings>();
            services.AddSingleton(applicationSettings)
                    .AddSingleton((IConfigurationRoot)configuration)
                    .InstallMongoDB()
                    .InstallServices()
                    .InstallRepositories();
            return services;
        }

        private static IServiceCollection InstallMongoDB(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddSingleton<MongoDB<Question>>()
                .AddSingleton<MongoDB<Questionnaire>>()
                .AddSingleton<MongoDB<User>>();
            return serviceCollection;
        }

        private static IServiceCollection InstallServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IQuestionnaireService, QuestionnaireService>()
                .AddTransient<IUserService, UserService>();
            return serviceCollection;
        }

        private static IServiceCollection InstallRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IQuestionnaireRepository, QuestionnaireRepository>()
                .AddTransient<IUserRepository, UserRepository>();
            return serviceCollection;
        }
    }
}

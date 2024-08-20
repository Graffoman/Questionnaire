using Services.Abstractions;
using Services.Repositories.Abstractions;
using WebApi.Settings;
using Infrastructure.DataAcess;
using Infrastructure.Repositories.Implementations;
using Services.Implementations;
using Domain.Entities;
using Infrastructure.DataAcces;

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
            MongoDBClassMap.RegisterClassMaps();
            serviceCollection
                .AddSingleton<MongoDB<Questionnaire>>()
                .AddSingleton<MongoDB<User>>()
                .AddSingleton<MongoDB<OpenQuestionnaire>>()
                .AddSingleton<MongoDB<QuestionnaireSubmit>>();
            return serviceCollection;
        }

        private static IServiceCollection InstallServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IQuestionnaireService, QuestionnaireService>()
                .AddTransient<IUserService, UserService>()
                .AddTransient<IOpenQuestionnaireService, OpenQuestionnaireService>()
                .AddTransient<IQuestionnaireSubmitService, QuestionnaireSubmitService>();
            return serviceCollection;
        }

        private static IServiceCollection InstallRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IQuestionnaireRepository, QuestionnaireRepository>()
                .AddTransient<IUserRepository, UserRepository>()
                .AddTransient<IOpenQuestionnaireRepository, OpenQuestionnaireRepository>()
                .AddTransient<IQuestionnaireSubmitRepository, QuestionnaireSubmitRepository>();
            return serviceCollection;
        }
    }
}

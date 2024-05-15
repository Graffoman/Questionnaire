using Services.Abstractions;
using Services.Repositories.Abstractions;
using WebApi.Settings;
using Infrastructure.EntityFramework;
using Infrastructure.Repositories.Implementations;
using Services.Implementations;

namespace WebApi
{
    public static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            var applicationSettings = configuration.Get<ApplicationSettings>();
            services.AddSingleton(applicationSettings)
                    .AddSingleton((IConfigurationRoot)configuration)
                    .InstallServices()
                    .ConfigureContext(applicationSettings.ConnectionString, applicationSettings.DatabaseName)
                    .InstallRepositories();
            return services;
        }

        private static IServiceCollection InstallServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IQuestionService, QuestionService>()
                .AddTransient<IQuestionnaireService, QuestionnaireService>();
            return serviceCollection;
        }

        private static IServiceCollection InstallRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IQuestionRepository, QuestionRepository>()
                .AddTransient<IQuestionnaireRepository, QuestionnaireRepository>();
            return serviceCollection;
        }
    }
}

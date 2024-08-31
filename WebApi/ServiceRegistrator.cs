using Services.Abstractions;
using Services.Repositories.Abstractions;
using Infrastructure.DataAcess;
using Infrastructure.Repositories.Implementations;
using Services.Implementations;
using Domain.Entities;
using Infrastructure.DataAcces;
using RabbitMQ.Abstractions;
using RabbitMQ.Implementations;

namespace WebApi
{
    public static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            var mongoSettings = configuration.GetSection("MongoSettings").Get<MongoSettings>();
            var rabbitMqSettings = configuration.GetSection("RabbitSettings").Get<RabbitSettings>();

            services.AddSingleton(mongoSettings)
                    .AddSingleton(rabbitMqSettings)
                    .AddSingleton((IConfigurationRoot)configuration)
                    .InstallMongoDB()
                    .InstallServices()
                    .InstallRepositories()
                    .InstallRabbitMQ();
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

        private static IServiceCollection InstallRabbitMQ(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddHostedService<RabbitMqConsumer>()
                .AddTransient<IRabbitMqProducer, RabbitMqProducer>();
            return serviceCollection;
        }
    }
}

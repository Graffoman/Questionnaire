using AutoMapper;
using Newtonsoft.Json;
using Services.Implementations.Mappings;
using System.Text.Json.Serialization;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            InstallAutomapper(services);
            services.AddServices(Configuration);
            services.AddControllers()
                    .AddNewtonsoftJson(options => options.SerializerSettings.TypeNameHandling = TypeNameHandling.Auto)
                    .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
            services.AddSwaggerGen();
            services.AddCors();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.AllowAnyOrigin()
                                          .AllowAnyMethod()
                                          .AllowAnyHeader());

            app.UseRouting();

            app.UseAuthorization();

            if (!env.IsProduction())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private static IServiceCollection InstallAutomapper(IServiceCollection services)
        {
            services.AddSingleton<IMapper>(new Mapper(GetMapperConfiguration()));
            return services;
        }

        private static MapperConfiguration GetMapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<QuestionnaireMappingsProfile>();
                cfg.AddProfile<UserMappingsProfile>();
            });
            configuration.AssertConfigurationIsValid();
            return configuration;
        }
    }
}

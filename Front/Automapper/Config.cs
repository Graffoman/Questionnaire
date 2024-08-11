using AutoMapper;

namespace Front.Automapper
{
	public static class Config
	{
		public static IServiceCollection InstallAutomapper(this IServiceCollection services)
		{
			services.AddSingleton<IMapper>(new Mapper(GetMapperConfiguration()));
			return services;
		}

		private static MapperConfiguration GetMapperConfiguration()
		{
			var configuration = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<QuestionnaireMappingsProfile>();
			});
			configuration.AssertConfigurationIsValid();
			return configuration;
		}
	}
}

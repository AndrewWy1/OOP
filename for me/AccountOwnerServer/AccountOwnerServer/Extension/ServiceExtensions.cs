using LoggerService;
using Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AccountOwnerServer.Extension
{
	public static class ServiceExtensions
	{
		public static void ConfigureCORS(this IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy("CorsPolicy", builder => builder
					.AllowAnyOrigin()
					.AllowAnyHeader()
					.AllowAnyMethod());
			});
		}

		public static void ConfigureIISIntegration(this IServiceCollection services)
		{
			services.Configure<IISOptions>(options => { });
		}

		public static void ConfigureLoggerServer(this IServiceCollection services)
		{
			services.AddSingleton<ILoggerManager, LoggerManager>();
		}
	}
}

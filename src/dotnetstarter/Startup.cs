using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.Runtime;

public class Startup
{
	public IConfiguration Configuration { get; set; }

	public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
	{
		var configBuilder = new ConfigurationBuilder(appEnv.ApplicationBasePath)
			.AddJsonFile("config.json")
			.AddEnvironmentVariables();
		Configuration = configBuilder.Build();
	}

	public void ConfigureServices(IServiceCollection services)
	{
		services.AddMvc();
	}

	public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
	{
		loggerFactory.AddConsole();

		app.UseErrorPage();

		app.UseStaticFiles();

		app.UseMvcWithDefaultRoute();
    }
}

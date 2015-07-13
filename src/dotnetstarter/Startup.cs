using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.StaticFiles;

public class Startup
{

	public void ConfigureServices(IServiceCollection services)
	{
		services.AddMvc();
	}

	public void Configure(IApplicationBuilder app)
	{
		app.UseFileServer(new FileServerOptions()
        {
            EnableDirectoryBrowsing = false,
        });

		app.UseMvc(routes =>
		{
			routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
        });
    }
}

using Microsoft.AspNet.Builder;
using Microsoft.AspNet.StaticFiles;

public class Startup
{
	public void Configure(IApplicationBuilder app)
	{
		app.UseDefaultFiles();
		app.UseStaticFiles();
    }
}

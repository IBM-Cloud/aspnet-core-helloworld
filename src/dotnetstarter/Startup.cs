using Microsoft.AspNet.Builder;

public class Startup
{
	public void Configure(IApplicationBuilder app)
	{
		app.UseDefaultFiles();
		app.UseStaticFiles();
    }
}

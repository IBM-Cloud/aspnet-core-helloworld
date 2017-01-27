using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            var host = new WebHostBuilder()
                        .UseKestrel()
                        .UseConfiguration(config)
                        .UseStartup<Startup>()
                        .Build();
            host.Run();
        }
    }
}

using Microsoft.AspNetCore.Hosting;
using System;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .UseContentRoot(AppContext.BaseDirectory)
                .Build();
            host.Run();
        }
    }
}

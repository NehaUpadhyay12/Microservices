using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .UseConfiguration(config)
                .Build();
            host.Run();
        }
    }
}

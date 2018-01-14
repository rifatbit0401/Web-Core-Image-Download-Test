using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace TestConsoleCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<Startup>()
                .UseIISIntegration()
                .Build();

            host.Run();
        }
    }
}

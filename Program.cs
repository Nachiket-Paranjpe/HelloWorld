using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HelloWorld
{
    public class Program
    {
        private static string url = string.Empty;
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            var config = new ConfigurationBuilder().AddEnvironmentVariables().Build();

            url = config["ASPNETCORE_URLS"] ?? "http://*:8080";
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls(url);
    }
}

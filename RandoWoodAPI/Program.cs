using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using System.IO;

namespace RandoWoodAPI
{
    /// <summary>
    /// RandoWoodAPI Entry class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program entry method
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            if (!Directory.Exists("Logging"))
                Directory.CreateDirectory("Logging");
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("Logging\\serverlog.txt", rollingInterval: RollingInterval.Day).CreateLogger();
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Invokes the startup class
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).UseSerilog();
    }
}

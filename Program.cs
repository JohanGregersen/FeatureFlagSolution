using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FeatureFlagSolution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                    webBuilder.ConfigureAppConfiguration(config =>
                    {
                        var settings = config.Build();

                        //featureToggled my featuretoggle to use either appsettings or AzureAppConfiguration
                        if (Boolean.Parse(settings["FeatureManagement:AzureFeatureTogglingEnable"])) {
                            config.AddAzureAppConfiguration(options =>
                                options.Connect(settings["ConnectionStrings:AppConfiguration"]).UseFeatureFlags());
                        }

                    }).UseStartup<Startup>());
    }
}

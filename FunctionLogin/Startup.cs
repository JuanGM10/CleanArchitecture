using CleanArchitecture.Identity;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.Application;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;


[assembly: FunctionsStartup(typeof(FunctionAccount.Startup))]
namespace FunctionAccount
{
    public class Startup: FunctionsStartup
    {
      
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var configuration = builder.GetContext().Configuration;
            //var configuration = BuildConfiguration(builder.GetContext().ApplicationRootPath);
            builder.Services.AddInfrastructureServices(configuration);
            builder.Services.AddApplicationServices();
            
            builder.Services.ConfigureIdentityServices(configuration);
            
        }
        //private IConfiguration BuildConfiguration(string applicationRootPath)
        //{
        //    var config =
        //        new ConfigurationBuilder()
        //            .SetBasePath(applicationRootPath)
        //            .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
        //            .AddJsonFile("settings.json", optional: true, reloadOnChange: true)
        //            .AddEnvironmentVariables()
        //            .Build();

        //    return config;
        //}



    }
}

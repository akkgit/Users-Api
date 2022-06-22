using DataAccess;
using Microsoft.Extensions.DependencyInjection;
using Services;

namespace DependencyResolver
{
    public static class ServiceConfig
    {
       
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IDataStore, FileStore>();
        }

    }
}

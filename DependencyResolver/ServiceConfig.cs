using System.IO;
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
            services.AddSingleton(GetDataStore());
        }

        private static IDataStore GetDataStore()
        {
            var fullPath = GetFilePath();
            if (!File.Exists(fullPath))
                using (File.Create(fullPath)) ;
            return FileStore.Create(fullPath);
        }

        private static string GetFilePath()
        {
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory());
            return Path.Combine(pathToSave, "Data.json");

        }
        
    }
}

using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using DataAccess.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class FileStore : IDataStore
    {
        private string filePath { get; }
        public FileStore(IConfiguration configuration)
        {
            filePath = configuration["JsonFilePath"];
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            using StreamReader r = new StreamReader(filePath);
            string json = await r.ReadToEndAsync();
            return JsonConvert.DeserializeObject<IEnumerable<User>>(json);
        }

        public async Task SaveUser(User user)
        {
            var users = (List<User>)await GetUsers();
            users = users == null ? new List<User>():users.ToList<User>();
            users.Add(user);
            string userData = JsonConvert.SerializeObject(users);
            File.WriteAllText(filePath, userData);
        }

    }

}

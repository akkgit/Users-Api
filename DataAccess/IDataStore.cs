using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
    public interface IDataStore
    {
        Task<IEnumerable<User>> GetUsers();

        Task SaveUser(User user);
    }
}

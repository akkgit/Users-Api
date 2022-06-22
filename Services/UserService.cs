using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Models;

namespace Services
{
    public class UserService: IUserService
    {
        private IDataStore _dataStore { get; set; }
        public UserService(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _dataStore.GetUsers();
        }

        public async Task SaveUser(User user)
        {
            user.Id = Guid.NewGuid();
            await _dataStore.SaveUser(user);
        }
    }
}

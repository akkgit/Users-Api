using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();

        Task SaveUser(User user);
    }
}

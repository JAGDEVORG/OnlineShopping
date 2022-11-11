using Api.Users.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Users.Services
{
    public interface IUserService
    {
        public Task<List<UserModel>> GetUsers();
    }
}

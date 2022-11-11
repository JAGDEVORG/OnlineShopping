using Api.Users.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Api.Users.Services
{
    public class UserService : IUserService
    {
        public Task<List<UserModel>> GetUsers()
        {
            var responseModel = new ResponseModel();
            List<UserModel> users = new List<UserModel>();
            var u1 = new UserModel
            {
                Id = 1,
                UserName = "Jagdev",
                Email = "jagdev@gmail.com"
            };
            var u2 = new UserModel
            {
                Id = 2,
                UserName = "Rudransh",
                Email = "rudransh@gmail.com"
            };
            var u3 = new UserModel
            {
                Id = 3,
                UserName = "Ankita",
                Email = "Ankita@gmail.com"
            };
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);

            return Task.FromResult(users);
        }
    }
}

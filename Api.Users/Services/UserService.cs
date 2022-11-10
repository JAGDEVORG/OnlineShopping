using Api.Users.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Api.Users.Services
{
    public class UserService : IUserService
    {
        public Task<ResponseModel> ValidateUser(LoginModel loginModel)
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel.IsSuccess = false;
            if (loginModel != null)
            {
                if (loginModel.Email == "admin@admin.com" && loginModel.Password == "admin")
                {
                    responseModel.IsSuccess = true;
                    var getUserDetails = new UserModel
                    {
                        Id = 1,
                        UserName = "Admin"
                    };

                    responseModel.Content = JsonConvert.SerializeObject(getUserDetails);
                }
            }
            return Task.FromResult(responseModel);
        }
    }
}

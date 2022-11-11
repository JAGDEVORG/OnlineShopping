using Api.Users.Models;
using System.Threading.Tasks;

namespace Api.Users.Services
{
    public interface IAuthenticationService
    {
        public Task<ResponseModel> ValidateUser(LoginModel loginModel);
    }
}

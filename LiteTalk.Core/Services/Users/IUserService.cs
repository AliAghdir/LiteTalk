using LiteTalk.Core.ViewModels.Auth;
using LiteTalk.Data.Entities.Users;

namespace LiteTalk.Core.Services.Users
{
    public interface IUserService
    {
        Task<bool> IsUserExist(string userName);
        Task<bool> IsUserExist(long userId);
        Task<bool> RegisterUser(RegisterViewModel registerModel);
        Task<User> LoginUser(LoginViewModel loginModel);
    }
}
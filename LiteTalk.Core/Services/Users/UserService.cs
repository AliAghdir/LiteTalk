using LiteTalk.Core.Services;
using LiteTalk.Core.Services.Users;
using LiteTalk.Data.Context;

namespace CLiteTalk.Core.Services.Users
{
    public class UserService : BaseService, IUserService
    {
        public UserService(LiteTalkContext context) : base(context)
        {
        }
    }
}
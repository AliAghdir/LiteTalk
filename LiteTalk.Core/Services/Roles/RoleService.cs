using LiteTalk.Core.Services;
using LiteTalk.Data.Context;

namespace LiteTalk.Core.Services.Roles
{
    public class RoleService : BaseService, IRoleService
    {
        public RoleService(LiteTalkContext context) : base(context)
        {
        }
    }
}
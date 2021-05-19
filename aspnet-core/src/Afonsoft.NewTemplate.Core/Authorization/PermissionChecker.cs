using Abp.Authorization;
using Afonsoft.NewTemplate.Authorization.Roles;
using Afonsoft.NewTemplate.Authorization.Users;

namespace Afonsoft.NewTemplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

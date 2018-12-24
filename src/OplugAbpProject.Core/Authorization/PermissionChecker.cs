using Abp.Authorization;
using OplugAbpProject.Authorization.Roles;
using OplugAbpProject.Authorization.Users;

namespace OplugAbpProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

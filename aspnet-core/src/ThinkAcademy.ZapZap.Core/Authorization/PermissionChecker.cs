using Abp.Authorization;
using ThinkAcademy.ZapZap.Authorization.Roles;
using ThinkAcademy.ZapZap.Authorization.Users;

namespace ThinkAcademy.ZapZap.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

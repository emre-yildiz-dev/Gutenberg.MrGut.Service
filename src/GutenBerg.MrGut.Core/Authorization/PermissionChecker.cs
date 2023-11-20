using Abp.Authorization;
using GutenBerg.MrGut.Authorization.Roles;
using GutenBerg.MrGut.Authorization.Users;

namespace GutenBerg.MrGut.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

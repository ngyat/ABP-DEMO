using Abp.Authorization;
using Blog.Authorization.Roles;
using Blog.MultiTenancy;
using Blog.Users;

namespace Blog.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

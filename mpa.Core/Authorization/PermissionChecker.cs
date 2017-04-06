using Abp.Authorization;
using mpa.Authorization.Roles;
using mpa.MultiTenancy;
using mpa.Users;

namespace mpa.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

using System.Linq;
using mpa.EntityFramework;
using mpa.MultiTenancy;

namespace mpa.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly mpaDbContext _context;

        public DefaultTenantCreator(mpaDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}

using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using mpa.EntityFramework;

namespace mpa.Migrator
{
    [DependsOn(typeof(mpaDataModule))]
    public class mpaMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<mpaDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
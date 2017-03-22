using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Blog.EntityFramework;

namespace Blog.Migrator
{
    [DependsOn(typeof(BlogDataModule))]
    public class BlogMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<BlogDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
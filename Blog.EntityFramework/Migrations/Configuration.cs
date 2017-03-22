using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using Blog.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Blog.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<Blog.EntityFramework.BlogDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Blog";
        }

        /// <summary>
        /// ����������ݣ�����Ĭ�Ϲ���Ա������
        /// </summary>
        /// <param name="context">��ǰ���ݿ�����������</param>
        protected override void Seed(Blog.EntityFramework.BlogDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}

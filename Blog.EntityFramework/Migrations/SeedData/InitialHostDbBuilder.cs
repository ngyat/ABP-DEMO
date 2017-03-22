using Blog.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Blog.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly BlogDbContext _context;

        public InitialHostDbBuilder(BlogDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

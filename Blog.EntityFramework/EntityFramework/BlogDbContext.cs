using System.Data.Common;
using Abp.Zero.EntityFramework;
using Blog.Authorization.Roles;
using Blog.MultiTenancy;
using Blog.Users;
using System.Data.Entity;
using Blog.Entities;

namespace Blog.EntityFramework
{
    public class BlogDbContext : AbpZeroDbContext<Tenant, Role, User>
    {

        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public virtual IDbSet<TTag> Tags { get; set; }
        public virtual IDbSet<TPort> Ports { get; set; }
        public virtual IDbSet<TPortTag> PortTags { get; set; }
        public virtual IDbSet<TRortReply> RortReply { get; set; }



        public BlogDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in BlogDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of BlogDbContext since ABP automatically handles it.
         */
        public BlogDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public BlogDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}

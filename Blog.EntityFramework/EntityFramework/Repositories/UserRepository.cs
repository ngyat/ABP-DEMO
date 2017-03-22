using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using Blog.Entities;

namespace Blog.EntityFramework.Repositories
{
    public class UserRepository : BlogRepositoryBase<TUser,string>
    {
        public UserRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}

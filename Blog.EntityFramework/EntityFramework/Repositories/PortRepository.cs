using Blog.Entities;
using Blog.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;

namespace Blog.EntityFramework.Repositories
{
    public class PortRepository : BlogRepositoryBase<TPort, string>, IPortRepository
    {
        public PortRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public List<TPort> GetPortsWithUser(long userID)
        {
            throw new NotImplementedException();
        }
    }
}

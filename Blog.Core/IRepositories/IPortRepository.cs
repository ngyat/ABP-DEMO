using Abp.Domain.Repositories;
using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.IRepositories
{
    public interface IPortRepository : IRepository<TPort, string>
    {
        List<TPort> GetPortsWithUser(long userID);
    }
}

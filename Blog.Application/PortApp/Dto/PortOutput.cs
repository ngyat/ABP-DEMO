using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.PortApp.Dto
{
    public class PortOutput
    {
    }
    public class GetPortsOutput
    {
        public string PortID { get; set; }

        public string PortName { get; set; }

        public string UserName { get; set; }
    }
    public class GetAllPortsOutput
    {
        public List<TPort> Ports { get; set; }
    }
}

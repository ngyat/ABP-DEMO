using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.PortApp.Dto
{
    public class PortDto: EntityDto<long>
    {
        public string PortID { get; set; }

        public string PortName { get; set; }

        public string UserID { get; set; }
    }
}

using Abp.Application.Services;
using Blog.PortApp.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Blog.PortApp
{
    public interface IPortAppService : IApplicationService
    {
        GetPortsOutput GetPostWithUser(GetPortInput input);


        [HttpGet]
        GetAllPortsOutput GetAllPorts();


        string GetToken();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.PortApp.Dto;
using Blog.IRepositories;

namespace Blog.PortApp
{
    public class PortAppService : BlogAppServiceBase, IPortAppService
    {
        private readonly IPortRepository _portRepository;
        public PortAppService(IPortRepository portRepository)
        {
            _portRepository = portRepository;
        }

        public GetAllPortsOutput GetAllPorts()
        {
            var ports = _portRepository.GetAll().ToList();
            return new GetAllPortsOutput() { Ports = ports };
        }

        public GetPortsOutput GetPostWithUser(GetPortInput input)
        {
            throw new NotImplementedException();
        }

        public string GetToken()
        {
            return "this is token";
        }
    }
}

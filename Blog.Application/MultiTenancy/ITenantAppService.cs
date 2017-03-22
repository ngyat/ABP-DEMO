using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Blog.MultiTenancy.Dto;

namespace Blog.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}

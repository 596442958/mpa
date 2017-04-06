using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using mpa.MultiTenancy.Dto;

namespace mpa.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}

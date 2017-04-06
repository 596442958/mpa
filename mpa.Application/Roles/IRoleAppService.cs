using System.Threading.Tasks;
using Abp.Application.Services;
using mpa.Roles.Dto;

namespace mpa.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}

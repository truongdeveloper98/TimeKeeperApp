using TimeKeeper.ViewModels.Common;
using TimeKeeper.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Application.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAll();
        Task<ApiResult<bool>> Create(CreateRoleRequest request);
        Task<ApiResult<PagedResult<RoleVm>>> GetRolesPaging(GetRoleRequest request);
    }
}

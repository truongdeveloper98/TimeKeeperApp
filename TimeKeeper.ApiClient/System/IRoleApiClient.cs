using TimeKeeper.ViewModels.Common;
using TimeKeeper.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeKeeper.ApiClient.System
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
        Task<ApiResult<bool>> CreateRole(CreateRoleRequest request);
        Task<ApiResult<PagedResult<RoleVm>>> GetUsersPagings(GetRoleRequest request);
    }
}

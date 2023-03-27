using Learning.Application.Contracts.RoleContract;
using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Users
{
    public interface IRoleRepository: IRepository<long, Role>
    {
        List<GetRolesWithIdViewModel> GetList();
    }
}

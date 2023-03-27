using Learning.Framework.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.Contracts.RoleContract
{
    public interface IRoleApplication
    {
        List<GetRolesWithIdViewModel> List(RequestDto request);
        void Create(RegisterRoleViewModel command);
        void Edit(EditRoleViewModel command);
        GetRolesWithIdViewModel Get(long id);
        void Remove(long id);
        void ChangeStatus(long id);
    }
}

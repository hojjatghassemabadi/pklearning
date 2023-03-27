using Learning.Application.Contracts.GroupContract;
using Learning.Application.Contracts.RoleContract;
using Learning.Domain.Users;
using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Groups
{
    public interface IGroupRepository: IRepository<long, Group>
    {
        List<GetGroupWithIdViewModel> GetList();

    }
}

using Learning.Application.Contracts.RoleContract;
using Learning.Application.Contracts.ScopeContract;
using Learning.Domain.Users;
using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Scopes
{
    public interface IScopeRepository: IRepository<long, Scope>
    {
        List<GetScopeWithIdViewModel> GetList();
    }
}

using Learning.Application.Contracts.GroupContract;
using Learning.Framework.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.Contracts.ScopeContract
{
    public interface IScopeApplication
    {
        List<GetScopeWithIdViewModel> List(RequestDto request);
        void Create(RegisterScopeViewModel command);
        void Edit(EditScopeViewModel command);
        GetScopeWithIdViewModel Get(long id);
        void Remove(long id);
        void ChangeStatus(long id);
    }
}

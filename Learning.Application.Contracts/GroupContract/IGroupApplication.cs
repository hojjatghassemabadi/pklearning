using Learning.Application.Contracts.DegreeContract;
using Learning.Framework.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.Contracts.GroupContract
{
    public interface IGroupApplication
    {
        List<GetGroupWithIdViewModel> List(RequestDto request);
        void Create(RegisterGroupViewModel command);
        void Edit(EditGroupViewModel command);
        GetGroupWithIdViewModel Get(long id);
        void Remove(long id);
        void ChangeStatus(long id);
    }
}

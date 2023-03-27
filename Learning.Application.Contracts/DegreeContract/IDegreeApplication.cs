using Learning.Application.Contracts.RoleContract;
using Learning.Framework.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.Contracts.DegreeContract
{
    public interface IDegreeApplication
    {
        List<GetDegreeWithIdViewModel> List(RequestDto request);
        void Create(RegisterDegreeViewModel command);
        void Edit(EditDegreeViewModel command);
        GetDegreeWithIdViewModel Get(long id);
        void Remove(long id);
        void ChangeStatus(long id);
    }
}

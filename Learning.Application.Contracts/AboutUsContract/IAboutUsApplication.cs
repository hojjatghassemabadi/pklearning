using Learning.Application.Contracts.RoleContract;
using Learning.Framework.Domains;
using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.Contracts.AboutUsContract
{
    public interface IAboutUsApplication
    {
        List<GetAbouUsWithIdViewModel> List(RequestDto request);
        void Create(RegisterAboutUsViewModel command);
        void Edit(EditAboutUsViewModel command);
        GetAbouUsWithIdViewModel Get(long id);
        void Remove(long id);
        void ChangeStatus(long id);
    }
}

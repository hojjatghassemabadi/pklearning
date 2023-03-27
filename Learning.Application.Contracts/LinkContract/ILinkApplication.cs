using Learning.Application.Contracts.AboutUsContract;
using Learning.Framework.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.Contracts.LinkContract
{
    public interface ILinkApplication
    {
        List<GetLinkWithIdViewModel> List(RequestDto request);
        void Create(RegisterLinkViewModel command);
        void Edit(EditLinkViewModel command);
        GetLinkWithIdViewModel Get(long id);
        void Remove(long id);
        void ChangeStatus(long id);
    }
}

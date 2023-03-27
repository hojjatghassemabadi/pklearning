using Learning.Application.Contracts.ScopeContract;
using Learning.Framework.Domains;
using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.ScopeApplications
{
    public class ScopeApplication : IScopeApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        public ScopeApplication()
        {

        }
        public void ChangeStatus(long id)
        {
            throw new NotImplementedException();
        }

        public void Create(RegisterScopeViewModel command)
        {
            throw new NotImplementedException();
        }

        public void Edit(EditScopeViewModel command)
        {
            throw new NotImplementedException();
        }

        public GetScopeWithIdViewModel Get(long id)
        {
            throw new NotImplementedException();
        }

        public List<GetScopeWithIdViewModel> List(RequestDto request)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }
    }
}

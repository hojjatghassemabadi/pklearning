using Learning.Application.Contracts.RoleContract;
using Learning.Application.Contracts.ScopeContract;
using Learning.Domain.Scopes;
using Learning.Framework.Infrastructure;
using Learning.Infrastructure.EFCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Infrastructure.EFCore.Repositories.Scopes
{
    public class ScopeRepository : BaseRepository<long, Scope>, IScopeRepository
    {
        private readonly LearningContext _context;
        public ScopeRepository(LearningContext context) : base(context)
        {
            _context = context;
        }
    

        public List<GetScopeWithIdViewModel> GetList()
        {
            return _context.Scopes.Select(x => new GetScopeWithIdViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Code=x.Code

            }).ToList();
        }
    }
}

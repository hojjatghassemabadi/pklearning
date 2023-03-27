using Learning.Application.Contracts.GroupContract;
using Learning.Application.Contracts.ScopeContract;
using Learning.Domain.Groups;
using Learning.Framework.Infrastructure;
using Learning.Infrastructure.EFCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Infrastructure.EFCore.Repositories.Groups
{
    public class Grouprepository : BaseRepository<long, Group>, IGroupRepository
    {
        private readonly LearningContext _context;
        public Grouprepository(LearningContext context) : base(context)
        {
            _context = context;
        }

        public List<GetGroupWithIdViewModel> GetList()
        {
            return _context.Groups.Select(x => new GetGroupWithIdViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Status=x.Status

            }).ToList();
        }
    }
}

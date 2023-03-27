using Learning.Application.Contracts.DegreeContract;
using Learning.Application.Contracts.ScopeContract;
using Learning.Domain.Degrees;
using Learning.Framework.Infrastructure;
using Learning.Infrastructure.EFCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Infrastructure.EFCore.Repositories.Degrees
{
    public class DegreeRepository : BaseRepository<long, Degree>, IDegreeRepository
    {
        private readonly LearningContext _context;

        public DegreeRepository(LearningContext context) : base(context)
        {
            _context = context;
        }

        public List<GetDegreeWithIdViewModel> GetList()
        {
            return _context.Degrees.Select(x => new GetDegreeWithIdViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Status=x.Status

            }).ToList();
        }
    }
}

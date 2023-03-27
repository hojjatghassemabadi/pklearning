using Learning.Application.Contracts.RoleContract;
using Learning.Domain.Users;
using Learning.Framework.Infrastructure;
using Learning.Infrastructure.EFCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Infrastructure.EFCore.Repositories.Users
{
    public class RoleRepository : BaseRepository<long, Role>, IRoleRepository
    {
        private readonly LearningContext _context;
        public RoleRepository(LearningContext context) : base(context)
        {
            _context = context;
        }

        public List<GetRolesWithIdViewModel> GetList()
        {
            return _context.Roles.Select(x => new GetRolesWithIdViewModel
            {
                Id = x.Id,
                Name = x.Name
               
            }).ToList();
        }
    }
}

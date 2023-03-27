using Learning.Application.Contracts.RoleContract;
using Learning.Application.Contracts.UserContract;
using Learning.Domain.Users;
using Learning.Framework.Domains;
using Learning.Framework.Infrastructure;
using Learning.Framework.Pagination;
using Learning.Infrastructure.EFCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Infrastructure.EFCore.Repositories.Users
{
    public class UserRepository : BaseRepository<long, User>, IUserRepository
    {
        private readonly LearningContext _context;
        public UserRepository(LearningContext context) : base(context)
        {
            _context=context;
        }

        public User GetBy(string username)
        {
            return _context.Users.FirstOrDefault(x => x.UserName.Equals(username));
        }

        public List<UsersViewModel> GetList(RequestDto request)
        {
            int row = 0;
            return (List<UsersViewModel>)_context.Users.Include(x => x.UserInRoles).Select(x => new UsersViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Famil = x.Famil,
                ActiveMobile = x.ActiveMobile,
                Address = x.Address,
                ChangePassword = x.ChangePassword,
                Email = x.Email,
                Status = x.Status,
                UserName = x.UserName,
                Roles = x.UserInRoles.Select(x => new GetRolesWithIdViewModel { Id = x.Id, Name = x.Role.Name }).ToList()
            }).ToList().ToPaged(request.Page,request.PageSize,out row);
        }
    }
}

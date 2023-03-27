using Learning.Domain.Users;
using Learning.Framework.Infrastructure;
using Learning.Infrastructure.EFCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Infrastructure.EFCore.Repositories.Users
{
    public class UserInRoleRepository : BaseRepository<long, User>, IUserInRoleRepository
    {
        private readonly LearningContext _context;
        public UserInRoleRepository(LearningContext context) : base(context)
        {
            _context = context;
        }

        public void Create(UserInRole entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<UserInRole, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public UserInRole GetWithRoleAndUser(long userId, long roleId)
        {
            return _context.UserInRoles.FirstOrDefault(x => x.RoleId == roleId && x.UserId == userId);
        }

        public List<UserInRole> GetWithUser(long userId)
        {
            return _context.UserInRoles.Where(x => x.UserId == userId).ToList();
        }

        public void RemoveAll(long userId, long roleId)
        {
            _context.Remove(GetWithRoleAndUser(userId, roleId));
        }

        UserInRole IRepository<long, UserInRole>.Get(long id)
        {
            throw new NotImplementedException();
        }

        List<UserInRole> IRepository<long, UserInRole>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

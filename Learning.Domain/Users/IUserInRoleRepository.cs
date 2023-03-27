using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Users
{
    public interface IUserInRoleRepository: IRepository<long, UserInRole>
    {
        void RemoveAll(long userId, long roleId);
        List<UserInRole> GetWithUser(long userId);
        UserInRole GetWithRoleAndUser(long userId, long roleId);
    }
}

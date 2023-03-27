using Learning.Application.Contracts.UserContract;
using Learning.Framework.Domains;
using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Users
{
    public interface IUserRepository: IRepository<long, User>
    {
        List<UsersViewModel> GetList(RequestDto request);
        User GetBy(string username);
    }
}

using Learning.Framework.Domains;
using Learning.Framework.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.Contracts.UserContract
{
    public interface IUserApplication
    {
        ResultGetUsers List(RequestDto request);
        void Create(CreateUsersViewModel command);
        EditUserViewModel SignIn(string username, string password);
        void Edit(EditUserViewModel command);
        EditUserViewModel Get(long id);
        void Remove(long id);
        void ChangeStatus(long id);
        JwtAuthResponse Autentication(string username, string password);

    }
}

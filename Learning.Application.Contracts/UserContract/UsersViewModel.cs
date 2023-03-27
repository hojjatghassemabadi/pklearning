using Learning.Application.Contracts.DegreeContract;
using Learning.Application.Contracts.GroupContract;
using Learning.Application.Contracts.RoleContract;
using Learning.Application.Contracts.ScopeContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.Contracts.UserContract
{
    public class UsersViewModel: CreateUsersViewModel
    {
        public long Id { get; set; }
       
    }
}

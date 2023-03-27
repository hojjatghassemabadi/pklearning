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
    public class CreateUsersViewModel
    {
        public string Name { get; set; }
        public string Famil { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int LearningLevel { get; set; }
        public string Pic { get; set; }
        public bool Status { get; set; }
        public bool ActiveMobile { get; set; }
        public bool ChangePassword { get; set; }
        public List<GetRolesWithIdViewModel> Roles { get; set; }
        public List<GetScopeWithIdViewModel> Scopes { get; set; }
        public List<GetGroupWithIdViewModel> Groups { get; set; }
        public List<GetDegreeWithIdViewModel> Degrees { get; set; }
    }
}

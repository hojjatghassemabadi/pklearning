using Learning.Domain.Degrees;
using Learning.Domain.Groups;
using Learning.Domain.Scopes;
using Learning.Framework.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Users
{
    public class User : BaseEntity
    {
        public string Name { get; private set; }
        public string Famil { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Mobile { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
        public LearningLevel LearningLevel { get; private set; }
        public string Pic { get; private set; }
        public bool Status { get; private set; } = true;
        public bool ActiveMobile { get; private set; }
        public bool ChangePassword { get; private set; }
        public ICollection<UserInScope> UserInScopes { get; set; }
        public ICollection<UserInRole> UserInRoles { get; set; }
        public ICollection<UserInGroup> UserInGroups { get; set; }
        public ICollection<UserInDegree> UserInDegrees { get; set; }

        protected User()
        {

        }

        public User(string name, string famil, string userName, string password, string mobile, string address, string email, LearningLevel learningLevel, string pic, bool status, bool activeMobile, bool changePassword)
        {
            Name = name;
            Famil = famil;
            UserName = userName;
            Password = password;
            Mobile = mobile;
            Address = address;
            Email = email;
            LearningLevel = learningLevel;
            Pic = pic;
            Status = status;
            ActiveMobile = activeMobile;
            ChangePassword = changePassword;
        }

        public void EditUser(string name, string famil, string userName, string password, bool status,string mobile,string address,string email,LearningLevel learningLevel,string pic, long editedBy)
        {
            Name = name;
            Famil = famil;
            UserName = userName;
            Password = password;
            Status = status;
            Mobile = mobile;
            Address = address;
            Email = email;
            Pic = pic;
            LearningLevel = learningLevel;
            Edit(editedBy);
        }
        public void ChangeStatus(bool status)
        {
            Status = status;

        }
        public void ChangeUserPassword(bool changePassword)
        {
            ChangePassword = changePassword;
        }
        public void ActiveUserMobile(bool activeMobile)
        {
            ActiveMobile = activeMobile;
        }

    }
}

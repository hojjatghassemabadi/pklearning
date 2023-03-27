using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Users
{
    public class UserInRole
    {
        public long Id { get; private set; }
        public long UserId { get; private set; }
        public virtual User User { get; set; }
        public long RoleId { get; private set; }
        public virtual Role Role { get; set; }

        protected UserInRole()
        {

        }
        public UserInRole(long userId, User user, long roleId, Role role)
        {
            UserId = userId;
            User = user;
            RoleId = roleId;
            Role = role;

        }
    }
}

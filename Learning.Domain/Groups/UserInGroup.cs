using Learning.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Groups
{
    public class UserInGroup
    {
        public long Id { get; private set; }
        public long UserId { get; private set; }
        public virtual User User { get; set; }
        public long GroupId { get; private set; }
        public virtual Group Group { get; set; }

        protected UserInGroup() { }

        public UserInGroup(long id, long userId, User user, long groupId, Group group)
        {
            Id = id;
            UserId = userId;
            User = user;
            GroupId = groupId;
            Group = group;
        }
    }
}

using Learning.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Degrees
{
    public class UserInDegree
    {
        public long Id { get; private set; }
        public long UserId { get; private set; }
        public virtual User User { get; set; }
        public long DegreeId { get; private set; }
        public virtual Degree Degree{ get; set; }

        protected UserInDegree() { }

        public UserInDegree(long id, long userId, User user, long degreeId, Degree degree)
        {
            Id = id;
            UserId = userId;
            User = user;
            DegreeId = degreeId;
            Degree = degree;
        }
    }

}

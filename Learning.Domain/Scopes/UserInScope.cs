using Learning.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Scopes
{
    public class UserInScope
    {
        public long Id { get; private set; }
        public long UserId { get; private set; }
        public virtual User User { get; set; }
        public long ScopeId { get; private set; }
        public virtual Scope Scope { get; set; }

        protected UserInScope(){}

        public UserInScope(long id, long userId, User user, long scopeId, Scope scope)
        {
            Id = id;
            UserId = userId;
            User = user;
            ScopeId = scopeId;
            Scope = scope;
        }
    }
}

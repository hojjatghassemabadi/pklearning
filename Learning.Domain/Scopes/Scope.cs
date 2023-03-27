using Learning.Framework.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Scopes
{
    public class Scope:BaseEntity
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public bool Status { get; private set; }
        public ICollection<UserInScope> UserInScopes { get; set; }

        protected Scope() { }

        public Scope(string name, string code, bool status)
        {
            Name = name;
            Code = code;
            Status = status;
        }
    }
}

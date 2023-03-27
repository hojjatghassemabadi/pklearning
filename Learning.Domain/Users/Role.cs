using Learning.Framework.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Users
{
    public class Role:BaseEntity
    {
        public string Name { get; private set; }
        public bool Status { get; private set; }
        public ICollection<UserInRole> UserInRoles { get; set; }
        protected Role()
        {

        }
        public Role(string name, bool status)
        {
            Name = name;
            Status = status;

        }
        public void EditRole(string name, bool status, long editedBy)
        {
            Name = name;
            Status = status;
            Edit(editedBy);
        }
        public void ChangeStatus(bool status)
        {
            Status = status;

        }
    }
}

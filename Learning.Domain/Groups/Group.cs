using Learning.Domain.Scopes;
using Learning.Framework.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Groups
{
    public class Group:BaseEntity
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public bool Status { get; private set; }
        public ICollection<UserInGroup> UserInGroups { get; set; }
        protected Group() { }

        public Group(string name, bool status)
        {
            Name = name;
            Status = status;
        }
        public void EditGroup(string name, string code, bool status, long editedBy)
        {
            Name = name;
            Code = code;
            Status = status;
            Edit(editedBy);
        }
        public void ChangeStatus(bool status)
        {
            Status = status;

        }
    }
}

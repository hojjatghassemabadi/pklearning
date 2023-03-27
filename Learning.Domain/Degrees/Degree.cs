using Learning.Domain.Groups;
using Learning.Framework.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Degrees
{
    public class Degree:BaseEntity
    {
        public string Name { get; private set; }
        public bool Status { get; private set; }
        public ICollection<UserInDegree> UserInDegrees { get; set; }

        protected Degree() { }

        public Degree(string name, bool status)
        {
            Name = name;
            Status = status;
        }
        public void EditDegree(string name, bool status, long editedBy)
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

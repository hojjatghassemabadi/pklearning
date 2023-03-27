using Learning.Framework.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Learning.Domain.Links
{
    public class Link : BaseEntity
    {
        public string Text { get; private set; }
        public string Address { get; private set; }
        public bool Status { get; private set; }

        protected Link()
        {

        }
        public Link(string text, string address, bool status)
        {
            Text = text;
            Address = address;
            Status = status;
        }
        public void EditLink(string text, string address, bool status, long editedBy)
        {
            Text = text;
            Address = address;
            Status = status;
            Edit(editedBy);
        }
        public void ChangeStatus(bool status)
        {
            Status = status;

        }
    }
}

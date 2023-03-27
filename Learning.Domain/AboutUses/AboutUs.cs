using Learning.Framework.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.AboutUses
{
    public class AboutUs : BaseEntity
    {
        public string Text { get; protected set; }
        public bool Status { get; protected set; }

        protected AboutUs()
        {

        }
        public AboutUs(string text, bool status)
        {
            Text = text;
            Status = status;
        }
        public void EditAboutUs(string text, bool status, long editedBy)
        {
            Text = text;
            Status = status;
            Edit(editedBy);
        }
        public void ChangeStatus(bool status)
        {
            Status = status;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.Contracts.RoleContract
{
    public class GetRolesWithIdViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}

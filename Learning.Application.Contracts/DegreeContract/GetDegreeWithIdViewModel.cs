using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.Contracts.DegreeContract
{
    public class GetDegreeWithIdViewModel: RegisterDegreeViewModel
    {
        public long Id { get; set; }
        
    }
}

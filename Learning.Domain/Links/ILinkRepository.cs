using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Links
{
    public interface ILinkRepository:IRepository<long,Link>
    {
    }
}

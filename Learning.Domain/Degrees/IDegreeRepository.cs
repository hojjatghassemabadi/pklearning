using Learning.Application.Contracts.DegreeContract;
using Learning.Application.Contracts.GroupContract;
using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Domain.Degrees
{
    public interface IDegreeRepository:IRepository<long, Degree>
    {
        List<GetDegreeWithIdViewModel> GetList();

    }
}

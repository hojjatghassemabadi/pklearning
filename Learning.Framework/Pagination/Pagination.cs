﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Framework.Pagination
{
    public static class Pagination
    {
        public static IEnumerable<TSource> ToPaged<TSource>(this IEnumerable<TSource> sources, int page, int pageSize, out int rowCount)
        {
            rowCount = sources.Count();
            return sources.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}

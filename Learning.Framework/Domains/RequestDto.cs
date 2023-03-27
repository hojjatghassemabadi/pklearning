﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Framework.Domains
{
    public class RequestDto
    {
        public string? SearchKey { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 8;
    }
}

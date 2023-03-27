using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Framework.Domains
{
    public class ResultDto
    {
            public bool IsSuccess { get; set; }
            public string? Message { get; set; }
    }
    public class ResultDto<TData>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public TData data;
        public int rowCount;
    }
}

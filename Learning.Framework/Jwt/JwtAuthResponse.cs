﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Framework.Jwt
{
    [Serializable]
    public class JwtAuthResponse
    {
        public string Token { get; set; }
        public string UserName { get; set; }
        public int Expires_in { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace libraryhw
{
    public class systemFailException: Exception
    {
        public systemFailException(string message) : base(message) { }
    }
}
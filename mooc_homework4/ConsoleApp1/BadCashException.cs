using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BadCashException: Exception
    {
        public BadCashException(string message) : base(message) { }
    }

    
}
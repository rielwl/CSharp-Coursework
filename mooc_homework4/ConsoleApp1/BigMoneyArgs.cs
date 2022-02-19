using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BigMoneyArgs
    {
        public event EventHandler BigMoneyEvent;
        public void BigMoneyWithdrawn()
        {
            BigMoneyEvent.Invoke(this, EventArgs.Empty); // sender (where it is coming from), EventArgs.Empty is because we are not passing anything
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class savingsAccount : Account
    {
        public string accntType;
        public double interestRate;
        public double minAmt;
        //定义一个savings account需要考虑利率，有三种savings account，可以看savingPlans.cs
        public savingsAccount(string accntNum, string pwd, double money, string accntType):base(accntNum, pwd, money)
        {
            int ir = (int)Enum.Parse(typeof(savingPlansInterest), accntType);
            this.accntType = accntType;
            this.interestRate = (double)ir / 100;
            this.savings = true;

        }
        public bool checkPlan()
        {
            this.minAmt = (int)Enum.Parse(typeof(savingPlansMin), accntType);
            if(this.money < this.minAmt)
            {
                return false;
            }
            return true;
        }
        public override bool depositMoney(double amtDeposited)
        {
            if (amtDeposited < 0) return false;
            this.money += amtDeposited;
            transactionList.Add(amtDeposited);
            return true;
        }

        public override bool withdrawMoney(double amtWithDrawn)
        {
            if (amtWithDrawn < 0) return false;
            if (this.money - this.minAmt < amtWithDrawn)
            {
                return false;
            }
            this.money -= amtWithDrawn;
            transactionList.Add(-amtWithDrawn);
            return true;
        }
        
    }
}
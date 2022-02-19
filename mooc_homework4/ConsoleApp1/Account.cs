using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Account
    {
        public double money; // current money

        // accntNum and password for the account
        public string accntNum;
        public string pwd;
        public double debt = 0;
        public List<double> transactionList = new List<double>();

        public bool savings = false;
        public Account(string accntNum, string pwd, double money)
        {
            // create
            this.accntNum = accntNum;
            this.pwd = pwd;
            this.money = money;
        }
        // accessing the account balance
        // can set and get
        public double accntBalance
        {
            get { return money;}
            set { money = value; }
        }
        // set and get account accntNum
        public string accntName
        {
            get { return accntNum; }
            set { accntNum = value; }
        }
        // set and get account password
        public string accntPwd
        {
            get { return pwd; }
            set { pwd = value; }
        }

        public bool checkAccount(string accntNum, string pwd)
        {
            return ((accntNum == this.accntNum) && (pwd == this.pwd));
        }
        // 待会儿在savingsAccount override这两个
        // 在depositMoney 加一个算利率的
        // 在withdrawMoney 加一个查this.money的部分
        // 这里设想一个普通的bank account和credit card 一样的道理，可以借钱，所以可以使得它的this.money成为负数
        public virtual bool withdrawMoney(double amtWithDrawn)
        {
            if (amtWithDrawn < 0) return false;
            this.money -= amtWithDrawn;
            if (this.money < 0)
            {
                this.debt = Math.Abs(this.money);
            }
            transactionList.Add(-amtWithDrawn);
            return true;

        }
        public virtual bool depositMoney(double amtDeposited)
        {
            if (amtDeposited < 0) return false;
            if(this.money < 0)
            {
                this.debt -= amtDeposited;
                if (this.debt <= 0) this.debt = 0; // 不再欠债
            }
            this.money += amtDeposited;
            transactionList.Add(amtDeposited);
            return true;
            
        }
        public void printTransactions()
        {
            if(transactionList.Count == 0)
            {
                Console.WriteLine("No deposits or withdrawals so far!");
            }
            foreach(double t in transactionList)
            {
                Console.WriteLine(t);
            }
        }

        
    }
}
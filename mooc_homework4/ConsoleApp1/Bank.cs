using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Bank
    {
        // 这个部分照着老师的思路写
        List<Account> accounts = new List<Account>();
        List<savingsAccount> savingsAccounts = new List<savingsAccount>();
        public Account openAccount(string accntNum, string pwd, double money)
        {
            Account account = new Account(accntNum, pwd, money);
            // add account to the list of accounts for the bank
            accounts.Add(account);
            return account;
        }
        public bool openAccount(string accntNum, string pwd, double money, string accntType)
        {
            savingsAccount savingsAccount = new savingsAccount(accntNum, pwd, money, accntType);
            if (savingsAccount.checkPlan())
            {
                savingsAccounts.Add(savingsAccount);
                return true;
            }
            return false;
        }
        // 查是否是已经存在的account，若是，就直接关了
        public void closeAccount(Account account)
        {

            accounts.Remove(account);
        }
        public void closeAccount(savingsAccount account)
        {
            savingsAccounts.Remove(account);
        }
        
        public Account findAccount(string id, string pwd)
        {
            foreach(Account account in accounts)
            {
                if(account.checkAccount(id, pwd))
                {
                    return account;
                }
            }
            return null;
        }
        public savingsAccount findAccount(string id, string pwd, bool isSavings)
        {
            foreach (savingsAccount account in savingsAccounts)
            {
                if (account.checkAccount(id, pwd))
                {
                    return account;
                }
            }
            return null;
        }
    }
}
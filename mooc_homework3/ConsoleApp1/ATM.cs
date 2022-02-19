using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{
    public class ATM
    {
        Bank bank;
        public ATM(Bank bank)
        {
            this.bank = bank;
        }

        public void Transaction()
        {
            string deposit;
            double amtDeposit;
            bool flag;
            string withdraw;
            double amtWithdraw;
            string newAccntNum;
            string newPwd;
            string savingsType;
            string orgMoney; // original money
            double money;
            Console.WriteLine("Hello, would you like to access an existing account or create a new account today?");
            Console.WriteLine("1: Access an existing account");
            Console.WriteLine("2: Create a new account");
            string process = Console.ReadLine();
            // accessing an existing account
            if (process == "1") {
                Console.WriteLine("Is your bank account a savings account or a normal account?");
                Console.WriteLine("1. Savings Account");
                Console.WriteLine("2. Normal Bank Account");
                string accntSaveNorm = Console.ReadLine();
                // savings account
                if (accntSaveNorm == "1")
                {
                    Console.WriteLine("Please enter your account number");
                    string accntNum = Console.ReadLine();
                    Console.WriteLine("Please enter your password");
                    string pwd = Console.ReadLine();
                    savingsAccount savingsAccnt = bank.findAccount(accntNum, pwd, true);
                    if (savingsAccnt == null)
                    {
                        Console.WriteLine("Card invalid or password incorrect.");
                        Console.WriteLine("Please Try Again");
                        return;
                    }
                    Console.WriteLine("What would you like to do today?");
                    Console.WriteLine("1: display your current balance");
                    Console.WriteLine("2: display your balance next year (after calculating interest)");
                    Console.WriteLine("3: deposit money");
                    Console.WriteLine("4: withdraw money");
                    string op = Console.ReadLine();
                    switch (op)
                    {
                        case "1":
                            Console.WriteLine("Balance: " + savingsAccnt.accntBalance);
                            break;
                        case "2":
                            double nextbalance = savingsAccnt.accntBalance * savingsAccnt.interestRate;
                            Console.WriteLine("Balance: " + nextbalance);
                            Console.WriteLine("Interest Rate: " + savingsAccnt.interestRate);
                            break;
                        case "3":
                            Console.WriteLine("How much money would you like to deposit?");
                            deposit = Console.ReadLine();
                            amtDeposit = double.Parse(deposit);
                            flag = savingsAccnt.depositMoney(amtDeposit);
                            if (flag)
                            {
                                Console.WriteLine("Done!");
                            }
                            else Console.WriteLine("Error! Please enter a valid number");
                            Console.WriteLine("Balance: " + savingsAccnt.accntBalance);
                            break;
                        case "4":
                            Console.WriteLine("How much money would you like to withdraw?");
                            withdraw = Console.ReadLine();
                            amtWithdraw = double.Parse(withdraw);
                            flag = savingsAccnt.withdrawMoney(amtWithdraw);
                            if (flag)
                            {
                                Console.WriteLine("Done!");
                            }
                            else Console.WriteLine("Error! Please ensure that you have enough money to keep your savings account open!");
                            Console.WriteLine("Balance: " + savingsAccnt.accntBalance);
                            break;
                        default:
                            Console.WriteLine("It appears that you've entered an invalid value");
                            Console.WriteLine("Login has timed out! Please relogin");
                            break;
                    }
                }
                // normal account
                // 代码和 savings account 完全相同，只因为一个是savingsAccount一个是Account类型
                else if (accntSaveNorm == "2")
                {
                    Console.WriteLine("Please enter your account number");
                    string accntNum = Console.ReadLine();
                    Console.WriteLine("Please enter your password");
                    string pwd = Console.ReadLine();
                    Account account = bank.findAccount(accntNum, pwd);
                    if (account == null)
                    {
                        Console.WriteLine("Card invalid or password incorrect.");
                        Console.WriteLine("Please Try Again");
                        return;
                    }
                    Console.WriteLine("What would you like to do today?");
                    Console.WriteLine("1: display your current balance");
                    Console.WriteLine("2: display your debt");
                    Console.WriteLine("3: deposit money");
                    Console.WriteLine("4: withdraw money");
                    string op = Console.ReadLine();
                    switch (op)
                    {
                        case "1":
                            Console.WriteLine("Balance: " + account.accntBalance);
                            break;
                        case "2":
                            Console.WriteLine("Debt: " + account.debt);
                            break;
                        case "3":
                            Console.WriteLine("How much money would you like to deposit?");
                            deposit = Console.ReadLine();
                            amtDeposit = double.Parse(deposit);
                            flag = account.depositMoney(amtDeposit);
                            if (flag)
                            {
                                Console.WriteLine("Done!");
                            }
                            else Console.WriteLine("Error! Please enter valid number!");
                            Console.WriteLine("Balance: " + account.accntBalance);
                            break;
                        case "4":
                            Console.WriteLine("How much money would you like to withdraw?");
                            withdraw = Console.ReadLine();
                            amtWithdraw = double.Parse(withdraw);
                            flag = account.withdrawMoney(amtWithdraw);
                            if (flag)
                            {
                                Console.WriteLine("Done!");
                            }
                            else Console.WriteLine("Error! Please enter valid number!");
                            Console.WriteLine("Balance: " + account.accntBalance);
                            Console.WriteLine("Debt: " + account.debt);
                            break;
                        default:
                            Console.WriteLine("It appears that you've entered an invalid value");
                            Console.WriteLine("Login has timed out! Please relogin");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error! Please start again.");
                }
            }
            // create new account
            else if (process == "2")
            {
                Console.WriteLine("What kind of account would you like to create?");
                Console.WriteLine("1: Savings Account");
                Console.WriteLine("2: Normal Bank Account");
                string accntSaveNorm = Console.ReadLine();
                // savings account
                if(accntSaveNorm == "1")
                {
                    Console.WriteLine("Please enter your account number");
                    newAccntNum = Console.ReadLine();
                    Console.WriteLine("Please enter your account password");
                    newPwd = Console.ReadLine();
                    Console.WriteLine("Please enter your initial deposit");
                    orgMoney = Console.ReadLine();
                    money = double.Parse(orgMoney);
                    Console.WriteLine("What kind of savings account would you prefer?");
                    Console.WriteLine("1: Low Cost Low Interest (1% interest rate, minimum 500 in account)");
                    Console.WriteLine("2: Medium Cost Medium Interest (2% interest rate, minimum 1000 in account)");
                    Console.WriteLine("3: High Cost High Interest (3% interest rate, minimum 2000 in account)");
                    savingsType = Console.ReadLine();
                    if(savingsType == "1")
                    {
                        flag = bank.openAccount(newAccntNum, newPwd, money, "lowCost");
                        if (flag) Console.WriteLine("Account opened! Welcome!");
                        else
                        {
                            Console.WriteLine("Error! Please ensure you have enough money in your account to open a savings account");
                            Console.WriteLine("Account creation failed! Restarting process...");
                        }
                    }
                    else if (savingsType == "2")
                    {
                        flag = bank.openAccount(newAccntNum, newPwd, money, "midCost");
                        if (flag) Console.WriteLine("Account opened! Welcome!");
                        else
                        {
                            Console.WriteLine("Error! Please ensure you have enough money in your account to open a savings account");
                            Console.WriteLine("Account creation failed! Restarting process...");
                        }
                    }
                    else if (savingsType == "3")
                    {
                        flag = bank.openAccount(newAccntNum, newPwd, money, "highCost");
                        if (flag) Console.WriteLine("Account opened! Welcome!");
                        else
                        {
                            Console.WriteLine("Error! Please ensure you have enough money in your account to open a savings account");
                            Console.WriteLine("Account creation failed! Restarting process...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error! Please restart process");
                    }
                }
                // normal bank account
                else if(accntSaveNorm == "2")
                {
                    Console.WriteLine("Please enter your account number");
                    newAccntNum = Console.ReadLine();
                    Console.WriteLine("Please enter your account password");
                    newPwd = Console.ReadLine();
                    Console.WriteLine("Please enter your initial deposit");
                    orgMoney = Console.ReadLine();
                    money = double.Parse(orgMoney);
                    bank.openAccount(newAccntNum, newPwd, money);
                    Console.WriteLine("Account opened! Welcome!");
                }
                else
                {
                    Console.WriteLine("Error! Please restart process!");
                }
            }
            else { Console.WriteLine("Error! Please restart"); }
        }
    }
}
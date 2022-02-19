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
        

        // 加了委托 + 用lambda
        public delegate void D(string message);
        public delegate void D2(string msg1, string msg2);
        public delegate void D3(string msg1, string msg2, string msg3);
        public delegate void errD();
        D msg = message => { Console.WriteLine(message); };
        D2 msgTwoLines = (msg1, msg2) => { Console.WriteLine(msg1); Console.WriteLine(msg2); };
        D3 msgThreeLines = (msg1, msg2, msg3) => { Console.WriteLine(msg1); Console.WriteLine(msg2); Console.WriteLine(msg3); };
        errD accntCreateError = () => {Console.WriteLine("Error! Please ensure you have enough money in your account to open a savings account\nAccount creation failed! Restarting process...");};
        errD errorMsg = () => { Console.WriteLine("Error! Please restart!");};

        
        // 为了实现BadCashException
        public void badCashCheck(int x)
        {
            if (x < 1)
            {
                throw new BadCashException("One of the notes you have deposited is a bad note. Rejecting your deposit...");
            }
        }

        // 用于实现事件
        static void BigMoneyFunc()
        {
            BigMoneyArgs bigMoney = new BigMoneyArgs();
            bigMoney.BigMoneyEvent += (s, args) =>
            {
                Console.WriteLine("You are withdrawing a large amount of money");
            };
            bigMoney.BigMoneyWithdrawn();
        }

        public void Transaction()
        {
            double amtDeposit;
            bool flag;
            double amtWithdraw;
            double money;
            // deposit, withdraw, new account number, new password, saving account type, original money
            string deposit, withdraw, newAccntNum, newPwd, savingsType, orgMoney;
            Random rnd = new Random();
            msg("Hello, would you like to access an existing account or create a new account today?");
            msgThreeLines("1: Access an existing account", "2: Create a new account","3: Close an existing account");
            
            string process = Console.ReadLine();
            // accessing an existing account
            if (process == "1") {
                msg("Is your bank account a savings account or a normal account?\n1. Savings Account\n2. Normal Bank Account");
                string accntSaveNorm = Console.ReadLine();
                // savings account
                if (accntSaveNorm == "1")
                {
                    msg("Please enter your account number");
                    string accntNum = Console.ReadLine();
                    msg("Please enter your password");
                    string pwd = Console.ReadLine();
                    savingsAccount savingsAccnt = bank.findAccount(accntNum, pwd, true);
                    if (savingsAccnt == null)
                    {
                        msgTwoLines("Card invalid or password incorrect."," Please try again!");
                        return;
                    }
                    msg("What would you like to do today?");
                    msgTwoLines("1: display your current balance", "2: display your balance next year (after calculating interest)");
                    msgThreeLines("3: deposit money", "4: withdraw money", "5: display transactions");
                    string op = Console.ReadLine();
                    switch (op)
                    {
                        // display current balance
                        case "1":
                            msg("Balance: " + savingsAccnt.accntBalance);
                            break;
                        // display balance next year (after calculating interest)
                        case "2":
                            double nextbalance = savingsAccnt.accntBalance * savingsAccnt.interestRate;
                            msgTwoLines("Balance: " + nextbalance, "Interest Rate: " + savingsAccnt.interestRate);
                            break;
                        // deposit money
                        case "3":
                            msg("How much money would you like to deposit?");
                            deposit = Console.ReadLine();
                            amtDeposit = double.Parse(deposit);
                            try
                            {
                                badCashCheck(rnd.Next(3));
                            }
                            catch (BadCashException e)
                            {
                                Console.WriteLine(e.Message);
                                msg("Balance: " + savingsAccnt.accntBalance);
                                break;
                            }
                            flag = savingsAccnt.depositMoney(amtDeposit);
                            if (flag)
                            {
                                msg("Done!");
                            }
                            else errorMsg();
                            break;
                        // withdraw money
                        case "4":
                            msg("How much money would you like to withdraw?");
                            withdraw = Console.ReadLine();
                            amtWithdraw = double.Parse(withdraw);
                            if (amtWithdraw > 10000)
                            {
                                BigMoneyFunc();
                            }
                            flag = savingsAccnt.withdrawMoney(amtWithdraw);
                            if (flag)
                            {
                                msg("Done!");
                            }
                            else msg("Error! Please ensure that you have enough money to keep your savings account open!");
                            msg("Balance: " + savingsAccnt.accntBalance);
                            break;
                        // print transactions
                        case "5":
                            msg("Transactions for this account (Negative indicates a withdrawal, positive indicates a deposit):");
                            savingsAccnt.printTransactions();
                            break;
                        // error message
                        default:
                            errorMsg();
                            break;
                    }
                }
                // normal account
                // 代码和 savings account 完全相同，只因为一个是savingsAccount一个是Account类型
                else if (accntSaveNorm == "2")
                {
                    msg("Please enter your account number");
                    string accntNum = Console.ReadLine();
                    msg("Please enter your password");
                    string pwd = Console.ReadLine();
                    Account account = bank.findAccount(accntNum, pwd);
                    if (account == null)
                    {
                        errorMsg();
                        return;
                    }
                    msg("What would you like to do today?");
                    msgTwoLines("1: display your current balance", "2: display your debt");
                    msgThreeLines("3: deposit money","4: withdraw money", "5: display transactions");
                    string op = Console.ReadLine();
                    switch (op)
                    {
                        // display current balance
                        case "1":
                            msg("Balance: " + account.accntBalance);
                            break;
                        // display debt
                        case "2":
                            msg("Debt: " + account.debt);
                            break;
                        // deposit money
                        case "3":
                            msg("How much money would you like to deposit?");
                            deposit = Console.ReadLine();
                            amtDeposit = double.Parse(deposit);
                            // 加 BadCashException，给定一个random的数，范围：0-2，只要是小于1就抛出badcash，不让你deposit
                            try
                            {
                                badCashCheck(rnd.Next(3));
                            }
                            catch(BadCashException e)
                            {
                                Console.WriteLine(e.Message);
                                msg("Balance: " + account.accntBalance);
                                break;
                            }
                            flag = account.depositMoney(amtDeposit);

                            if (flag)
                            {
                                msg("Done!");
                            }
                            else errorMsg();
                            msg("Balance: " + account.accntBalance);
                            break;
                        // withdraw money
                        case "4":
                            msg("How much money would you like to withdraw?");
                            withdraw = Console.ReadLine();
                            amtWithdraw = double.Parse(withdraw);
                            if (amtWithdraw > 10000)
                            {
                                BigMoneyFunc();
                            }
                            flag = account.withdrawMoney(amtWithdraw);
                            if (flag)
                            {
                                msg("Done!");
                            }
                            else errorMsg();
                            msgTwoLines("Balance: " + account.accntBalance, "Debt: " + account.debt);
                            break;
                        // print transactions
                        case "5":
                            msg("Transactions for this account (Negative indicates a withdrawal, positive indicates a deposit):");
                            account.printTransactions();
                            break;
                        // error
                        default:
                            errorMsg();
                            break;
                    }
                }
                else
                {
                    errorMsg();
                }
            }
            // create new account
            else if (process == "2")
            {
                msg("What kind of account would you like to create?\n1: Savings Account\n2: Normal Bank Account");
                string accntSaveNorm = Console.ReadLine();
                // savings account
                if(accntSaveNorm == "1")
                {
                    msg("Please enter your account number");
                    newAccntNum = Console.ReadLine();
                    msg("Please enter your account password");
                    newPwd = Console.ReadLine();
                    msg("Please enter your initial deposit");
                    orgMoney = Console.ReadLine();
                    money = double.Parse(orgMoney);
                    msg("What kind of savings account would you prefer?");
                    msgThreeLines("1: Low Cost, Low Interest (1% interest rate, minimum 500 in account)","2: Medium Cost, Medium Interest (2% interest rate, minimum 1000 in account)","3: High Cost, High Interest (3% interest rate, minimum 2000 in account)");
                    savingsType = Console.ReadLine();
                    // Low Cost, Low Interest
                    if(savingsType == "1")
                    {
                        flag = bank.openAccount(newAccntNum, newPwd, money, "lowCost");
                        if (flag) msg("Account opened! Welcome!");
                        else
                        {
                            accntCreateError();
                        }
                    }
                    // Medium Cost, Medium Interest
                    else if (savingsType == "2")
                    {
                        flag = bank.openAccount(newAccntNum, newPwd, money, "midCost");
                        if (flag) msg("Account opened! Welcome!");
                        else
                        {
                            accntCreateError();
                        }
                    }
                    //High Cost, High Interest
                    else if (savingsType == "3")
                    {
                        flag = bank.openAccount(newAccntNum, newPwd, money, "highCost");
                        if (flag) msg("Account opened! Welcome!");
                        else
                        {
                            accntCreateError();
                        }
                    }
                    else
                    {
                        errorMsg();
                    }
                }
                // normal bank account
                else if(accntSaveNorm == "2")
                {
                    msg("Please enter your account number");
                    newAccntNum = Console.ReadLine();
                    msg("Please enter your account password");
                    newPwd = Console.ReadLine();
                    msg("Please enter your initial deposit");
                    orgMoney = Console.ReadLine();
                    money = double.Parse(orgMoney);
                    bank.openAccount(newAccntNum, newPwd, money);
                    msg("Account opened! Welcome!");
                }
                else
                {
                    errorMsg();
                }
            }
            else if(process == "3")
            {
                msg("Is your bank account a savings account or a normal account?\n1. Savings Account\n2. Normal Bank Account");
                string accntSaveNorm = Console.ReadLine();
                if(accntSaveNorm == "1")
                {
                    msg("Please enter your account number");
                    string accntNum = Console.ReadLine();
                    msg("Please enter your password");
                    string pwd = Console.ReadLine();
                    savingsAccount savingsAccnt = bank.findAccount(accntNum, pwd, true);
                    if (savingsAccnt == null)
                    {
                        msgTwoLines("Card invalid or password incorrect.","Please try again!");
                        return;
                    }
                    bank.closeAccount(savingsAccnt);
                }
            }

            else { errorMsg(); }
        }
    }
}
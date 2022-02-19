using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            ATM atm = new ATM(bank);
            bank.openAccount("1234", "1234", 100);
            bank.openAccount("4321", "4321", 500);
            bank.openAccount("123", "123", 1000, "lowCost");
            bank.openAccount("321", "321", 2000, "midCost");
            // just run the transaction 5 times (at max 5 transactions, including failed ones)
            for (int i = 0; i < 5; i++) {
                atm.Transaction();
                Console.WriteLine("Transaction completed!");
            }
        }
    }
}

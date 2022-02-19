using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // changing the background and foreground color
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear(); // 需要clear才能实现，不然不会把整个窗口变成白色
            Bank bank = new Bank();
            ATM atm = new ATM(bank);
            bank.openAccount("1234", "1234", 100);
            bank.openAccount("4321", "4321", 500);
            bank.openAccount("123", "123", 1000, "lowCost");
            bank.openAccount("321", "321", 2000, "midCost");
            ConsoleKeyInfo conKey;
            Console.WriteLine("To leave the ATM, press the escape (Esc) key when you see 'Transaction completed!'");
            do
            {
                atm.Transaction();
                Console.WriteLine("Transaction completed!");
                conKey = Console.ReadKey();
            }
            while (conKey.Key != ConsoleKey.Escape);
            
        }
    }
}

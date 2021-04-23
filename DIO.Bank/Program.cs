using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.Name = "Ricardo";
            Console.WriteLine(myAccount);
            Console.WriteLine("Hello World!");
        }
    }
}

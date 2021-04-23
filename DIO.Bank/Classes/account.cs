using System;
namespace DIO.Bank
{
    // Attributes
    public class Account
    {
        private AccountType AccountType { get; set; }
        private double Balance { get; set; }
        private double Credit { get; set; }
        private string Name { get; set; }
    }
    // Methods
    public Account(AccountType accountType, double balance, double credit, string name)
    {
        this.AccountType = accountType;
        this.Balance = balance;
        this.Credit = credit;
        this.Name = name;
    }
    public bool Withdraw(double withdrawAmount)
    {
        if (this.Balance - withdrawAmount < (this.Credit * -1))
        {
            Console.WriteLine("Insuficient Balance");
            return false;
        }
    }
}
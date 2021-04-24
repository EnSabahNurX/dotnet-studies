using System;

namespace DIO.Bank
{
    public class Account
    {
        // Attributes
        private AccountType AccountType { get; set; }
        private double Balance { get; set; }
        private double Credit { get; set; }
        private string Name { get; set; }
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
            // Validating balance
            if (this.Balance - withdrawAmount < (this.Credit * -1))
            {
                Console.WriteLine("Insuficient Balance!");
                return false;
            }
            this.Balance -= withdrawAmount;
            Console.WriteLine("The current balance of {0} is {1}", this.Name, this.Balance);
            return true;
        }

        public void Deposit(double depositAmount)
        {
            this.Balance += depositAmount;
            Console.WriteLine("The current balance of {0} is {1}", this.Name, this.Balance);
        }
        public void Transfer(double transferAmount, Account targetAccount)
        {
            if (this.Withdraw(transferAmount))
            {
                targetAccount.Deposit(transferAmount);
                Console.WriteLine("Transaction was successfull!");
            }
            else
            {
                Console.WriteLine("Sorry, not enough balance!");
            }
        }
        public override string ToString()
        {
            string display = "";
            display += "AccountType " + this.AccountType + " | ";
            display += "Name " + this.Name + " | ";
            display += "Balance " + this.Balance + " | ";
            display += "Credit " + this.Credit;
            return display;
        }
    }
}
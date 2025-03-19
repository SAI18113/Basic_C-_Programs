using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class BankAccount
    {
        // Private fields (encapsulated data)
        private string accountNumber;
        private decimal balance;

        // Constructor
        public BankAccount(string accountNumber, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        // Public property to access the account number (read-only)
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // Public property to access and modify the balance (with validation)
        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; } //private set. only this class can change the balance.
        }

        // Public method to deposit money
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount; //uses the private setter.
                Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Public method to withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount; //uses the private setter.
                Console.WriteLine($"Withdrawn {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }

        //Private method to do some internal calculation
        private decimal calculateInterest()
        {
            return Balance * 0.01m;
        }

        //public method that uses private method.
        public void addInterest()
        {
            decimal interest = calculateInterest();
            Deposit(interest);
            Console.WriteLine($"Interest added: {interest:C}. New balance: {Balance:C}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("123456789", 1000.00m);

            // Accessing properties and methods
            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            Console.WriteLine($"Current Balance: {myAccount.Balance:C}"); //formats as currency

            myAccount.Deposit(500.00m);
            myAccount.Withdraw(200.00m);
            myAccount.Withdraw(2000.00m); //Attempt to overdraw

            myAccount. addInterest();
        }
    }
}

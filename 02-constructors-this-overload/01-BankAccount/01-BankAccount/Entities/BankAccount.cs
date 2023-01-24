using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BankAccount.Entities
{
    internal class BankAccount
    {
        public int Id { get; set; }
        public string Name { get; protected set; }
        public double Balance { get; protected set; }

        public BankAccount(int id, string name, double initialDeposit)
        {
            Id = id;
            Name = name;
            Balance = initialDeposit;
        }

        public BankAccount(int id, string name)
        {
            Id = id;
            Name = name;
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            return;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
            Console.WriteLine("Your withdraw has costed you $5");
            Balance -= 5;
            return;
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Owner: " + Name + ", Balance: $" + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

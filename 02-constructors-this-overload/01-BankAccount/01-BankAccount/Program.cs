using _01_BankAccount.Entities;
using System.Globalization;

namespace _01_BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account;
            Console.Write("Please enter user id: ");
            int id = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Please enter user name: ");
            string name = Console.ReadLine();
            Console.Write("Do you want to make a initial deposit? (y/n): ");
            char option = char.Parse(Console.ReadLine());

            if (option == 'Y' || option == 'y')
            {
                Console.Write("Please write your initial deposit: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new BankAccount(id, name, initialDeposit);     
            }
            else
            {
                account = new BankAccount(id, name);
            }

            // Data
            Console.WriteLine();
            Console.WriteLine("Account data:");
            Console.WriteLine(account);

            // Deposit
            Console.WriteLine();
            Console.Write("Enter the amount for deposit: ");
            double depositAmount = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            account.Deposit(depositAmount);

            Console.WriteLine();
            Console.WriteLine("Updated account data:");
            Console.WriteLine(account);

            // Withdraw
            Console.WriteLine();
            Console.Write("Enter the amount to withdraw: ");
            double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(withdrawAmount);

            Console.WriteLine();
            Console.WriteLine("Updated account data:");
            Console.WriteLine(account);
        }
    }
}
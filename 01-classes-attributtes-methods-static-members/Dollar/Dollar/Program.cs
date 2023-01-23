using Dollar.Entities;
using System.Globalization;

namespace Dollar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the Dollar cotation? ");
            Rate.DollarRealRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How much dollar do you want to buy? ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Value to be payed (in Real): ");
            Console.WriteLine(Rate.TotalValue(amount).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
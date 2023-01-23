using _05_Worker.Entities;
using System.Globalization;

namespace _05_Worker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker= new Worker();

            Console.Write("Name: ");
            worker.Name = Console.ReadLine();
            Console.Write("Gross Salary: ");
            worker.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Taxes: ");
            worker.Taxes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Worker: " + worker.Name + ", $ " + worker.NetSalary());
            Console.Write("Write the percentage in which you want to increment the worker's salary: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            worker.IncrementSalary(percentage);
            Console.WriteLine("Worker: " + worker.Name + ", $ " + worker.NetSalary());
        }
    }
}
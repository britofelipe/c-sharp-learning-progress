using System;
using System.ComponentModel;
using System.Globalization;

namespace _03_MediumSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1, worker2;
            worker1 = new Worker();
            worker2 = new Worker();

            // First Worker
            Console.WriteLine("Enter the first worker name: ");
            worker1.name = Console.ReadLine();

            Console.WriteLine("Enter the first worker salary: ");
            worker1.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Second Worker
            Console.WriteLine("Enter the first worker name: ");
            worker2.name = Console.ReadLine();

            Console.WriteLine("Enter the first worker salary: ");
            worker2.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Worker 1: " + worker1.name + ", " + worker1.salary.ToString("F2") + "$ (monthly)");
            Console.WriteLine("Worker 2: " + worker2.name + ", " + worker2.salary.ToString("F2") + "$ (monthly)");

            Console.WriteLine("Mean salary: " + ((worker1.salary + worker2.salary)/2) + "$");
        }
    }d
}
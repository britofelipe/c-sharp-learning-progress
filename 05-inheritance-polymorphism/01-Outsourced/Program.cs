using _01_Outsourced.Entities;
using System.Globalization;

namespace _01_Outsourced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");

                Console.Write("Outsourced (y/n)? ");
                char outsourcedOption = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourcedOption == 'y')
                {
                    Console.Write("Aditional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new Outsourced(name, hours, valuePerHour, additionalCharge));
                }
                else if (outsourcedOption == 'n')
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                    throw new ArgumentException("Invalid input. Expected 'y' or 'n'.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
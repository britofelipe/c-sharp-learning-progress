using _02_Lists.Entities;
using System.Globalization;

namespace _02_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Employee #" + i);

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int searchedId = int.Parse(Console.ReadLine());

            Employee selectedEmployee = employees.Find(x => x.Id == searchedId);

            if(selectedEmployee != null)
            {
                Console.Write("Enter the percentage (%): ");
                double percentage = double.Parse(Console.ReadLine());

                selectedEmployee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("The selected Id doesn't exist!");
            }

            // Printing
            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();
        }
    }
}
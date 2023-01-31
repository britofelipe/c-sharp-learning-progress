using WorkerContracts.Entities.Enums;
using WorkerContracts.Entities;
using System.Globalization;

namespace WorkerContracts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Department
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();

            // WORKER DATA ------------------------------------
            
            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department= new Department(departmentName);

            Worker worker= new Worker(name, workerLevel, baseSalary, department);

            // CONTRACTS ------------_------------------------

            Console.Write("How many contracts to this worker? ");
            int numberOfContracts = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfContracts; i++)
            {
                Console.WriteLine("Enter #" + i + " contract data");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter the month and year to calculate income (MM/YYYY): ");
            string monthAndYearEntry = Console.ReadLine();
            int month = int.Parse(monthAndYearEntry.Substring(0, 2));
            int year = int.Parse(monthAndYearEntry.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for: " + monthAndYearEntry + ": $" + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
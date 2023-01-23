using _06_Student.Entities;
using System.Globalization;

namespace _06_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Student's name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Write student's three grades: ");
            student.Grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("FINAL GRADE: " + student.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(student.FinalStatus());


        }
    }
}
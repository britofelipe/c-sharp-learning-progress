using System;
using System.Globalization;

namespace _02_OldestPerson
{
    class OldestPerson
    {
        static void Main(string[] args)
        {
            Person person1, person2;
            person1 = new Person();
            person2 = new Person();

            // First Person
            Console.WriteLine("Enter the first person name: ");
            person1.name = Console.ReadLine();

            Console.WriteLine("Enter the first person age: ");
            person1.age = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Second Person
            Console.WriteLine("Enter the first person name: ");
            person2.name = Console.ReadLine();

            Console.WriteLine("Enter the first person age: ");
            person2.age = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Person 1: " + person1.name + ", " + person1.age.ToString() + " years old");
            Console.WriteLine("Person 2: " + person2.name + ", " + person2.age.ToString() + " years old");

            if(person1.age > person2.age)
            {
                Console.WriteLine("Oldest Person: " + person1.name);
            } 
            else
            {
                Console.WriteLine("Oldest Person: " + person2.name);
            }
            

        }
    }
}
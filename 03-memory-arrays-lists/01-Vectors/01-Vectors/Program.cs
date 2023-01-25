using _01_Vectors.Entities;
using System.Globalization;

namespace _01_Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the total number of rooms: ");
            int numberOfTotalRooms = int.Parse(Console.ReadLine());

            Tenant[] rooms = new Tenant[numberOfTotalRooms];

            Console.Write("How many rooms will be rented: ");
            int rentedRooms = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rentedRooms; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Rent #" + i);

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                rooms[roomNumber - 1] = new Tenant(name, email, roomNumber);
            }

            // Printing
            Console.WriteLine();
            Console.WriteLine("Rented rooms: ");
            for (int i = 0; i < numberOfTotalRooms; i++) { 
                if (rooms[i] != null)
                {
                    Console.WriteLine(rooms[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
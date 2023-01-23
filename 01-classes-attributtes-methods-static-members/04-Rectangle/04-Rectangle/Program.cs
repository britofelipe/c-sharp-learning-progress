using _04_Rectangle.Entities;
using System.Globalization;

namespace _04_Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            Console.WriteLine("Enter the width and the height of the rectangle:");
            r.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETER: " + r.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
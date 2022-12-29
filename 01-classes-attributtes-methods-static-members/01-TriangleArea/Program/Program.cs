using Program;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Not using object orientation
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Enter the X Triangle measures: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the Y Triangle measures: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Area of the Triangle X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area of the Triangle Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Largest area: Triangle X");
            }
            else
            {
                Console.WriteLine("Largest area: Triangle Y");
            }

            // Using object orientation
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Enter the X Triangle measures: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the Y Triangle measures: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            x.area = x.Area();
            y.area = y.Area();

            Console.WriteLine("Area of the Triangle X: " + x.area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area of the Triangle Y: " + y.area.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Largest area: Triangle X");
            }
            else
            {
                Console.WriteLine("Largest area: Triangle Y");
            }

        }
    }
}
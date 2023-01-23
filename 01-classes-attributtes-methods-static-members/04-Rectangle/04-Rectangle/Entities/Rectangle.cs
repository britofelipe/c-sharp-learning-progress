using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Rectangle.Entities
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area ()
        {
            return (Width * Height);
        }

        public double Perimeter ()
        {
            return 2*(Width + Height);
        }

        public double Diagonal ()
        {
            return Math.Sqrt(Width*Width + Height*Height);
        }
    }
}

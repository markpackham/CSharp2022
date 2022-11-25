using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphShape
{
    class Rectangle : Shape
    {

        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has an Length of {Length}");
            Console.WriteLine($"It has an Width of {Width}");
        }
    }
}

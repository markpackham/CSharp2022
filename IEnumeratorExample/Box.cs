using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorExample
{
    internal class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        public Box():this(1,1,1) { }

        public Box(double length, double width, double breadth)
        {
            Length = length;
            Width = width;
            Breadth = breadth;
        }

        // add two boxes together
        // You can overload operators with +, -, *, /, %, !, ==, !=, >, <, >=, <=, ++ and --
        public static Box operator +(Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth,
            };
            return box;
        }

        public static Box operator -(Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth,
            };
            return box;
        }

        public static bool operator ==(Box box1, Box box2)
        {
            
            if((box1.Length == box2.Length) && 
                (box1.Width == box2.Width) && 
                (box1.Breadth == box2.Breadth))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Box box1, Box box2)
        {

            if ((box1.Length != box2.Length) ||
                (box1.Width != box2.Width) ||
                (box1.Breadth != box2.Breadth))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // customize the string output
        public override string ToString()
        {
            return String.Format("Box with height: {0} Width: {1} and Breadth {2}", Length, Width, Breadth);
        }

        // convert from a box into another data type eg Box to int
        public static explicit operator int(Box box)
        {
            return (int)(box.Length + box.Width + box.Breadth) / 3;
        }

        // convert from int into Box
        public static implicit operator Box(int i)
        {
            return new Box(i,i,i);
        }


    }
}

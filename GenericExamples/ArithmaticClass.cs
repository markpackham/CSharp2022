using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExamples
{
    internal class ArithmaticClass
    {
        // A delegate is a type that represents references to methods with a particular parameter list and return type.
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/

        public delegate void Arithmatic(double num1, double num2);

        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
    }
}

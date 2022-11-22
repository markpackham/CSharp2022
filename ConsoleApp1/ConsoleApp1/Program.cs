using System;

namespace ConsoleApp1
{
    public class Program
    {
        // --- Functions --- //

        static double DoDivision(double x, double y)
        {
            if(y == 0)
            {
                throw new System.DivideByZeroException();
            }

            return x / y;
        }

        // --- End of Functions --- //

        static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}", DoDivision(num1,num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You must not divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Oh dear something went wrong but I'm clueless");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("A 'finally' will always run, handy for cleanups");
            }
        }
    }
}
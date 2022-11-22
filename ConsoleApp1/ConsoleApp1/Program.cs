using System;

namespace ConsoleApp1
{
    public class Program
    {


        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1,6);
            int numberGuessed = 0;
            Console.WriteLine("Random Num : ", secretNumber);

            do
            {
                Console.WriteLine("Enter a number between 1 and 5");
                numberGuessed = Convert.ToInt32(Console.ReadLine());
            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed it correctly, it was {0}!", numberGuessed);

        }
    }
}
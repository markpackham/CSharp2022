using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string randString = "This is a string";
            Console.WriteLine("String length :{0}", randString.Length);
            Console.WriteLine("String Contains is :{0}", randString.Contains("is"));
            Console.WriteLine("Index of 'is' is :{0}", randString.IndexOf("is"));
            Console.WriteLine("Remove String: {0}", randString.Remove(10,6));
            Console.WriteLine("Insert String :{0}", randString.Insert(10,"short "));
            Console.WriteLine("Replace string :{0}", randString.Replace("string","twine"));

        }
    }
}
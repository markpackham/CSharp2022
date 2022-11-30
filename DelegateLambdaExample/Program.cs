namespace DelegateLambdaExample
{

    class Program
    {
        // Delegate that is assigned a Lambda function
        delegate double doubleIt(double val);

        static void Main(string[] args)
        {
            // Lambda example
            doubleIt dblIt = x => x * 2;
            Console.WriteLine($"5 * 2 = {dblIt(5)}");

            List<int> numList = new List<int> { 1,2,3,4,5,6,7,8};
            // Lambda for only even numbers
            var evenList = numList.Where(a => a % 2 == 0).ToList();
            Console.WriteLine("Even numbers");
            foreach(var j in evenList)
            {
                Console.WriteLine(j);
            }
        }

    }

}
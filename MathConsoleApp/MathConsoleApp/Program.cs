using System;

namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathFunctions mathFunctions = new MathFunctions();
            int sum = mathFunctions.sumValues(10, 20);
            Console.WriteLine("The sum of 10 and 20 is: " + sum);

            int difference = mathFunctions.subtract(20, 10);
            Console.WriteLine("The difference between of 20 and 10 is: " + difference);

            Console.ReadKey();
        }
    }
}

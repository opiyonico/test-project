using System;


namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathFunctions mathFunctions = new MathFunctions();
            int sum = mathFunctions.sumValues(10, 20);
            Console.WriteLine(sum);

            int difference = mathFunctions.subtract(20, 10);
            Console.WriteLine(difference);

            int multiply = mathFunctions.multiply(5, 10);
            Console.WriteLine(multiply);

            Console.ReadKey();
        }
    }
}

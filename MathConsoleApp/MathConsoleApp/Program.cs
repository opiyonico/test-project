using System;


namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathFunctions addFunction = new MathFunctions();
            int value = addFunction.sumValues(10, 20);
            Console.WriteLine(value);
        }
    }
}

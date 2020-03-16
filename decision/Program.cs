using System;

namespace decision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number: ");
            int number = Int32.Parse(Console.ReadLine());

            if (number > 0) Console.WriteLine("Number is positive");
            else if (number == 0) Console.WriteLine("Number is zero");
            else Console.WriteLine("Number is negative");

            Console.ReadKey();

        }
    }
}

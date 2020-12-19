using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputKey = Console.ReadLine();
            Console.WriteLine(FizzBuzz.GetOutputString(int.Parse(inputKey)));
            Console.ReadKey();

        }
    }
}

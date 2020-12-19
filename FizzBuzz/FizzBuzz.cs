using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string GetOutputString(int inputNumber)
        {
            if ((inputNumber % 3) == 0 && (inputNumber % 5) == 0)
                return "FizzBuzz";
            if ((inputNumber % 3) == 0)
                return "Fizz";
            if ((inputNumber % 5) == 0)
                return "Buzz";
            return inputNumber.ToString();
        }
    }
}

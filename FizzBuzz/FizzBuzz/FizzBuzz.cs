using System;

namespace FizzBuzz
{
    public static class FizzBuzzClass
    {
        public static string GetAnswer(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (i % 3 == 0)
            {
                return "Fizz";
            }
            if (i % 5 == 0)
            {
                return "Buzz";
            }
            return i.ToString();
        }
    }
}

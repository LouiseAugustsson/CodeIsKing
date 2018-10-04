using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                string output = FizzBuzzClass.GetAnswer(i);
                Console.WriteLine(output);
            }


        }
    }
}

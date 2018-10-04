using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzzTests
{
    public class UnitTest1
    {
        [Fact]

        public void Return_Fizz_If_3_modulus_0()
        {
            string a = FizzBuzz.FizzBuzzClass.GetAnswer(3);
            Assert.Equal("Fizz", a);
        }
        [Fact]

        public void Return_Buzz_If_5_modulus_0()
        {
            string a = FizzBuzz.FizzBuzzClass.GetAnswer(5);
            Assert.Equal("Buzz", a);
        }
        [Fact]
        public void Return_FizzBuzz_If_3_And_5_modulus_0()
        {
            string a = FizzBuzz.FizzBuzzClass.GetAnswer(15);
            Assert.Equal("FizzBuzz", a);
        }
        [Fact]
        public void Return_number_If_Not_3_Or_5_modulus_0()
        {
            string a = FizzBuzz.FizzBuzzClass.GetAnswer(7);
            Assert.Equal(7.ToString(), a);
        }
    }
}

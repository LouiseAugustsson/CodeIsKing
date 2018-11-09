using System;
using Xunit;
using StringReader;

namespace StringReaderTests
{
    public class NiceStringReaderTests
    {
        NiceStringDecider stringDecider;
        public NiceStringReaderTests()
        {
            stringDecider = new NiceStringDecider();
        }
        [Theory]
        [InlineData("aei", "aoueiy", true)]
        [InlineData("xazegov", "aoueiy", true)]
        [InlineData("aeiouaeiouaeiou", "aoueiy", true)]
        [InlineData("kajskwa", "aoueiy", false)]
        public void ReturnTrueIfContainsThreeVocals(string input, string letters, bool expectedOutput)
        {
            bool output = stringDecider.CheckIfAtLeastThreeLettersFromList(input, letters);
            Assert.Equal(expectedOutput, output);
        }
        [Theory]
        [InlineData("abcdde", true)]
        [InlineData("abcde", false)]
        [InlineData("aabbccdd", true)]
        public void ReturnTrueIfContainsTwoLettersInARow(string input, bool expectedOutput)
        {
            bool output = stringDecider.CheckIfTwoLettersInARow(input);
            Assert.Equal(expectedOutput, output);
        }
        [Theory]
        [InlineData("hejehej", new string[] { "cd", "pq", "xy" }, true)]
        [InlineData("cdbjkc", new string[] { "cd", "pq", "xy" }, false)]
        public void ReturnTrueIfNotContaingForbiddenCombinations(string input, string[] forbidden, bool expectedOutput)
        {
            bool output = stringDecider.CheckIfNotContainsCombinationFromList(input, forbidden);
            Assert.Equal(expectedOutput, output);
        }
    }
}

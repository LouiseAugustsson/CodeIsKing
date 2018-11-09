using System;
using Xunit;
using StringReader;

namespace StringReaderTests
{
    public class NiceStringDeciderControllerTests
    {
        NiceStringDeciderController Controller;
        public NiceStringDeciderControllerTests()
        {
            Controller = new NiceStringDeciderController();
        }
        [Theory]
        [InlineData("ugknbfddgicrmopn", true)]
        [InlineData("aaa", true)]
        [InlineData("jchzalrnumimnmhp", false)]
        [InlineData("haegwjzuvuyypxyu", false)]
        [InlineData("dvszwmarrgswjxmb", false)]
        public void ShouldReturnTrueForNiceWord(string input, bool expectedOutput)
        {
            bool output = Controller.CheckIfWordIsNice(input);
            Assert.Equal(expectedOutput, output);
        }
    }
}

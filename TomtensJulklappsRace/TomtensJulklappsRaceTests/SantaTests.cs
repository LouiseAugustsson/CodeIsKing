using System;
using Xunit;
using TomtensJulklappsRace;

namespace TomtensJulklappsRaceTests
{
    public class SantaTests
    {
        Santa santa;
        public SantaTests()
        {
            this.santa = new Santa();
        }

        [Theory]
        [InlineData(new int[] { 1, 1 }, new int[] { 1, 1 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 2 })]
        public void SantaShouldUpdateXPosition(int[] step, int[] expectedOutput)
        {
            santa.Step(step);
            Assert.Equal(expectedOutput[0], santa.position.xPosition);
        }

        [Theory]
        [InlineData(new int[] { 1, 1 }, new int[] { 1, 1 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 2 })]
        public void SantaShouldUpdateYPosition(int[] step, int[] expectedOutput)
        {
            santa.Step(step);
            Assert.Equal(expectedOutput[1], santa.position.yPosition);
        }

    }
}

using System;
using Xunit;
using TomtensJulklappsRace;

namespace TomtensJulklappsRaceTests
{
    public class RuleTranslatorTests
    {
        readonly Santa santa;
        readonly RuleTranslator ruleTranslator;
        public RuleTranslatorTests()
        {
            this.santa = new Santa();
            this.ruleTranslator = new RuleTranslator();
        }

        [Theory]
        [InlineData('<', new int[] { -1, 0 })]
        [InlineData('>', new int[] { 1, 0 })]
        [InlineData('^', new int[] { 0, 1 })]
        [InlineData('v', new int[] { 0, -1 })]
        public void SantaShouldUpdatePosition(char rule, int[] expectedOutput)
        {
            int[] output = this.ruleTranslator.TranslateRule(rule);
            Assert.Equal(expectedOutput, output);
            return;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TomtensJulklappsRace
{
    public class RuleTranslator
    {
        public int[] TranslateRule(char rule)
        {
            if (rule == '>')
            {
                return new int[] { 1, 0 };
            }
            else if (rule == 'v')
            {
                return new int[] { 0, -1 };
            }
            else if (rule == '<')
            {
                return new int[] { -1, 0 };
            }
            else if (rule == '^')
            {
                return new int[] { 0, 1 };
            }
            else throw new ArgumentException("The rule does not exist");
        }
    }
}


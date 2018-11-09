using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReader
{
    public class NiceStringDecider
    {
      public bool CheckIfAtLeastThreeLettersFromList(string inputWord, string letters )
        {
            int counter = 0;
            foreach(char c in inputWord)
            {
                if (letters.Contains(c))
                {
                    counter += 1;
                }
                if (counter == 3)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckIfTwoLettersInARow(string input)
        {
            int counter = 0;
            foreach(char c in input)
            {
                counter += 1;
                if (counter < input.Length)
                {
                    if (input[counter] == c)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool CheckIfNotContainsCombinationFromList(string input, string[] forbidden)
        {
            foreach(string s in forbidden)
            {
                if (input.Contains(s))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

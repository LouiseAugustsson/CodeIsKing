using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace StringReader
{
    public class NiceStringDeciderController
    {
        readonly NiceStringDecider StringDecider;

        public NiceStringDeciderController()
        {
            StringDecider = new NiceStringDecider();
        }

        public bool CheckIfWordIsNice(string input)
        {
            if (!StringDecider.CheckIfAtLeastThreeLettersFromList(input, "aouei"))
            {
                return false;
            }
            if (!StringDecider.CheckIfNotContainsCombinationFromList(input, new string[] { "ab", "cd", "pq", "xy" }))
            {
                return false;
            }
            if(!StringDecider.CheckIfTwoLettersInARow(input))
            {
                return false;
            }
            return true;
        }
    }
}

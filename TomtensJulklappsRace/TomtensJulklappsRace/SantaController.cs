using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomtensJulklappsRace
{
    class SantaController
    {
        Santa santa;
        Santa robotSanta;
        string rules;
        RuleTranslator ruleTranslator;
        public SantaController(Santa santa, Santa robotSanta, RuleTranslator ruleTranslator, string rules)
        {
            this.santa = santa;
            this.robotSanta = robotSanta;
            this.ruleTranslator = ruleTranslator;
            this.rules = rules;
        }

        public void RunSanta()
        {
            int i = 0;
            foreach (char rule in rules)
            {
                int[] step = this.ruleTranslator.TranslateRule(rule);
                if (i % 2 == 0)
                {
                    santa.Step(step);
                }
                else
                {
                    robotSanta.Step(step);
                }
                i += 1;

}
            santa.visitedPositions.AddRange(robotSanta.visitedPositions);
            int uniquePositions = this.santa.GetNumberOfUniqueVisits();
            Console.WriteLine("The santas visited {0} unique houses.", uniquePositions.ToString());
            Console.ReadLine();
            return;
        }

    }
}

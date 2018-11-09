using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StringReader
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../TextFile.txt");
            NiceStringDeciderController controller = new NiceStringDeciderController();
            int numberOfNiceWords = 0;
            string line;
            while((line = sr.ReadLine()) != null)
            {
                if (controller.CheckIfWordIsNice(line))
                {
                    numberOfNiceWords += 1;
                }
            }
            Console.WriteLine(numberOfNiceWords);
            Console.ReadLine();
        }
    }
}

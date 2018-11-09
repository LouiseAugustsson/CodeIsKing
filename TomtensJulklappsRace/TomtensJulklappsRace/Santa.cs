using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomtensJulklappsRace
{
    public class Santa: SantaBase
    {
        public Santa()
        {
            this.position = new Position(new int[] { 0, 0 });
            this.visitedPositions = new List<IPosition>
            {
                new Position(new int[] { 0, 0 })
            };
        }
    }
}

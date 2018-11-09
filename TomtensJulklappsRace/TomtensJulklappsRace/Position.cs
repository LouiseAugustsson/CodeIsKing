using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomtensJulklappsRace
{
    public class Position:IPosition
    {
        public int xPosition { get; set; }
        public int yPosition { get; set; }
    public Position(int[] position)
        {
            xPosition = position[0];
            yPosition = position[1];
        }
    public IPosition CreateNewPosition()
        {
            Position newPosition = new Position(new int[] { this.xPosition, this.yPosition });
            return newPosition; 
        }
    }
}

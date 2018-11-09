using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomtensJulklappsRace
{
    public interface IPosition
    {
        int xPosition { get; set; }
        int yPosition { get; set; }
        IPosition CreateNewPosition();
    }
}

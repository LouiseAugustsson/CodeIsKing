using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomtensJulklappsRace
{
    public abstract class SantaBase
    {
        public IPosition position;
        public List<IPosition> visitedPositions;

        public void Step(int[] step)
        {
            position.xPosition += step[0];
            position.yPosition += step[1];
            SaveToPositions(position);
            return;
        }

        public void SaveToPositions(IPosition position)
        {
            IPosition newPosition = position.CreateNewPosition();
            visitedPositions.Add(newPosition);
            return;
        }

        public int GetNumberOfUniqueVisits()
        {
            return this.visitedPositions
  .GroupBy(p => new { p.xPosition, p.yPosition })
  .Select(g => g.First()).Count();
        }

    }
}

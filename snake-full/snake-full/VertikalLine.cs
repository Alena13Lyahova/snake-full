using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_full
{
    class VertikalLine : Figure
    {
        
        public VertikalLine(int yUp, int yDown, int x, char sim)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }

        }
        
    }
}

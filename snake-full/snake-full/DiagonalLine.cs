using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_full
{
    class DiagonalLine : Figure
    {
        
        public DiagonalLine(int x, int yUp, int yDown, char sim)
        {
            pList = new List<Point>();
            
                    for (int y = yUp; y <= yDown; y++)
                {
                    Point p = new Point(x, y, sim);
                    pList.Add(p);
                    x=x+3;
                }
         }
                
    }
}

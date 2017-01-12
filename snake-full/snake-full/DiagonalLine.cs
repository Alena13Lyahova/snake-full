using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_full
{
    class DiagonalLine
    {
        public DiagonalLine()
        {

        }
        List<Point> pList;
        public DiagonalLine(int x, int yTop, int yDown, char sim)
        {
            pList = new List<Point>();
            
                    for (int y = yTop; y <= yDown; y++)
                {
                    Point p = new Point(x, y, sim);
                    pList.Add(p);
                    x++;
                }
         }
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_full
{
    class Point
    {
        public int x;
        public int y;
        public char sim;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }
    }
}

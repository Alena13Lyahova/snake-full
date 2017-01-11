using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_full
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Func2(x);

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Move(p1, 10, 10);
            p1.Draw();

            Reset(p2);
            p2.Draw();

            Console.ReadLine();
        }
        public static void Func2(int x)
        {
            x = x + 1;
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        public static void Reset(Point p)
        {
            p = new Point();
        }
    }
}

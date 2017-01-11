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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<char> numList = new List<char>();
            numList.Add( '*' );
            numList.Add( '#' );
            numList.Add( '&' );

            char x = numList[0];
            char y = numList[1];
            char z = numList[2];

            foreach (char i in numList)
            {
                Console.WriteLine(i);
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            foreach (Point p in pList)
            {
                p.Draw();
            }

            numList.RemoveAt(0);
            Console.ReadLine();
        }
        
    }
}

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
            Console.SetWindowSize(76, 28);

            HorizontalLine upline = new HorizontalLine(0, 72, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 72, 24, '+');
            VertikalLine leftline = new VertikalLine(0, 24, 0, '+');
            VertikalLine rightline = new VertikalLine(0, 24, 72, '+');
            DiagonalLine diagline = new DiagonalLine(0, 0, 24, '+');

            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();
            diagline.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Console.ReadLine();
        }
        
    }
}

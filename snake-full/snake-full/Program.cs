﻿using System;
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

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Draw();

            VertikalLine line2 = new VertikalLine(5, 10, 18, '&');
            line2.Draw();

            DiagonalLine line3 = new DiagonalLine(5, 18, 28, '&');
            line3.Draw();

            Console.ReadLine();
        }
        
    }
}

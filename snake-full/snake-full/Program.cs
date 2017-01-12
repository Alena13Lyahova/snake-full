using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake_full
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(76, 28);

            Point p = new Point(4, 5, '*');
            Walls walls = new Walls(80, 25);
            walls.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '+');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandltKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

        }
        
    }
}

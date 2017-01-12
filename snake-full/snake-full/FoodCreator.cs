using System;

namespace snake_full
{
    class FoodCreator : Figure
    {
        int mapWidht;
        int mapHeight;
        char sim;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sim)
        {
            this.mapWidht = mapWidth;
            this.mapHeight = mapHeight;
            this.sim = sim;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sim);
        }
    }
}
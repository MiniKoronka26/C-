namespace _003_Task
{
    class Point
    {
        int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX() { return x; }
        public int getY() { return y; }

        public void Print()
        {
            Console.WriteLine($"x: {x}, y: {y})");
        }
    }
}

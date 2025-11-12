namespace _003_Task
{
    class Circle
    {
        Point center;
        int radius;

        public Circle(Point center, int radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Leghts()
        {
            return 2 * Math.PI * radius;
        }

        public bool InorNo(Point p)
        {
            return Math.Sqrt(Math.Pow(p.getX() - center.getX(), 2) + Math.Pow(p.getY() - center.getY(), 2)) <= radius;
        }

        public void Print()
        {
            Console.Write("center: ");
            center.Print();
            Console.WriteLine($"radius: {radius}");
        }
    }
}

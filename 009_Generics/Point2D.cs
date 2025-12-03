namespace _009_Generics
{
    class Point2D<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point2D()
        {
            X = default;
            Y = default;
        }
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"x: {X}, y: {Y}";
        }
    }
}

namespace _009_Generics
{
    class Point3D<T> : Point2D<T>
    {
        public T Z { get; set; }
        public Point3D() : base()
        {
            Z = default;
        }
        public Point3D(T x, T y, T z) : base(x, y)
        {
            Z = z;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, z: {Z}";
        }
    }
}

namespace _004_Properties
{
    class Rectangle
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle() { }
        public int Width {  get; set; }
        public int Height { get; set; }

        public int Area
        {
            get
            {
                return Width * Height;
            }
        }
        public int Perimeter
        {
            get
            {
                return 2 * Height + 2 * Width;
            }
        }
    }
}

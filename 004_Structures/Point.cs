namespace _004_Structures
{
    struct Point
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"x: {X}, y: {Y}");
        }
    }
}

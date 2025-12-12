namespace _012_Events
{
    class Handler1
    {
        public void Message() 
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Handler1: Counter has reached 50.");
            Console.ResetColor();
        }
    }
}

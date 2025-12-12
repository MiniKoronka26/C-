namespace _012_PingPongEvents
{
    class Pong
    {
        public event EventHandler<PingPongEventArgs> pingPongEvent;
        public void Ping(object obj, PingPongEventArgs pingPongEvents)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Pong recives Ping! {pingPongEvents.Count}");
            pingPongEvents.Count += 1;
            Thread.Sleep(100);
            pingPongEvent?.Invoke(this, pingPongEvents);
            Console.ResetColor();
        }
    }
}

namespace _012_PingPongEvents
{
    class Ping
    {
        public event EventHandler<PingPongEventArgs> pingPongEvent;
        public void Pong(object obj, PingPongEventArgs pingPongEvents)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ping recives Pong! {pingPongEvents.Count}");
            pingPongEvents.Count += 1;
            Thread.Sleep(100);
            pingPongEvent?.Invoke(this, pingPongEvents);
            Console.ResetColor();
        }
    }
}

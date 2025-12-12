namespace _012_Events
{
    class Counter
    {

        public event CounterDelegate eventCount;

        public void Count()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(i);
                if(i == 50)
                {
                    /*if(eventCount != null)
                        eventCount();*/
                    eventCount?.Invoke();
                }
            }
        }
    }
}

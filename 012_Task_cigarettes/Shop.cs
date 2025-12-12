using System.Threading.Tasks.Dataflow;

namespace _012_Task_cigarettes
{
    class Shop
    {
        public string Name { get; set; }

        public void Buy_or_no(object obj, ShopEventArgs shop)
        {
            if(shop.Age >= 18)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("you can buy cigarettes!");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("you can`t buy cigarettes!");
                Console.ResetColor();
            }
        
        }
    }
}

namespace _012_Task_cigarettes
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public EventHandler<ShopEventArgs> shopEventArgs;
        public void Buy()
        {
            shopEventArgs?.Invoke(this, new ShopEventArgs { Age = this.Age });
        }
    }
}

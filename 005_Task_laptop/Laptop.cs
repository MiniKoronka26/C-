using System.Xml.Linq;

namespace _005_Task_laptop
{
    class Laptop
    {
        public string Vendor { get; set; }
        public double Price { get; set; }

        public Laptop(string vendor, double price)
        {
            this.Vendor = vendor;
            this.Price = price;
        }
        public Laptop() { }

        public override string ToString()
        {
            return $"Vendor: {Vendor}, Price: {Price}";
        }

    }
}

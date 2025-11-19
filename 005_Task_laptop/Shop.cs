namespace _005_Task_laptop
{
    class Shop
    {
        Laptop[] laptops;

        public Shop(Laptop[] laptops)
        {
            this.laptops = laptops;
        }
        public Shop() { }

        public int Find_index_by_vendor(string vendor)
        {
            for(int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Vendor == vendor)
                    return i;
            }
            return -1;
        }

        public int Find_index_by_price(double price)
        {
            for(int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price)
                    return i;
            }
            return -1;
        }

        public Laptop this[int index]
        {
            get
            {
                return laptops[index];
            }
            set
            {
                if (index >= 0 && index < laptops.Length)
                    laptops[index] = value;
            }
        }
        public Laptop this[string vendor]
        {
            get
            {
                int index = Find_index_by_vendor(vendor);
                return laptops[index];
            }
            set
            {
                int index = Find_index_by_vendor(vendor);
                if (index >= 0 && index < laptops.Length)
                    laptops[index] = value;
            }
        }
        public Laptop this[double price]
        {
            get
            {
                int index = Find_index_by_price(price);
                return laptops[index];
            }
            set
            {
                int index = Find_index_by_price(price);
                if (index >= 0 && index < laptops.Length)
                    laptops[index] = value;
            }
        }

        public override string ToString()
        {
            return string.Join("\n", laptops.Select(l => l.ToString()).ToArray());
        }


    }
}

namespace _004_Enumerations
{
    class Product
    {
        public static double CalculateTotalPrice(double price, Discount discount)
        {
            return price - price / 100 * (int)discount;
        }
    }
}

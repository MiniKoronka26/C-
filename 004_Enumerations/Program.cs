//Перечисленння - це набір іменованих констант

/*DayOfWeek day = (DayOfWeek)Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case DayOfWeek.Monday:
        Console.WriteLine("Понеділок");
        break;
    case DayOfWeek.Tuesday: 
        Console.WriteLine("Вівторок");
        break;
    case DayOfWeek.Wednesday:
        Console.WriteLine("Середа");
        break;
    case DayOfWeek.Thursday:
        Console.WriteLine("Четвер");
        break;
    case DayOfWeek.Friday: 
        Console.WriteLine("П'ятниця");
        break;
    case DayOfWeek.Saturday:
        Console.WriteLine("Субота");
        break;
    case DayOfWeek.Sunday:
        Console.WriteLine("Неділя");
        break;
}*/

using _004_Enumerations;

double res = Product.CalculateTotalPrice(1000, Discount.VIP);
Console.WriteLine(res);
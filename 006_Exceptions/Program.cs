// Виключення(виняткові ситуації)

// try, catch, finallly, throw
/*try
{
    Console.WriteLine("Before Exeption");
    throw new Exception("Test Exception");
    Console.WriteLine("After Exception");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("In finally block");
}*/
/*do {
    try
    {
        int a = Convert.ToInt32(Console.ReadLine());
        if (a < 50)
            throw new Exception("Our number shoud be >= 50");
        int b = Convert.ToInt32(Console.ReadLine());

        int res = a / b;
        Console.WriteLine(res);

        int[] arr = new int[5];

        arr[10] = 5;

    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex) {
        Console.WriteLine(ex.Message);
    }
}while(true);*/

// Створеня власних класів винятків

// Account
// Bank

using _006_Exceptions;

/*List<Account> accounts = new List<Account>()
{
    new Account {
        ID = 1,
        Name = "John",
        Surname = "Smith",
        Balance = 1000
    },
       new Account {
        ID = 2,
        Name = "Den",
        Surname = "Brown",
        Balance = 4343
    },
          new Account {
        ID = 3,
        Name = "John",
        Surname = "Snow",
        Balance = 6656
    }
};

Bank bank = new Bank(accounts);

Account account = new Account
{
    ID = 0,
    Name = "John",
    Surname = "Smith",
    Balance = 1000
};

try
{ 
    bank.Withdraw(account, 1000);
}
catch(NotFoundAccountException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.Account.ID);
}*/

do
{
    int a = 0, b = 0, res = 0;
    try
    {
        Console.WriteLine("Enter first num: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second num: ");
        b = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("\nEnter sign: ");
        int choise = Convert.ToChar(Console.ReadLine());
        switch (choise)
        {
            case '+':
                res = a + b;
                break;
            case '-':
                res = a - b;
                break;
            case '*':
                res = a * b;
                break;
            case '/':
                res = a / b;
                break;
        }
        Console.WriteLine($"res: {res}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
}while (true);
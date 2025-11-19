using _005_Task_laptop;

Shop shop = new Shop(new Laptop[]{
    new Laptop { Vendor = "Lenovo", Price = 2000.0 },
    new Laptop { Vendor = "Apple", Price = 3000.0 },
    new Laptop { Vendor = "MSI", Price = 5000.0 } 
});

Console.WriteLine(shop[0]);
Console.WriteLine(shop["Apple"]);
Console.WriteLine(shop[5000.0]);
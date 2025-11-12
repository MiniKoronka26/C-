using _003_Task;

Point point = new Point(2, 2);
Point center = new Point(0, 0);

Circle circle = new Circle(center, 5);
circle.Print();
Console.WriteLine($"Area: {circle.Area()}");
Console.WriteLine($"Length: {circle.Leghts()}");
Console.WriteLine($"Is point in circle: {circle.InorNo(point)}");
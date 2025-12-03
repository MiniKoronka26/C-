using _009_Generics;

/*MyClass<int> myClass = new MyClass<int>(100);
Console.WriteLine(myClass);
MyClass<string> myClass2 = new MyClass<string>("hello");
Console.WriteLine(myClass2);
MyClass<int> myClass3 = new MyClass<int>();
Console.WriteLine(myClass3);
*/

Point3D<int> point = new Point3D<int>(2, 5, 8);
Console.WriteLine(point);
Point3D<double> point2 = new Point3D<double>(2.3, 3.3, 9.3);
Console.WriteLine(point2);
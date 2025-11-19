using _005_OperatotsOverloading;

/*MyClass obj1 = new MyClass { X = 4 };
MyClass obj2 = new MyClass { X = 3 };

MyClass obj3 = obj1 + obj2;

obj3.Print();

obj3 = obj1 - obj2;

obj3.Print();*/

/*MyArray myArray = new() {
    Arr = [ 4, 7, 1, 0, 5, 1 ] 
};

myArray.Print();

Console.WriteLine(myArray.Length);

myArray[0] = 1;

myArray.Print();*/

/*Student student = new Student() { Name = "John", Age = 20 };

Console.WriteLine(student);*/

Group group = new Group(new Student[]
{
    new Student { Name = "John", Age = 20},
    new Student { Name = "Den", Age = 25},
    new Student { Name = "Jack", Age = 21},
});

Console.WriteLine(group[0]);
Console.WriteLine(group["Den"]);






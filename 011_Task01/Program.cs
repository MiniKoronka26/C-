using _011_Task01;

void MyForeach(Student[] students, MyAction<Student> myAction)
{
    foreach(Student student in students)
    {
        myAction(student);
    }
}
    
void FullNameUpper(Student student)
{
    Console.WriteLine($"{student.FirstName.ToUpper()}\t{student.LastName.ToUpper()}");
}

Student[] students =
{
    new Student{FirstName="John", LastName="Doe"},
    new Student{FirstName="Jane", LastName="Smith"},
    new Student{FirstName="Alice", LastName="Johnson"},
    new Student{FirstName="Bob", LastName="Brown"}
};

MyAction<Student> myAction = FullNameUpper;

MyForeach(students, myAction);

// Готові делегати, які написані в .NET

// Action<T> 
// public delegate void Action<in T>(T obj);

// Func<T, TResult>
// public delegate TResult Func<in T, out TResult>(T arg);

// Predicate<T>
//public delegate bool Predicate<in T>(T obj);

//Comparison<T>
// public delegate int Comparison<in T>(T x, T y);
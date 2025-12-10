// Делегати - це об'єкти, які посилаються на методи
// і за дозволяють викликати ці методи через делегат.

// - для передачі методів як параметрів інших методів
// - є основою для подій і зворотніх випадків

using _011_Delegates;
using System.Xml.Linq;

/*MyClass myClass = new MyClass();

MyDelegate del = new MyDelegate(myClass.Method);

del();

del = myClass.AnotherMethod;

del();*/

/*string str = "str";

Messenger messenger = new Messenger();
MyDelegate02 del = messenger.PrintMessage;

del(str);*/

// Example 2

/*Person[] peopleArray = new Person[]
{
            new Person("Charlie", 45),
            new Person("Diana", 19),
            new Person("Bob", 30),
            new Person("Edward", 52),
            new Person("Alice", 25),
            new Person("Jack", 33),
            new Person("Ivy", 49),
            new Person("Fiona", 38),
            new Person("George", 65),
            new Person("Hannah", 21),
};

Console.WriteLine("Person Array initialized using collection initializer:");
foreach (Person person in peopleArray)
{
    Console.WriteLine(person.ToString());
}

void SortPeople(Person[] people, MyComparerDelegate comparer)
{
    int n = people.Length;
    bool swapped;

    for (int i = 0; i < n - 1; i++)
    {
        swapped = false;

        for (int j = 0; j < n - 1 - i; j++)
        {
            if (comparer(people[j], people[j + 1]))
            {
                Person temp = people[j];
                people[j] = people[j + 1];
                people[j + 1] = temp;

                swapped = true;
            }
        }

        // Оптимізація: якщо внутрішній цикл завершився без жодного обміну, 
        // масив вже відсортований.
        if (swapped == false)
        {
            break;
        }
    }
}

bool ComparerByAge(Person p1, Person p2)
{
    return p1.Age > p2.Age;
}

bool ComparerByName(Person p1, Person p2)
{
    return p1.Name.CompareTo(p2.Name) < 0;
}

SortPeople(peopleArray, ComparerByAge);

Console.WriteLine("---------Sorted by age---------");

foreach (Person person in peopleArray)
{
    Console.WriteLine(person.ToString());
}

SortPeople(peopleArray, ComparerByName);

Console.WriteLine("---------Sorted by name---------");

foreach (Person person in peopleArray)
{
    Console.WriteLine(person.ToString());
}*/

// Example 3 (Multicast)

/*MyClass myClass = new MyClass();

MyDelegate del = myClass.Method;

del += myClass.AnotherMethod;

del();

Console.WriteLine();

del -= myClass.Method;

del();*/

// Example 4 (Generic Delegates)

int Add(int a, int b)
{
    return a + b;
}

int Multiply(int a, int b)
{
    return a * b;
}

double AddDouble(double a, double b)
{
    return a + b;
}

string AddString(string a, string b)
{
    return a + b;
}

/*OperationDelegate<double> operationDelegate = AddDouble;
double res = operationDelegate(4.1, 5.5);
Console.WriteLine(res);*/

StringDelegate stringDelegate = AddString;
string res = stringDelegate("hello", " world");
Console.WriteLine(res);



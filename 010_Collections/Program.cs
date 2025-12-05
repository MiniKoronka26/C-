// ArrayList

using _010_Collections;
using System.Collections;

/*ArrayList arrayList = new ArrayList();

arrayList.Add(1);
arrayList.Add(100.22);
arrayList.Add("Hello");
arrayList.Add(true);*/

/*foreach (object i in arrayList)
{
    Console.WriteLine(i);
}*/

/*Console.WriteLine(arrayList[0]);
int a = (int)arrayList[0];*/

/*ArrayList arrayList = new ArrayList()
{
    10 ,45 ,-3, 0, 100, 9, 55
};

arrayList.Add(88);
arrayList.AddRange(new[] { 1, -33, 99 });

arrayList.RemoveAt(0); //delete at index
arrayList.Remove(45); //by value
arrayList.Insert(7, 3333);//add value at index

arrayList.Reverse();

arrayList.Sort();

foreach (var item in arrayList)
{
    Console.WriteLine($"{item}");
}*/

/*ArrayList arrayList = new ArrayList()
{
    new Person("Swift", 23),
    new Person("Fedak", 13),
    new Person("Mazepa", 15)
};

foreach (object i in arrayList)
{
    Console.WriteLine(i);
}

arrayList.Sort();
Console.WriteLine("----------");

foreach (object i in arrayList)
{
    Console.WriteLine(i);
}

arrayList.Sort(new PersonAgeComparer());
Console.WriteLine("----------");

foreach (object i in arrayList)
{
    Console.WriteLine(i);
}*/

/*List<int> numbers = new List<int>()
{
    20, 10, 1000, 50, 60
};
numbers.Add(100);
numbers.AddRange(new List<int> { 1, 2, 3 });
numbers.Remove(1);
numbers.Sort((a, b) => b.CompareTo(a));

foreach(int item in numbers)
{
    Console.WriteLine(item);
}*/

/*Stack<int> stack = new Stack<int>();

stack.Push(10);
stack.Push(20);
stack.Push(30);

foreach(int item in stack)
{
    Console.WriteLine(item);
}*/

/*Queue<int> q = new Queue<int>();
q.Enqueue(15);
q.Enqueue(43);
q.Enqueue(13);
q.Enqueue(-3);
q.Enqueue(23);
q.Enqueue(45);
q.Enqueue(333);

foreach(int i in q)
{
    Console.WriteLine(i);
}*/

// SortedDictionary
SortedDictionary<int, string> d = new SortedDictionary<int, string>();

d.Add(10, "ten");
d.Add(3, "three");
d.Add(9, "nine");
d.Add(6, "six");

foreach(var item in d)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
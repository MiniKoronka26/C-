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


ArrayList arrayList = new ArrayList()
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
}

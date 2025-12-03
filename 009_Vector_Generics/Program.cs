using _009_Vector_Generics;

int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Vector<int> vector = new Vector<int>(a);
foreach (int i in vector)
{
    Console.WriteLine(i);
}

Console.WriteLine("==========");

string[] b = { "hello", "my", "world", "!" };
Vector<string> vector2 = new Vector<string>(b);
foreach (string i in vector2)
{
    Console.WriteLine(i);
}
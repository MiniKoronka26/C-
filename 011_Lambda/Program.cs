using _011_Lambda;

MyDelegate myDelegate = (a, b) => a + b;


int res = myDelegate(3, 6);
Console.WriteLine(res);
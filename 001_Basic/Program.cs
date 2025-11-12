/*Console.WriteLine("Hello C#");
Console.WriteLine("Next line");*/  //cw -> Console.WriteLine();

// 1 = 8
// 4 = 32

/*int a = 5, b = 6;

//var b = 6;// var = auto(in c++)

Console.WriteLine("a = " + a + ", b = " + b);//old
Console.WriteLine($"a = {a}, b = {b}");*/

/*Console.Write("enter number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("enter number 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int sum = a + b;
int minus = a - b;
int multip = a * b;
int division = a / b;
int divMod = a % b;

Console.WriteLine($"a = {a}, b = {b}\n sum = {sum}, minus = {minus}, multip = {multip}, division = {division}, divMod = {divMod}");*/

// типи знеченннь структурні(value types) - базуються на стукткрах і пов'язані з копіюванням значень
// типи посилань(reference types) - базуються на класах і пов'язанні із копіюванням посилань

/*int a = 5;
int b = a;*/

/*using _001_Basic;

Point p1 = new Point();

p1.X = 10;
p1.Y = 20;

Console.WriteLine($"X: {p1.X}, Y: {p1.Y}");

//Point p2 = p1; //p2 - вказівник на p1

Point p2 = new Point(); 

p2 = p1; // пам'ять p2 втрачається

p2.X = 1000;

Console.WriteLine($"X: {p1.X}, Y: {p1.Y}");*/


// тернарний оператор

/*int a = 5, b = 7;

int max = a > b ? a : b;

Console.WriteLine(max);*/

// if else

/*int a = 10;

if (a > 5)
    Console.WriteLine("hello");
else
    Console.WriteLine("goodbye");*/

/*Console.Write("enter number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("enter sign: ");
string s = Console.ReadLine();
Console.Write("enter number 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int res = 0;
switch (s)
{
    case "+":
        res = a + b;
        break;
    case "-":
        res = a - b;
        break;
    case "*":
        res = a * b;
        break;
    case "/":
        res = a / b;
        break;

}

Console.WriteLine($"res = {res}");*/

/*int i = 1;

while(i < 100)
{
    Console.WriteLine(i);
    i++;
}*/

/*int[] arr = { 1, 5, -2, 5, 100 };

foreach(int el in arr)
{
    Console.Write(el + " ");
}*/
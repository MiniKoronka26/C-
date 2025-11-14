//Структури

//класи

// values types(типи значень, структурні)
// reference types(типи посилань)

/*int a = 4;
int b = a;*/

using _004_Structures;

Point point1 = new Point() { X = 10, Y = 20};
Point point2 = point1;

point2.X = 10000;

Console.WriteLine(point1.X);

point1.Print();
point2.Print();

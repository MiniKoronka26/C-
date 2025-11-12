// Одновимірні масиви

//int[] arr = new int[] { 4, 7, 1, -3, 2 };

/*int[] arr = { 4, 7, 1, -3, 2 };

for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}*/

/*Console.Write("enter size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr  = new int[size];

Random random = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(-50, 50);
}

*/
/*for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}*/
/*

foreach (int item in arr)
{
    Console.Write(item + " ");
}

Console.WriteLine($"\n{arr.Max()}"); 
Console.WriteLine(arr.Min()); 
Console.WriteLine(arr.Average()); 
Console.WriteLine(arr.Sum()); */

/*int[,] arr = new int[,]
{
    { 8, 0, 1, -4 },
    { 100, 2, 9, 6 },
    { 1, 11, 100, 3 }
};*/

/*Console.ForegroundColor = ConsoleColor.Yellow;*/ //color of text
/*Console.BackgroundColor = ConsoleColor.Blue;*/ // color of bg

/*for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}*/

Console.Write("enter size 1: ");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter size 2: ");
int s2 = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[s1, s2];

Random random = new Random();

int sum = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(-50, 50);
    }
}

Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[i, j];
    }
}

Console.WriteLine($"sum: {sum}");
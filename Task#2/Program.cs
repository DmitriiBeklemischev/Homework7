// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента, или же указание, что такого элемента нет.

int[,] GetArray()
{
    int m = new Random().Next(1, 10);
    int n = new Random().Next(1, 10);
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] arrayOne = new int[2];
for (int i = 0; i < 2; i++)
{
    Console.Write($"Введите {i + 1}ю позицию массива = ");
    arrayOne[i] = int.Parse(Console.ReadLine());
}

int[,] arrayTwo = GetArray();

PrintArray(arrayTwo);

if (arrayOne[1] <= arrayTwo.GetLength(0)
     && arrayOne[0] <= arrayTwo.GetLength(1))
{
    Console.WriteLine($"Число в позициях {arrayOne[0]}:{arrayOne[1]} = {arrayTwo[arrayOne[1]-1, arrayOne[0]-1]}");
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}
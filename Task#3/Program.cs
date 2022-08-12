//  Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
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
Console.WriteLine("Введите длинну столбцов массива");
int lengthM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длинну строк массива");
int lengthN = int.Parse(Console.ReadLine());

int[,] array = GetArray(lengthM, lengthN);
PrintArray(array);


for (int i = 0; i < array.GetLength(1); i++)
{
    
    double sum = 0;

    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array[j, i];

    }
    if (i == 0)
    {
        Console.Write("Среднее арифметическое каждого столбца: ");
    }

    Console.Write($"{Math.Round(sum / array.GetLength(0), 1)}; ");
}


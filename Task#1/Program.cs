// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * 100, 1);
        }
    }
    return result;
}


void PrintArray(double[,] inArray)
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
Console.WriteLine("Введите длинну строк массива");
int lengthM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длинну столбцов массива");
int lengthN = int.Parse(Console.ReadLine());

PrintArray(GetArray(lengthM, lengthN));

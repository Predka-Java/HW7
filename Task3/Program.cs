// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.\

void FindArithmeticMean(int[,] arr)
{
    double sum = 0;
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i,j];
        }
        double res = sum / arr.GetLength(0);
        Console.Write($"{res} | "); 
    }
}

void PrintArray(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray()
{
    Random rnd = new Random ();
    int[,] arr = new int [rnd.Next(3, 10), rnd.Next(3, 10)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

int[,] arr = FillArray();
PrintArray(arr);
Console.WriteLine();
FindArithmeticMean(arr);

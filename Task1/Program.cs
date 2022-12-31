// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArray(double[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
double[,] FillArray(int col, int row, int begin, int end) {
    double[,] arr = new double [row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
           arr[i, j] = Convert.ToDouble(new Random().Next(begin, end)) / 10;
        }
    }
    return arr;
}

int CheckNum(string text) {
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}


Console.WriteLine("Задайте длину массива: ");
int row = CheckNum("Длина массива ");
Console.WriteLine("Задайте ширину массива: ");
int col = CheckNum("Ширина массива ");

double[,] arr = FillArray(row, col, 00, 100);
PrintArray(arr);
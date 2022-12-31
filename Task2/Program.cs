// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

string FindElement(int[,] arr, int row, int col)
{
    string res ="Заданного диапазона не существует в текущем массиве...";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i == row-1 && j == col-1)
            {
                res = Convert.ToString(arr[i, j]);
            }
        }
    }
    return res;
}

void PrintArray(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           Console.Write(arr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray() {
    int[,] arr = new int [10, 10];

    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
           arr[i, j] = new Random().Next(-10, 10);
        }
    }
    return arr;
}

int CheckNum(string text) {
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
Console.Clear();

int[,] arr = FillArray();
PrintArray(arr);

Console.WriteLine("Введите номер строки: ");
int row = CheckNum("Номер строки ");
Console.WriteLine("Введите номер столбца: ");
int col = CheckNum("Номер столбца ");

string res = FindElement(arr, row, col);
Console.WriteLine(res);

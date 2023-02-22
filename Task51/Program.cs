/*Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12       */

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GenerateMatrix(int rows, int colums, int from, int to)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(from, to + 1);
        }
    }
    return result;
}

void ShowMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int colums = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int FindSumMainDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)     // откорректировено после семинара: убран второй цикл
    {
        sum = sum + matrix[i, i];
    }
    return sum;
}

int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");
int[,] matrix = GenerateMatrix(m, n, 1, 10);
ShowMatrix(matrix);
int sumDiagonal = FindSumMainDiagonal(matrix);
System.Console.WriteLine($"Сумма элементов главной диагонали матрицы составляет: {sumDiagonal}");

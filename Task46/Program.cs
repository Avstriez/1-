/*Задайте двумерный массив размером m×n, 
заполненный случайными целыми
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1    */

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
            result[i,j] = new Random().Next(from, to + 1);
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
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");
int[,] matrix = GenerateMatrix(m, n, -100, 100);
ShowMatrix(matrix);
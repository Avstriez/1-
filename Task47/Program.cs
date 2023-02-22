/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9    */

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[,] GenerateMatrix(int rows, int colums)
{
    double[,] result = new double[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().NextDouble() * 10; 
        }
    }
    return result;
}

void ShowMatrix(double[,] matrix)
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

int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");
double[,] matrix = GenerateMatrix(m, n);
ShowMatrix(matrix);
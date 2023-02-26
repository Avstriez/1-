/* Задайте двумерный массив.
Напишите программу, которая поменяет местами первую и последнюю строку местами.     */

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

int[,] ReplaceRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int value = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = value;
    }
    return array;
}


int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");
int[,] matrix = GenerateMatrix(m, n, 1, 10);
ShowMatrix(matrix);
Console.WriteLine(); 
int[,] matrix2 = ReplaceRow(matrix);
ShowMatrix(matrix2); 
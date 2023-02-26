/* Задайте двумерный массив.
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа вывести сообщение для пользователя.    */

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

int[,] Transp(int[,] array)
{
    int sizeM = array.GetLength(0);
    int sizeN = array.GetLength(1);
    int[,] arrayNew = new int[sizeN, sizeM];

    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            arrayNew[j, i] = arrayNew[i, j];
        }
    }
    return arrayNew;
}

int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");

int[,] matrix = GenerateMatrix(m, n, 1, 10);

ShowMatrix(matrix);

Console.WriteLine();

int[,] arrayTransp = Transp(matrix); 

ShowMatrix(arrayTransp);
/* (не доделано) Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.  */

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

int[,] GetMinus(int[,] matrix)
{
    int sizeM = matrix.GetLength(0);
    int sizeN = matrix.GetLength(1);
    int min = matrix[0, 0];
    int minX = 0;
    int minY = 0;

    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            arrayNew[matrix[i, j]] += 1;
        }
    }
    return arrayNew;
}

int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");
int[,] matrix = GenerateMatrix(m, n, 0, 9);
ShowMatrix(matrix);

int[] arrayMin = GetMinus(matrix);
ShowMatrix(arrayMin);
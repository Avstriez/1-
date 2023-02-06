//Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

void GetSumPlusOrMinus(int[] arr)
{
    int size = arr.Length;
    for (int index = 0; index < size; index++)
    {
        arr[index] = arr[index] * -1;
    }
}

int[] GetArray(int size, int start, int finish)
{
    int[] emptyArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        emptyArray[index] = new Random().Next(start, finish + 1);
    }
    return emptyArray;
}

int[] array = GetArray(4, -9, 9); // Генерируем массив
Console.WriteLine(string.Join(", ", array));

GetSumPlusOrMinus(array); // Меняем отрицательные -> положительные
Console.WriteLine(string.Join(", ", array));
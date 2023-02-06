/*Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int CountNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <100 && arr[i] > 10)
        {
            count++;
        }
    }
    return count;
}

int[] GetArray(int size, int from, int to)
{
    int[] emptyArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        emptyArray[index] = new Random().Next(from, to + 1);
    }
    return emptyArray;
}

int[] array = GetArray(123, 0, 123); // Генерируем массив
Console.WriteLine(string.Join(", ", array));

int num = CountNumbers(array);
Console.WriteLine(num);
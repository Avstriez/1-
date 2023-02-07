// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int EvenNumber(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
    res++;
    return res;
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

int[] array = GetArray(4, 100, 1000); // Генерируем массив
Console.WriteLine(string.Join(", ", array));

int res = EvenNumber(array);
Console.WriteLine(res);
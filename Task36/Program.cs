// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


 int OddNumbers(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    if (i % 2 != 0) res = res + array[i];
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

int res = OddNumbers(array);
Console.WriteLine(res);
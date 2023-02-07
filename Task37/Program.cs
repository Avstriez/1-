/*НЕ РАБОТАЕТ!!! Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] MultiplicationNumbers(int[] array)
{
    int len = (array.Length + array.Length % 2) / 2;
    int[] arrayResult = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrayResult[i] = array[i] * array[^(i+1)];
    }

    if(array.Length % 2 == 1)
    {
        arrayResult[^1] = array[len - 1];
    }
    return arrayResult;
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

int[] array = GetArray(4, 1, 9); // Генерируем массив
Console.WriteLine(string.Join(", ", array));

int[] arrayResult = MultiplicationNumbers(array);
Console.WriteLine(arrayResult);
/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3   */

int GetSum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count = count + 1;
    }
    return count;
}

int[] GetArray(int size, int from, int to)
{
    int[] emptyArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        emptyArray[i] = new Random().Next(from, to + 1); //Ввод данных был сделан рандомно из-за лени(в здравом смысле) =)
    }
    return emptyArray;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int valuesCount = GetNumber("Введите размер массива: ");
int[] numArray = GetArray(valuesCount, -9, 9);
Console.WriteLine(string.Join(", ", numArray));
int sum = GetSum(numArray);
Console.WriteLine(sum);
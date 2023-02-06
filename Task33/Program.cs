//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

string FindNumber(int[] arr, int find)
{
    int size = arr.Length;
    for (int index = 0; index < size; index++)
    {
        int number = arr[index];

        if (number == find)
        {
            return "da";
        }
    }
    return "no";
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

int[] array = GetArray(12, 0, 9); // Генерируем массив
Console.WriteLine(string.Join(", ", array));

Console.WriteLine("В массиве число 4 -> " + FindNumber(array, 4));



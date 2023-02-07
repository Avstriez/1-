//Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int GetMinMaxNumber(int[] array, bool max)
{
    int minN = array[0];
    int maxN = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        int num = array[i];
        if (minN > num) minN = num;
        if (maxN < num) maxN = num;
    }
    if (max == false) return minN;
    return maxN;
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

int[] array = GetArray(4, 1, 100); // Генерируем массив
Console.WriteLine(string.Join(", ", array));
int maxNumber = GetMinMaxNumber(array, true);
int minNumber = GetMinMaxNumber(array, false);

Console.WriteLine($"разница между {maxNumber} и {minNumber} = {maxNumber - minNumber}");


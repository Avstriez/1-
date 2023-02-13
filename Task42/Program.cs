/*Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

string GetDouble(int num)
{
    string str = "";
    while (num > 0)
    {
        str = Convert.ToString(num % 2) + str;
        num = num / 2;
    }
    return str;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = GetNumber("Введите число: ");
Console.WriteLine($"{num} -> {GetDouble(num)}");
/*(РЕКУРСИЯ) Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"     */

void PrintNumbers(int N)
{
    if (N == 0) return;
    PrintNumbers(N -1);
    Console.Write($"{N}, ");
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = GetNum("Введите число N: ");
PrintNumbers(number);
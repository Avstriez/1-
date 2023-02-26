/*(РЕКУРСИЯ) Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"     */


void PrintNumbersBetween(int fromNum, int toNum)
{
    if (fromNum == toNum)
    {
        Console.WriteLine(fromNum);
        return;
    }
    Console.Write(fromNum + ", ");
    PrintNumbersBetween(fromNum +1, toNum); 
}


int GetNum(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int m = GetNum("Введите число m: ");
int n = GetNum("Введите число n: ");
PrintNumbersBetween(m, n); 

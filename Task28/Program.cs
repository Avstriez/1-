//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

int GetSum(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)  // так тоже можно for (int i = 1; i <= num; i++) result = result + i;
    {                               //                return result;
        result = result * i;
    }
    return result;
}

int GetNumber(string text) //создаем первый метод(функцию)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//1. Ввод данных
int number = GetNumber("ВВедите число: ");

Console.WriteLine(number + " -> " + GetSum(number));
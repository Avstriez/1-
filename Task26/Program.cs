//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

void LenNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        number = number / 10;
        result++;
    }
    Console.Write(result);
}


int GetNumber(string text) //создаем первый метод(функцию)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//1. Ввод данных
int number = GetNumber("ВВедите число: ");

Console.Write($"{number} -> ");

LenNumber(number);

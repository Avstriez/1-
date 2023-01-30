//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36



int GetSum(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)  // так тоже можно for (int i = 1; i <= num; i++) result = result + i;
    {                               //                return result;
        result = result + i;
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


//2. В цикле суммируем все числа


Console.WriteLine(number + " -> " + GetSum(number));


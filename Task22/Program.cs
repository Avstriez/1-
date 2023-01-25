//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

void OutNumbers(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.Write(Math.Pow(i, 2)); //Math.Pow (степень) или i*i
        if (i < num) Console.Write(", "); //Проверка чтобы не ставить ,
        i++;
    }
}

int GetNum(string text) //создаем первый метод(функцию)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//Ввод данных от пользователя х, у
int number = GetNum("Введите число N");

Console.Write("Результат: ");

OutNumbers(number);
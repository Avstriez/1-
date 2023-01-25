//Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void CheckQuaters(int x, int y) //создаем второй метов(функцию)
{
    if (x > 0 & y > 0)
    {
        Console.WriteLine(1);
    }
    if (x < 0 & y > 0)
    {
        Console.WriteLine(2);
    }
    if (x < 0 & y < 0)
    {
        Console.WriteLine(3);
    }
    if (x > 0 & y < 0)
    {
        Console.WriteLine(4);
    }
}


int GetNum(string text) //создаем первый метод(функцию)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//Ввод данных от пользователя х, у
int x = GetNum("Введите значение х");
int y = GetNum("Введите значение y");

Console.Write("четверть: "); 

//Определить четверть
CheckQuaters(x, y);


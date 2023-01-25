//Напишите программу, которая 
//по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

void CheckXY(int quot) //создаем второй метод(функцию)
{
    if (quot == 1) Console.WriteLine("x > 0 и y > 0");
    if (quot == 2) Console.WriteLine("x < 0 и y > 0");
    if (quot == 3) Console.WriteLine("x < 0 и y < 0");
    if (quot == 4) Console.WriteLine("x > 0 и y < 0");
}

int GetNum(string text) //создаем первый метод(функцию)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//Ввод данных от пользователя 
int quot = GetNum("Введите четверть");

Console.Write("диапазон: "); 

//Определить четверть
CheckXY(quot);
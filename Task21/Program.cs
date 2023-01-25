//Напишите программу, 
//которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.

void GetDist(int x1, int y1, int x2, int y2)
{
    double dist = Math.Pow(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2), 0.5);
    Console.Write(dist);
}

int GetNum(string text) //создаем первый метод(функцию)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//Ввод данных от пользователя х, у
int x1 = GetNum("Введите значение х1");
int y1 = GetNum("Введите значение y1");
int x2 = GetNum("Введите значение x2");
int y2 = GetNum("Введите значение y2");

Console.Write("Дистанция: ");

GetDist(x1, y1, x2, y2);
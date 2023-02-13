/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)    */

string GetCrossPoint(int b1, int k1, int b2, int k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    return $"({x}; {y})";
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int b1 = GetNumber("Введите значение b1: ");
int k1 = GetNumber("Введите значение k1: ");
int b2 = GetNumber("Введите значение b2: ");
int k2 = GetNumber("Введите значение k2: "); //$"две прямые пересекутся в точке с координатами

Console.WriteLine($"две прямые пересекутся в точке с координатами: {GetCrossPoint(b1, k1, b2, k2)}");
/*Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/

void CheckTriangle(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int numX = GetNumber("Введите число X: ");
int numY = GetNumber("Введите число Y: ");
int numC = GetNumber("Введите число C: ");
CheckTriangle(numX, numY, numC);
﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (count <= number)
{
    if (count % 2 < 1)
    {
        Console.Write($"{count} ");
    }
    count++;
}
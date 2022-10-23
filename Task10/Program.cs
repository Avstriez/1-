// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления). 456

Console.WriteLine("Напишите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int middleDigit = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {middleDigit}");
}
else Console.WriteLine("Вы ввели не трехзначное число!");
//Решение с task07=)
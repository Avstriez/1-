﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет 2ю цифру этого числа.
// 456 -> 46

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число {number}");

// int firstDigit = number / 100;
// int thirdDigit = number % 10;

// int digit = firstDigit * 10 + thirdDigit;

// Console.WriteLine($"Полученное число {digit}");

int DelSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}

int result = DelSecondDigit(number);
Console.WriteLine($"Полученное число {result}");

// Напишите программу, которая которая принимает на вход трехзначное число и на выходе показывает последнюю цифру.
// 456 -> 6 =))

Console.WriteLine("Напишите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int lastDigit = number % 10;  //456 % 10 = 6
    Console.WriteLine($"Последняя цифра числа {lastDigit}");
}
else Console.WriteLine("Вы ввели не трехзначное число!");

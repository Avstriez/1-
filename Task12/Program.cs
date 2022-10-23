// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 1 не кратно числу 2, то выводить остаток от деления.


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
    Console.WriteLine("кратно");
else
Console.WriteLine($"не кратно, остаток {number1 % number2}");
